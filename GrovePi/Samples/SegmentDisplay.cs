using System;
using System.Collections.Generic;
using System.Device.Gpio;
using System.Device.I2c;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Iot.Device.GrovePiDevice;
using Iot.Device.GrovePiDevice.Models;
using Iot.Device.GrovePiDevice.Sensors;
using Iot.Device.Tm1637;

namespace GrovePiApplication.Samples {
    class SegmentDisplay {
        static void Main(string[] args) {
            // Connected directly to GPIO pins
            Tm1637 tm1637 = new Tm1637(2, 3) {
                Brightness = 7,
                ScreenOn = true,
            };
            tm1637.ClearDisplay();

            // Displays 4 Characters
            Character[] toDisplay = new Character[4] {
                Character.D, Character.SegmentBottom | Character.SegmentBottomLeft | Character.SegmentBottomRight | Character.SegmentTopLeft | Character.SegmentTopRight, Character.F | Character.SegmentTopRight, Character.A
            };
            tm1637.Display(toDisplay);
            Thread.Sleep(5000);
            tm1637.ClearDisplay();
        }
    }
}
