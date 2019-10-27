using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDllv2
{
    class Television : IElectronicDevice
    {
        public Television(int volume, string device)
        {
            Volume = volume;
            Device = device;
        }
        public int Volume { get; set; }
        public string Device { get; set; }
        public void Off()
        {
            Console.WriteLine("The Device is Off");
        }

        public void On()
        {
            Console.WriteLine("The Device is On");
        }

        public void Type()
        {
            Console.WriteLine($"Device Name:{Device}");
        }

        public void VolumeDown()
        {
            if (Volume != 0)
            {
                Volume--;
            }
            Console.WriteLine($"Volume: {Volume}");
        }

        public void VolumeUp()
        {
            if (Volume != 100)
            {
                Volume++;
            }
            Console.WriteLine($"Volume: {Volume}");
        }
    }
}
