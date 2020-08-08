using System;
using System.Collections.Generic;
using System.Device.I2c;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Iot.Device.GrovePiDevice;
using Iot.Device.GrovePiDevice.Sensors;

namespace GrovePiApplication.Samples.Sensors {
    class UltrasonicProximitySensor {
        static void Main(string[] args) {
            I2cConnectionSettings i2CConnectionSettings = new I2cConnectionSettings(1, GrovePi.DefaultI2cAddress);
            GrovePi grovePi = new GrovePi(I2cDevice.Create(i2CConnectionSettings));

            UltrasonicSensor sensor = new UltrasonicSensor(grovePi, Iot.Device.GrovePiDevice.Models.GrovePort.DigitalPin7);
            while (true) {
                Console.WriteLine(sensor.Value);
                Thread.Sleep(200);
            }
        }
    }
}
