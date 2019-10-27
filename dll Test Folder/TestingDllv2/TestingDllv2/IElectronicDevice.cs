using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDllv2
{
    interface IElectronicDevice
    {
        void Type();
        void On();
        void Off();
        void VolumeUp();
        void VolumeDown();
    }
}
