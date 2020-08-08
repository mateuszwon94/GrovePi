using System.Device.I2c;

using Iot.Device.GrovePiDevice;

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
    }
}
