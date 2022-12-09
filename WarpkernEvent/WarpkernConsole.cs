using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WarpkernEvent
{
    internal class WarpkernConsole
    {
          public virtual void OnTemperaturÄnderung(object source, TemperaturÄnderungEventArgs e)
        {
            if (source != null)
            {
                Console.WriteLine("Temperatur ist geändert:\t Alt\t Neu\t Time");
                Console.WriteLine($"==========================:\t {e.AlteTemperatur}\t {e.NeueTemperatur}\t{e.DatumZeit}");
                Thread.Sleep(1000);

            }
        }
        public virtual void OnTemperaturAlarm(object source, TemperaturÄnderungEventArgs e)
        {
            if (source != null)
            {
                if (e.NeueTemperatur > 500)
                {
                    Console.WriteLine("!!--Wahrnung--!!");
                }
            }
        }
    }
}
