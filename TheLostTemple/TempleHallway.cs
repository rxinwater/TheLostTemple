using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLostTemple
{
    public class TempleHallway : Room
    {
        public TempleHallway()
            : base("Temple Hallway")
        {
        }

        public override void Enter()
        {
            Console.WriteLine();
            Console.WriteLine("=== " + _name + " ===");
            Console.WriteLine("You enter a dark hallway.");
            Console.WriteLine("You notice two paths ahead.");
        }
    }
}