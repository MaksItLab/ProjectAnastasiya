using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_21
{
    //IComparable
    //IComparer
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;

            bool result = a > b;


            Building building1 = new Building() { CountOfFlours = 5, Height = 13, Width = 0};
            Building building2 = new Building() { CountOfFlours = -5, Height = 13, Width = -66 };
            Building building3 = new Building() { CountOfFlours = 8, Height = 13, Width = 654 };
            Building building4 = new Building() { CountOfFlours = 9, Height = 13, Width = 488 };
            Building building5 = new Building() { CountOfFlours = 2, Height = 13, Width = 6 };
            Building building6 = new Building() { CountOfFlours = 1, Height = 13, Width = 330 };
            Building building7 = new Building() { CountOfFlours = -10, Height = 13, Width = -1 };
            Building building8 = new Building() { CountOfFlours = 3, Height = 13, Width = 3678 };
            Building building9 = new Building() { CountOfFlours = 6, Height = 13, Width = 22 };

            List<Building> list = new List<Building>{building1,  building2, building3, building4, building5, building6, building7, building8};
            var compare = new BuildingHeightComparer();
            list.Sort(compare);

            //Console.WriteLine(building1.CompareTo(building2));

        }
    }

    public class Building : IComparable<Building>
    {
        public int CountOfFlours { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public int CompareTo(Building building)
        {
            return CountOfFlours.CompareTo(building.CountOfFlours);
        }
    }

    public class BuildingHeightComparer : IComparer<Building>
    {
        public int Compare(Building build1, Building build2) // -1,0,1
        {
            if (build1 == null && build2 == null) return 0;
            if (build1 == null) return -1;
            if (build2 == null) return 1;

            return build1.Height.CompareTo(build2.Height);
        }
    }

    public class BuildingWidthComparer : IComparer<Building>
    {
        public int Compare(Building build1, Building build2) // -1,0,1
        {
            if (build1 == null && build2 == null) return 0;
            if (build1 == null) return -1;
            if (build2 == null) return 1;

            return build1.Width.CompareTo(build2.Width);
        }
    }


}
