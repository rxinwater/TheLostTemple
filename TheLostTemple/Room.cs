using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLostTemple
{

    public abstract class Room
    {
        protected string _name;
     

        public Room(string name)
        {
            _name = name;
        }

     
        public abstract void Enter();

    }
}
