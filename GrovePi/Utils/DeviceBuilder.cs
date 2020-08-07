using System;
using System.Collections.Generic;
using System.Device.Gpio;
using System.Device.I2c;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Iot.Device.GrovePiDevice;
using Iot.Device.GrovePiDevice.I2CDevices;
using Iot.Device.GrovePiDevice.Models;
using Iot.Device.GrovePiDevice.Sensors;

namespace GrovePiApplication.Utils {
    public static class DeviceBuilder {
        private static GrovePi device_;

        public static GrovePi GrovePi() {
            return GrovePi(Iot.Device.GrovePiDevice.GrovePi.DefaultI2cAddress);
        }

        public static GrovePi GrovePi(byte address) {
            if (device_ == null) {
                I2cConnectionSettings i2CConnectionSettings = new I2cConnectionSettings(1, address);
                GrovePi grovePi = new GrovePi(I2cDevice.Create(i2CConnectionSettings));
            }
            return device_;
        }

        public static RgbLcdDisplay RgbLcdDisplay(int textAddress) {
            return RgbLcdDisplay(textAddress, null);
        }

        public static RgbLcdDisplay RgbLcdDisplay(int textAddress, int? rgbAddress) {
            I2cDevice rgbDevice = I2cDevice.Create(new I2cConnectionSettings(1, textAddress >> 1));

            I2cDevice textDevice = null;
            if (rgbAddress != null) {
                /* Initialize the I2C bus */
                textDevice = I2cDevice.Create(new I2cConnectionSettings(1, (int)rgbAddress >> 1));
            }

            return new RgbLcdDisplay(rgbDevice, textDevice);
        }
    }
}
