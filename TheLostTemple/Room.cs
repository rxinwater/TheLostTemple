using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLostTemple
{
    using System;

    class Room
    {
        private string _name;
        private string _description;

        public Room(string name, string description)
        {
            _name = name;
            _description = description;
        }
        
        public void Enter() /// Displays the room's name and description.
        {
            Console.WriteLine();
            Console.WriteLine("=== " + _name + " ===");
            Console.WriteLine(_description);
        }
    }
}
