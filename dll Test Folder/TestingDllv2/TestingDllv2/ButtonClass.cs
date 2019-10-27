using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestingDllv2
{
    class ButtonClass : ICommand
    {
        IElectronicDevice device;
        public ButtonClass(IElectronicDevice device)
        {
            this.device = device;
        }
        public void Execute()
        {
            device.On();
            device.VolumeUp();
        }

        public void Undo()
        {
            device.VolumeDown();
            device.Off();
        }
    }
}
