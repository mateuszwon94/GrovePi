using System;
using System.Device.Gpio;
using System.Device.I2c;
using System.Threading;

using Iot.Device.GrovePiDevice;
using Iot.Device.GrovePiDevice.Models;
using Iot.Device.GrovePiDevice.Sensors;

namespace GrovePiApplication.Samples.Sensors {
    class BlinkingLED {
        static void Main(string[] args) {
            I2cConnectionSettings i2CConnectionSettings = new I2cConnectionSettings(1, GrovePi.DefaultI2cAddress);
            GrovePi grovePi = new GrovePi(I2cDevice.Create(i2CConnectionSettings));

            grovePi.PinMode(GrovePort.DigitalPin5, PinMode.Output);

            Led led = new Led(grovePi, GrovePort.DigitalPin5);

            for (int i = 0; i < 25; ++i) {
                Console.WriteLine($"Blink no {i}");

                led.Value = PinValue.High;
                Thread.Sleep(500);
                led.Value = PinValue.Low;
                Thread.Sleep(500);
            }
        }
    }
}
