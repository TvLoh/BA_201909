/*
 Name:    VD30_Slave_02_Sketch.ino
 Created: 5/29/2019 10:39:46 AM
 Author:  Thomas von Loh
 Version: 3.0
 Arduino: Digispark

 The Digispark is just to measure the rotation speed of the DM30. 
 It is to prevent runtime errors.
 The communication with the Master Module is realized over I2C.
*/

#include <twi.h>
#include <TinyWire.h>
#define ADDRESS_I2C 2
#define HALL_SENS 3

// HALL/Speed
unsigned int time_hall_delay = 25000;
int send_value = 255;
bool hall_check_rise = true;
unsigned long time_hall_antibeat = micros();
unsigned long time_hall_intervall = micros() ;


void requestEvent()
{
//  TinyWire.write(time_hall_delay);
  TinyWire.send(send_value);
}

void setup() {
  pinMode(HALL_SENS, INPUT);
  time_hall_antibeat = micros();

  TinyWire.begin(ADDRESS_I2C);
  TinyWire.onRequest(requestEvent);
}


void loop() {
  if (digitalRead(HALL_SENS) == HIGH)                 
  {
    //if (time_hall_antibeat + 50 < micros())             // Be sure the HIGH Signal is not a wrong signal.
    {
      if (hall_check_rise == true)                      // Prevent for retriggering the measurement.
      {
        hall_check_rise = false;
        time_hall_delay = micros() - time_hall_intervall;     // Measure time since the last pass.
        time_hall_intervall = micros();                   // Set intervall time to zero.
      }
    }
  }
  else                                      // Reset values.
  {
    time_hall_antibeat = micros();
    hall_check_rise = true;
  }
  /*
  if (time_hall_intervall + 50000 < micros())               // If the rotation speed is lower 0.25Hz, the value will be set to 2s.
  {
    time_hall_delay = 55000;
  }
  */
  send_value = time_hall_delay/1000;//map(time_hall_intervall, 15000, 55000, 0, 255);
}