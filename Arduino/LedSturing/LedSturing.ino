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
  
  FastLED.addLeds<WS2812, LED_PIN, GRB>(leds, NUM_LEDS);
  pinMode(WHILE_BREAKER_INPUT_PIN, INPUT);
}

void InitializeHeartBeat() {

//  Serial.begin(115200);
//  Serial.println(__FILE__);
  Serial.println(HEARTBEAT_LIB_VERSION);

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


String inputString = "";
bool stringComplete = false;

void loop() {
  HB.beat();
       
  if(stringComplete){
    stringComplete = false;
    clearAllLeds();

    
    if(inputString == "2\n")
      {
        leds[5] = CRGB(10, 10, 0);
        leds[3] = CRGB(10, 10, 0);
        FastLED.show();
      }
  
  
  }
}

void serialEvent() {
  while (Serial.available()) {
     HeartBeatFast();
     bool val = digitalRead(WHILE_BREAKER_INPUT_PIN);
     if(val == false)
        break;
  
    // get the new byte:
    char inChar = (char)Serial.read();
    inputString += inChar;
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
  HeartBeatIdle();
}



void clearAllLeds(){
    for(int i = 0;i<22;i++){
      leds[i] = CRGB(0, 0, 0);
      FastLED.show();
    }
}
