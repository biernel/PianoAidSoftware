#include "HeartBeat.h"
#include <FastLED.h>

#define LED_PIN     7
#define NUM_LEDS    22
#define WHILE_BREAKER_INPUT_PIN 4

CRGB leds[NUM_LEDS];

HeartBeat HB;

void setup() {
  InitializeHeartBeat();
  InitializeUsbCommunication();

  pinMode(WHILE_BREAKER_INPUT_PIN, INPUT);
  
  FastLED.addLeds<WS2812, LED_PIN, GRB>(leds, NUM_LEDS);
  
  clearAllLeds();
}

void InitializeHeartBeat() {

//  Serial.begin(115200);
//  printToSerial(__FILE__);
  printToSerial(HEARTBEAT_LIB_VERSION);

  pinMode(LED_BUILTIN, OUTPUT);
  HB.begin(LED_BUILTIN, 0.5);  // frequency 0.5
}

void InitializeUsbCommunication(){
  Serial.begin(9600);  //initialize serial comm 
}

void HeartBeatFast(){
  HB.begin(LED_BUILTIN, 8);
}

void HeartBeatSlow(){
  HB.begin(LED_BUILTIN, 2);
}
void HeartBeatIdle(){
  HB.begin(LED_BUILTIN, 0.5);
}


void printToSerial(String string){
  Serial.print(string);
}

String inputString = "";
bool inputStringComplete = false;
String previousInChar = "";
void loop() {
  HB.beat();
      
  if(inputStringComplete){
    inputStringComplete = false;
    printToSerial(inputString);
    String command = inputString;
    command.replace("#>","");
    inputString = "";
    printToSerial(command);
    clearAllLeds();

    int maxLeds = 100;
    int arrLedIds[maxLeds];
    int numberOfSetLeds = getLedArray(command, maxLeds, arrLedIds);

    //printToSerial(String(numberOfSetLeds));
    for (int i = 0; i < numberOfSetLeds ;i++){
      leds[arrLedIds[i]] = CRGB(10, 10, 0);  
    }
    FastLED.show();
  }
}

int getLedArray(String command, int maxLeds, int arrLedIds[]){ //returns number of set Leds

    int ledCounter = 0;
    String strLedId = "";
    //printToSerial(String(command.length()));
    for(int i = 0; i < command.length(); i++ ) {
       char c = command[i];
       if(i%2 == 0){
          strLedId = String(c);
          //printToSerial(strLedId);
       }
       else {
        strLedId += String(c);
        //printToSerial(strLedId);
        arrLedIds[ledCounter] = strLedId.toInt();
        //printToSerial(String(arrLedIds[ledCounter]));
        ledCounter++;
        if(ledCounter > maxLeds-1)
          break;
       }
    }
    return ledCounter;
}

void serialEvent() {
  while (Serial.available()) {
     //HeartBeatFast();
     bool val = digitalRead(WHILE_BREAKER_INPUT_PIN);
     if(val == false)
        break;
    
    // get the new byte:
    char inChar = (char)Serial.read();
    //Serial.println(inChar);
    inputString += inChar;
    // if the last incoming characters are #> set a flag
    // so the main loop can do something with it:
    if (previousInChar == "#" && inChar == '>') {
      inputStringComplete = true;
      //Serial.println("inputString Complete");
    }
    previousInChar = inChar;
    //delay(1);
  }
  //HeartBeatIdle();
}

void clearAllLeds(){
  
    for(int i = 0;i<22;i++){
      leds[i] = CRGB(0, 0, 0);
    }
    FastLED.show();
    printToSerial("All Leds cleared");
}
