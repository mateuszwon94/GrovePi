namespace Iot.Device.GrovePiDevice.Common {
    internal static class Constants {
        public const byte Unused = 0;
        public const byte GroveVcc = 5;
        public const byte AdcVoltage = 5;

        public const int GroveRgpLcdMaxLength = 16;
        public const int GroveRgpLcdRows = 2;

        public const byte DisplayTextI2CAddress = 0x7C;
        public const byte DisplayRgbI2CAddress = 0xC4;
    }
}
