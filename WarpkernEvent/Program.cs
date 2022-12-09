using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarpkernEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Warpkern!");
            Warpkern wk = new Warpkern();
            WarpkernConsole wkc = new WarpkernConsole();
            wk.TemperaturÄnderungEvent += wkc.OnTemperaturÄnderung;
            wk.TemperaturAlarmEvent += wkc.OnTemperaturAlarm;
            
            for (int i =0; i< 20; i++)
            {
                wk.ÄndereTemperatur();
            }
            Console.ReadLine();
        }
    }
}
