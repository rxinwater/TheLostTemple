using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLostTemple
{
    public class TreasureRoom : Room
    {
        public TreasureRoom()
            : base("Treasure Room")
        {
        }


        public override void Enter()
        {
            Console.WriteLine();
            Console.WriteLine("=== " + _name + " ===");
            Console.WriteLine("You enter a large room filled with ancient treasure.");
            Console.WriteLine("A large treasure chest sits in the middle of the room.");
        }
    }
}
