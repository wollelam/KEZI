using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.Devices.SerialCommunication;
using Windows.Devices.Enumeration;
using System.Collections.ObjectModel;

namespace KEZI
{
    public class SerialPort
    {
       public String Name = "Test";

        public override string ToString()
        {
            return Name;
        }
    }

    public class SerialPortViewModel
    {
        public SerialPortViewModel()
        {
            this.serialPorts = new ObservableCollection<SerialPort>();

        }

        private ObservableCollection<SerialPort> serialPorts;
        public ObservableCollection<SerialPort> SerialPorts { get { return this.serialPorts; } }


        public async void LoadSerialPorts()
        {
            var devices = await DeviceInformation.FindAllAsync(SerialDevice.GetDeviceSelector());

            foreach (var dev in devices)
            {
                this.serialPorts.Add(new SerialPort { Name = dev.Id });
            }
        }

    }
}
