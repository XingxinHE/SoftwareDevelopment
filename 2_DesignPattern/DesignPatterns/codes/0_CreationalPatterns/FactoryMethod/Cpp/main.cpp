#include <iostream>
#include <string>

using namespace std;

class Sensor
{
	public:
		virtual ~Sensor(){}
		virtual void Connect(string ip, string port) const = 0;

};

class WenglorSensor : public Sensor
{
	public:
		void Connect(string ip, string port) const override
		{
			cout << "Wenglor Sensor Connecting..." << endl;
			cout << "Success! IP is " << ip << " , port is " << port << "." << endl;
		}

};

class RenueSensor : public Sensor
{
	public:
		void Connect(string ip, string port) const override
		{
			cout << "Renue Sensor Connecting..." << endl;
			cout << "Success! IP is " << ip << " , port is " << port << "." << endl;
		}
};





int main()
{

	Sensor* sensor = new WenglorSensor();
	sensor->Connect("192.168.1.1", "2000");
	
	sensor = new RenueSensor();
	sensor->Connect("192.168.1.8", "30001");

	return 0;
}
