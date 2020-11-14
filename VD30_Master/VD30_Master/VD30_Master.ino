/*
 Name:		VD30_Master.ino
 Created:	5/29/2019 10:39:46 AM
 Author:	Thomas von Loh
 Version:	3.0

 contents:
 void PPM_gen()
 void sertup()
 void loop ()
*/



#include <SoftwareSerial.h>
#include <Wire.h>
#include <HX711.h>
#define adress_slave_01 1					// define Slave_01 Adress
#define adress_slave_02 2					// define Slave_02 Adress
#define PPM 2								// define PPM Pin conection

struct data									// struct for Datamannagement 
{
	char data_read;
	String data_write;
	String data_as_string_in;
	String data_as_string_out;
	int data_array[5] = { 0,0,0,0,0 };
};
data d_serial;								// struct for serial data
data d_wire;								// struct for I2C data

int i = 0;
int servotime[8] = { 1200, 1200, 1200, 1200, 1200, 1200, 1200, 1200 };
int startintervall = 0;
unsigned long time = millis();


	//---------------------------------------------------------------- PPM_gen
void PPM_gen(int servoval_01, int servoval_02, int servoval_03)
{
	servotime[0] = map(servoval_01, 0, 180, 700, 1700);					// Set servo 1 data to new valuation
	servotime[1] = map(servoval_02, 0, 180, 700, 1700);					// Set servo 1 data to new valuation
	servotime[2] = map(servoval_03, 0, 180, 700, 1700);					// Set servo 1 data to new valuation
	startintervall = 22500 - (4 * 300) - (5 * 1500) - servotime[0] - servotime[1] - servotime[2];	// calculate start intervall
	delayMicroseconds(startintervall);									
	for (i = 0; i < 7; i++)												// create PPM-Signal with digital HIGH\LOW interval
	{
		digitalWrite(PPM, LOW);
		delayMicroseconds(300);
		digitalWrite(PPM, HIGH);
		delayMicroseconds(servotime[i]);
	}
}
	//---------------------------------------------------------------- setup

void setup() {
	pinMode(PPM, OUTPUT);												// Set PPM (Pin 2) as output
	digitalWrite(PPM, HIGH);											// Set PPM-Signal HIGH

	Serial.begin(115200);												// start COM Port communikation
	Serial.println("------ Hello, im redy for rumble -------");			// salutation
	Serial.println("------- Baudrate Serial: 115200 --------");			// send info Baudrate
	Serial.println("");

	Wire.begin();														// start I2C communication
}

void loop() {
	//---------------------------------------------------------------- Serial Port in
	// --- read
	i = 0;
	d_serial.data_as_string_in = "";									// clear data
	while (Serial.available() > 0)										// check data available
	{
		d_serial.data_read = Serial.read();								// get data as char
		if (d_serial.data_read == ',')									// watch vor marke ',' --> ',' = seperator between Values
		{
			d_serial.data_as_string_in = "";							// clear data			
			i += 1;														// set Index for next arrayelement
		}
		else
		{
			d_serial.data_as_string_in += d_serial.data_read;				// kombine char to string
			d_serial.data_array[i] = d_serial.data_as_string_in.toInt();	// write string into arrayelement
		}
	}
	Serial.flush();														// clear buffer

	//---------------------------------------------------------------- Wire I2C in/out

	// --- read
	i = 0;
	Wire.requestFrom(adress_slave_01, 3);								// get 3 values from Slave_01 
	while (Wire.available() > 0)										// check if data available
	{
		d_wire.data_array[i] = Wire.read();								// write data into array
		i += 1;
		Wire.setTimeout(1000);											// check time delay: breake if it is longer then 1000ms
	}
	
	Wire.requestFrom(adress_slave_02, 1);								// get 1 value from slave_02
	while (Wire.available() > 0)										// check if data available
	{
		d_wire.data_array[3] = Wire.read();								// write data into array
		Wire.setTimeout(1000);											// check time delay: breake if it is longer then 1000ms
	}

	// --- write
	Wire.beginTransmission(adress_slave_01);							// open chanel for communikation with slave_01
	Wire.write(d_serial.data_array[0]);									// send values to slave_01
	Wire.endTransmission();

	//---------------------------------------------------------------- Serial Port out

	// --- write
	
	d_serial.data_as_string_out = "";									// clear data
	for (i = 0; i < 4; i++)												// load data into serial struct and build a single String 
	{
		d_serial.data_as_string_out += d_wire.data_array[i];
		d_serial.data_as_string_out += ",";
	}
	


	if (time + 250 < millis())											// set intervall to send data
	{
		//Serial.print(d_wire.data_array[0]); Serial.print(",");
		//Serial.print(d_wire.data_array[1]); Serial.print(",");
		//Serial.print(d_wire.data_array[2]); Serial.print(",");
		//Serial.println(d_wire.data_array[3]); 

		Serial.println(d_serial.data_as_string_out);					// send data on COM PORT
		/*
		Serial.print("d_serial.data_array 0: "); Serial.println(d_serial.data_array[0]);
		Serial.print("d_serial.data_array 1: "); Serial.println(d_serial.data_array[1]);
		Serial.print("d_serial.data_array 2: "); Serial.println(d_serial.data_array[2]);
		Serial.print("d_serial.data_array 3: "); Serial.println(d_serial.data_array[3]);
		Serial.print("d_wire.data_array 0: "); Serial.println(d_wire.data_array[0]);
		Serial.print("d_wire.data_array 1: "); Serial.println(d_wire.data_array[1]);
		Serial.print("d_wire.data_array 2: "); Serial.println(d_wire.data_array[2]);
		Serial.print("d_wire.data_array 3: "); Serial.println(d_wire.data_array[3]);
		*/
		time = millis();
	}
	//---------------------------------------------------------------- Serial Poert out

	//PPM
	PPM_gen(d_serial.data_array[1], d_serial.data_array[2], d_serial.data_array[3]);	// start funktion PPM_gen for build PPM-Signal
}

