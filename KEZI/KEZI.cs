using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.Devices.SerialCommunication;
using Windows.Devices.Enumeration;

namespace KEZI
{
    public class KEZI
    {
        public static async void FindDevices()
        {
            var devices = await DeviceInformation.FindAllAsync(SerialDevice.GetDeviceSelector());
            
            foreach (var dev in devices)
            {
                System.Diagnostics.Debug.WriteLine("Id: " + dev.Id );
                System.Diagnostics.Debug.WriteLine("Kind: " + dev.Kind );
                System.Diagnostics.Debug.WriteLine("Name: " + dev.Name);
                System.Diagnostics.Debug.WriteLine("");
            }
        }
    }
}
