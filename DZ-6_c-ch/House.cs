using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6_c_ch
{
    public class House 
    {
        public int HousePoint;
        public Basement basement;
        public Walls walls;
        public Door door;
        public Window window;
        public Roof roof;


        public House()
        {
            basement = new Basement();  
            walls = new Walls();
            door = new Door();
            window = new Window();
            roof = new Roof();
            HousePoint = basement.BasePoint;
            HousePoint += walls.BasePoint;
            HousePoint += door.BasePoint;
            HousePoint += window.BasePoint;
            HousePoint += roof.BasePoint;


        }
    }
}
