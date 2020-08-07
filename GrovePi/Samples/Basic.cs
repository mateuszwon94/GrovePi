using System.Device.I2c;

using Iot.Device.GrovePiDevice;

using static System.Console;

namespace GrovePiApplication.Samples {
    class Basic {
        static void Main(string[] args) {
            I2cConnectionSettings i2CConnectionSettings = new I2cConnectionSettings(1, GrovePi.DefaultI2cAddress);
            GrovePi grovePi = new GrovePi(I2cDevice.Create(i2CConnectionSettings));
            WriteLine($"Manufacturer: {grovePi.GrovePiInfo.Manufacturer}");
            WriteLine($"Board: {grovePi.GrovePiInfo.Board}");
            WriteLine($"Firmware version: {grovePi.GrovePiInfo.SoftwareVersion}");
        }
    }
}