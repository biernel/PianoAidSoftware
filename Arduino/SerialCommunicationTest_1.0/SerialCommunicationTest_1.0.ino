#include "HeartBeat.h"

HeartBeat HB;
int buttonPin = 7;

void setup() {
  // put your setup code here, to run once:

  InitializeHeartBeat();
  InitializeButton();
  InitializeUsbCommunication();
  
}
void InitializeHeartBeat() {
//  Serial.begin(115200);
//  Serial.println(__FILE__);
  Serial.println(HEARTBEAT_LIB_VERSION);

  pinMode(LED_BUILTIN, OUTPUT);
  HB.begin(LED_BUILTIN, 0.5);  // frequency 0.5
}

void InitializeButton(){
  pinMode(buttonPin, INPUT);
}

void InitializeUsbCommunication(){
  Serial.begin(9600);  //initialize serial comm 
}

void HeartBeatFast(){
  Serial.println("Heartbeat fast");
  HB.begin(LED_BUILTIN, 8);
}

void HeartBeatSlow(){
  Serial.println("Heartbeat slow");
  HB.begin(LED_BUILTIN, 2);
}

void loop() {

  HB.beat();

//  int valButtonPin = digitalRead(buttonPin);
  //digitalWrite(LED_BUILTIN, valButtonPin);
//  if (valButtonPin)
//    HeartBeatFast();
//  else
//    HeartBeatSlow();
  

  if (Serial.available()) {
    int serialData = Serial.read();
    if(serialData == '1'){
      HeartBeatFast();
    }
    else {
      HeartBeatSlow();
    }
  }

}
