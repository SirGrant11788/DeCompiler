using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDllv2
{
    class Remote
    {
        public static IElectronicDevice getDevice()
        {
            Television tv = new Television(10, "Television");
            return tv;
        }
    }
}
