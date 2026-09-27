using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLostTemple
{

    public class Merchant : Character
    {
        public Merchant(string name) : base(name)
        {
        }


        public override void Talk()
        {
            Console.WriteLine("Merchant: I may have something useful for you.");
        }
    }
}
