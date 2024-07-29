using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6_c_ch
{
    public class Worker: IWorker
    {
        public int WorkPower { get; set; }
        public Worker() { WorkPower = 50; }


    }
}
