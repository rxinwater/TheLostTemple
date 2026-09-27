using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLostTemple
{

    public abstract class Character
    {
        private string _name;

        public Character(string name)
        {
            _name = name;
        }

  
        public virtual void Talk()
        {
            Console.WriteLine(_name + ": Hello, adventurer.");
        }
    }
}
