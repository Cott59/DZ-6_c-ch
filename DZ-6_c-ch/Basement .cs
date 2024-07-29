using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6_c_ch
{
    public class Basement : IPart
    {
        public int BasePoint { get; set; }

        public Basement()
        {
            BasePoint = 3000;
        }
    }
}
