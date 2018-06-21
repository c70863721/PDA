using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsCE.Forms;
namespace Tsmt.DAL
{
    class Vibrate
    {
        public static void Play(int microSeconds)
        {
            if (SystemSettings.Platform == WinCEPlatform.PocketPC)
            {
                //Vibrate_PPC.Play();
                System.Threading.Thread.Sleep(microSeconds);
                //Vibrate_PPC.Stop();
            }
            else if (SystemSettings.Platform == WinCEPlatform.Smartphone)
            {
                //Vibrate_SP.Play();
                System.Threading.Thread.Sleep(microSeconds);
                //Vibrate_SP.Stop();
            }
        }
    }
}
