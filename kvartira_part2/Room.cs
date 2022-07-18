using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kvartira_part2
{
    public class Room
    {
        //Параметры комнаты
        public static double RoomsLength { get; set; }
        public static double RoomsWidth { get; set; }
        public static double RoomsHeight { get; set; }
        //Параметры двери
        public static double DoorsLength { get; set; }
        public static double DoorsHeight { get; set; }
        //Параметры ванной
        public static double BathsRange { get; set; }
        public static double BathsHeight { get; set; }

        public double Rectangle(double a, double b)
        {
            return a * b;
        }
        public double Circle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public static double Door { get; set; }
        public static double Bath { get; set; }
        public static double Floor { get; set; }
        public static double UpperFloor { get; set; }
        public static double Walls { get; set; }
    }
}
