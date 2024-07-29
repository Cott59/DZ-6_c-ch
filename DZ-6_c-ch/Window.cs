using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6_c_ch
{
    public class Window : IPart
    {
        public int BasePoint { get; set; }
        public Window() { BasePoint = 1200; }
    }
}
