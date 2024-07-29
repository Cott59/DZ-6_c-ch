namespace DZ_6_c_ch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Console.WriteLine("   O   ");
            Console.WriteLine("  /|\\   ");
            Console.WriteLine("  / \\  ");
            Console.Write("Введите количество рабочих в бригаде: ");
            int num = Convert.ToInt32(Console.ReadLine());
            TeamLeader teamLeader = new TeamLeader();
            Teams teams = new Teams(num);
            int RealCounterWorkHouse = 0;
            int DayWork = 1;
            while (RealCounterWorkHouse < house.HousePoint)
            {
                Console.WriteLine($"Рабочий день: {DayWork}");
                DayWork++;
                RealCounterWorkHouse += teams.PowerTeamsToDay;
                if(RealCounterWorkHouse >= house.basement.BasePoint &&
                    RealCounterWorkHouse < house.basement.BasePoint + teams.PowerTeamsToDay)
                {
                    Console.WriteLine("                O  Фундамент построен! ");
                    Console.WriteLine("               /|\\   ");
                    Console.WriteLine("               /'\\  ");
                    
                }
                if (RealCounterWorkHouse >= house.basement.BasePoint+ house.walls.BasePoint && 
                    RealCounterWorkHouse < house.basement.BasePoint + house.walls.BasePoint+ teams.PowerTeamsToDay)
                {
                    Console.WriteLine("                O  Стены построены! ");
                    Console.WriteLine("               /|\\   ");
                    Console.WriteLine("               /'\\  ");
                    
                }
                if (RealCounterWorkHouse >= house.basement.BasePoint + house.walls.BasePoint+house.door.BasePoint &&
                    RealCounterWorkHouse < house.basement.BasePoint + house.walls.BasePoint + house.door.BasePoint + teams.PowerTeamsToDay)
                {
                    Console.WriteLine("                O  Двери поставлены! ");
                    Console.WriteLine("               /|\\   ");
                    Console.WriteLine("               /'\\  ");
                }
                if (RealCounterWorkHouse >= house.basement.BasePoint + house.walls.BasePoint + house.door.BasePoint+house.window.BasePoint &&
                    RealCounterWorkHouse < house.basement.BasePoint + house.walls.BasePoint + house.door.BasePoint + house.window.BasePoint + teams.PowerTeamsToDay)
                {
                    Console.WriteLine("                O  Окна поставлены! ");
                    Console.WriteLine("               /|\\   ");
                    Console.WriteLine("               /'\\  ");
                    
                }
                if (RealCounterWorkHouse >= house.basement.BasePoint + house.walls.BasePoint + house.door.BasePoint + house.window.BasePoint+house.roof.BasePoint &&
                    RealCounterWorkHouse < house.basement.BasePoint + house.walls.BasePoint + house.door.BasePoint + house.window.BasePoint + 
                    house.roof.BasePoint + teams.PowerTeamsToDay)
                {
                    Console.WriteLine("                O  Крыша поставлена! ");
                    Console.WriteLine("               /|\\   ");
                    Console.WriteLine("               /'\\  ");
                    
                }

            }
            Console.WriteLine("");
            Console.WriteLine("                     /^^^^^^^^^\\  ");
            Console.WriteLine("                    /~~~~~~~~~~~\\  ");
            Console.WriteLine("                   /~~~~~~~~~~~~~\\  ");
            Console.WriteLine("    Дом Построен!   |      _    |  "); 
            Console.WriteLine("        O           |_    |_|   |  ");
            Console.WriteLine("       /|\\          | |         |  ");
            Console.WriteLine("       /'\\          |_|_________|  ");
        }
    }
}
