/*
 Name:    VD30_Slave_01_Sketch.ino
 Created: 5/29/2019 10:39:46 AM
 Author:  Thomas von Loh
 Version: 3.0
 Arduino: Nano

 The Slave_01 Module, collect the Load Cell values and set the value of the Brake Servo.
 The communication with the Master Module is work over I2C.
 */



#include <PWMServo.h>
 //#include <VarSpeedServo.h>    //does not work because of using Interrupts
 //#include <Servo.h>            //does not work because of using Interrupts
#include <Wire.h>
#include <HX711.h>
#define adress_slave_01 1
#define servo_pin 9

// overall
int i = 0;
int data_array[5] = { 10,0,0,0,0 };

// Servo Break
PWMServo servo_brake;

// LoadCell
HX711 scale_01;
HX711 scale_02;

long load_cell_01_value = 0;
long load_cell_02_value = 0;

union data_u
{
	struct
	{
		int value_u_01;
		int value_u_02;
		int value_u_03;
	};
	byte u_bytes[6];
};

data_u send_values;


void wire_request_event()
{
	send_values.value_u_01 = data_array[0];
	send_values.value_u_01 = data_array[1];
	send_values.value_u_01 = data_array[2];
	Wire.write(send_values.u_bytes, sizeof(send_values));
}

void wire_receive_event()
{
	while (Wire.available() > 0)
	{
		data_array[0] = Wire.read();
	}
}

void Serial_print()
{
	Serial.println("Data: ");
	Serial.print("data_array[0]: "); Serial.println(data_array[0]);
	Serial.print("data_array[1]: "); Serial.println(data_array[1]);
	Serial.print("data_array[2]: "); Serial.println(data_array[2]);
	Serial.print("data_array[3]: "); Serial.println(data_array[3]);
}

void setup() {
	servo_brake.attach(SERVO_PIN_A);
	data_array[0] = 10;
	data_array[1] = 0;
	data_array[2] = 0;
	data_array[3] = 0;

	Serial.begin(115200);
	Serial.println("115200");

	Wire.begin(adress_slave_01);
	Wire.onRequest(wire_request_event);
	Wire.onReceive(wire_receive_event);
	delay(500);

	Serial.println("Wire redy");

	scale_01.begin(2, 4);
	scale_01.set_scale(441);
	scale_01.tare();
	delay(500);
	Serial.println("first scale is set");
	scale_02.begin(3, 5);
	scale_02.set_scale(441);
	scale_02.tare();
	delay(500);
	Serial.println("second scale is set");

}

void loop() {
  //---------------------------------------------------------------- Break -------
	servo_brake.write(data_array[0]);

  //---------------------------------------------------------------- Load-Cell ---
	//Scale_01
	delay(100);
	data_array[1] = scale_01.get_units(10);
	
	//Scale_02
	delay(100);
	data_array[2] = scale_02.get_units(10);
	
	//---------------------------------------------------------------- Debugging ---
	//Serial_print();                     //only for Debugging
}