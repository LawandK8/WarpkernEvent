using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarpkernEvent
{
    internal class Warpkern
    {
        public string Name { get; set; }
        Random random = new Random();
        int neuTemp;
        int altTemp;
        public event EventHandler<TemperaturÄnderungEventArgs> TemperaturÄnderungEvent;
        public event EventHandler<TemperaturÄnderungEventArgs> TemperaturAlarmEvent;


        public void ÄndereTemperatur()
        {
            neuTemp = random.Next(1, 700); 
            TemperaturÄnderungEvent(this,new TemperaturÄnderungEventArgs { AlteTemperatur = altTemp, NeueTemperatur = neuTemp });
            TemperaturAlarmEvent(this, new TemperaturÄnderungEventArgs { AlteTemperatur=altTemp,NeueTemperatur=neuTemp});
         
            altTemp = neuTemp;
        }
    }
    class TemperaturÄnderungEventArgs : EventArgs
    {
        public int AlteTemperatur { get; set; }
        public int NeueTemperatur { get; set; }
        public DateTime DatumZeit { get; set; }

        public TemperaturÄnderungEventArgs()
        {
            DatumZeit = DateTime.Now;
        }
        
    }
}
