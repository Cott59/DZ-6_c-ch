using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6_c_ch
{
    public class Teams
    {
        public int PowerTeamsToDay { get; set; }
        public List<IWorker> WorkerList = new List<IWorker>();

        public Teams(int numWorkers)
        {

            for (int i = 0; i < numWorkers; i++)
            {
                Worker worker = new Worker();
                WorkerList.Add(worker);
            }

            PowerTeamsToDay = WorkerList.Sum(a=>a.WorkPower);

        }

       
    }
}
