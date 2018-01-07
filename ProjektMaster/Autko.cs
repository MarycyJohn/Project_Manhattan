using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMaster
{
    public class Autko
    {
        public int id { get; set; }
        public char marka { get; set; }
        public int rok { get; set; }
        public char kolor { get; set; }
        public char Naped_4x4 { get; set; }

        public string FullInfo
        {
            get
            {           //Audi (2004) Czarne
                return $"{ marka } ({ rok }) { kolor }";
            }
        }
    }
}
