using System.Device.I2c;

using Iot.Device.CharacterLcd;

using static GrovePiApplication.Utils.Utils;

namespace GrovePiApplication.Samples {
    class LCD2x16 {
        static void Main(string[] args) {
            Lcd1602 lcd = new Lcd1602(I2cDevice.Create(new I2cConnectionSettings(1, DefaultLcdAddress))) {
                DisplayOn = true,
                BacklightOn = true,
                BlinkingCursorVisible = true,
                Increment = true,
            };

            lcd.Write("Hello, World!");
        }
    }
}
