using System;
using System.Collections.Generic;
using System.Device.Gpio;
using System.Device.I2c;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using GrovePiApplication.Utils;

using Iot.Device.GrovePiDevice;
using Iot.Device.GrovePiDevice.Common;
using Iot.Device.GrovePiDevice.I2CDevices;
using Iot.Device.GrovePiDevice.Models;
using Iot.Device.GrovePiDevice.Sensors;

namespace GrovePiApplication.Samples {
    class LCD2x16 {
        static void Main(string[] args) {
            // GrovePi grovePi = DeviceBuilder.GrovePi();
            RgbLcdDisplay lcd = DeviceBuilder.RgbLcdDisplay(Constants.DisplayTextI2CAddress);
            lcd.SetText("DUPA");
        }
    }
}
