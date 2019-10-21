/*
Arduino 2x16 LCD - Detect Buttons
modified on 18 Feb 2019
by Saeed Hosseini @ Electropeak
https://electropeak.com/learn/
*/
#include <LiquidCrystal.h>
//LCD pin to Arduino
const int pin_RS = 8; 
const int pin_EN = 9; 
const int pin_d4 = 4; 
const int pin_d5 = 5; 
const int pin_d6 = 6; 
const int pin_d7 = 7; 
const int pin_BL = 10; 
LiquidCrystal lcd( pin_RS,  pin_EN,  pin_d4,  pin_d5,  pin_d6,  pin_d7);


String inputString = "";         // a string to hold incoming data
boolean stringComplete = false;  // whether the string is complete
String commandString = "";

boolean isConnected = false;
void Read_Keys();
void getCommand();
String getTextToPrint();
void printText(String text);

int EndOfCommend;
int EndOfdata;


void setup() {
 Serial.begin(9600); 
 lcd.begin(16, 2);
 lcd.setCursor(0,0);
 lcd.print("  Smart Rabbit ");
 lcd.setCursor(0,1);
 lcd.print("Press Key:");
}
void loop() {
   if(Serial.available()) serialEvent();
  if(stringComplete)
  {
      stringComplete = false;
      getCommand();
      
      if(commandString.equals("START"))
      {
        lcd.clear();
      }
      if(commandString.equals("STOP"))
      {
        lcd.clear();
        lcd.print("Ready to connect");    
      }
      else if(commandString.equals("LINE1"))
      {
        String text = getTextToPrint();
        printText(text,1);
      }
       else if(commandString.equals("LINE2"))
      {
        String text = getTextToPrint();
        printText(text,2);
      }
      else if(commandString.equals("CLEAR"))
      {
        lcd.clear();
      }
    inputString = "";
  }
  delay(100);
  
}



void initDisplay()
{
  lcd.begin(16, 2);
  lcd.print("Ready to connect");
}



void getCommand()
{
  if(inputString.length()>0)
  {  
     EndOfCommend=inputString.indexOf(',');
     commandString = inputString.substring(1,EndOfCommend);
     Serial.println(commandString);
  }
}




String getTextToPrint()
{
  String value = inputString.substring(EndOfCommend+1,inputString.length()-2);
  Serial.println(value);
  return value;
}

void printText(String text,int index)
{
  
    if(index==1)
    {
      lcd.setCursor(0,0);
      lcd.print(text);
    }else if(index==2)
    {
      lcd.setCursor(0,1);
      lcd.print(text);
    }
}

void serialEvent() {
  while (Serial.available() && stringComplete == false) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    inputString += inChar;
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}

