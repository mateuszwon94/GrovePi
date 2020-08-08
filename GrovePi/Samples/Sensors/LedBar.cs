using System;
using System.Collections.Generic;
using System.Device.I2c;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Iot.Device.GrovePiDevice;
using Iot.Device.GrovePiDevice.Models;
using Iot.Device.GrovePiDevice.Sensors;

namespace GrovePiApplication.Samples.Sensors {
    class LedBar {
        static void Main(string[] args) {
            I2cConnectionSettings i2CConnectionSettings = new I2cConnectionSettings(1, GrovePi.DefaultI2cAddress);
            using GrovePi grovePi = new GrovePi(I2cDevice.Create(i2CConnectionSettings));

            Iot.Device.GrovePiDevice.Sensors.LedBar bar = new Iot.Device.GrovePiDevice.Sensors.LedBar(grovePi, GrovePort.DigitalPin7);

            for (byte i = 1; i <= 10; ++i) {
                bar.SetOneLed(i, true);
                Console.WriteLine($"{i}\t{bar.Value}");
                Thread.Sleep(1000);
            }

            bar.SetAllLeds(0);
        }
    }
}
