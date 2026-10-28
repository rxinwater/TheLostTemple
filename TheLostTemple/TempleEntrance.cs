using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLostTemple
{
    public class TempleEntrance : Room
    {
        public TempleEntrance() : base("Temple Entrance")
        {
        }
        public override void Enter()
        {
            Console.WriteLine();
            Console.WriteLine("=== " + _name + " ===");
            Console.WriteLine("You stand in front of an ancient temple.");
            Console.WriteLine("The massive doors stand open.");
        }
    }
}
