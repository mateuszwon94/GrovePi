using System;
using System.Threading.Tasks;

namespace Iot.Device.GrovePiDevice.Common {
    public static class Delay {
        public static void Milliseconds(int milliseconds) {
            Task.Delay(milliseconds).Wait();
        }

        public static void Microseconds(int microseconds) {
            Task.Delay(new TimeSpan(microseconds * 10)).Wait();
        }
    }
}
