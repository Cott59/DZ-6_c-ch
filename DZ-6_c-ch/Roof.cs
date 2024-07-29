using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6_c_ch
{
    public class Roof : IPart
    {
        public int BasePoint { get; set; }
        public Roof() { BasePoint = 1500; }
    }
}
