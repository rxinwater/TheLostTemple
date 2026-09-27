using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLostTemple
{
    using System;
    using System.Collections.Generic;

    class Player
    {
        private int _health;
        private int _score;
        private List<string> _inventory;

        public Player()
        {
            _health = 100;
            _score = 0;
            _inventory = new List<string>();
        }

        public void ChangeHealth(int amount)
        {
            _health += amount;

            if (_health < 0)
            {
                _health = 0;
            }
        }

        public void ChangeScore(int amount)
        {
            _score += amount;
        }

        public void AddItem(string item)
        {
            _inventory.Add(item);
        }

        public bool HasItem(string item)
        {
            return _inventory.Contains(item);
        }

        public void ShowStatus()
        {
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Score: " + _score);
        }

        public void ShowInventory()
        {
            Console.WriteLine("Inventory:");

            if (_inventory.Count == 0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                foreach (string item in _inventory)
                {
                    Console.WriteLine("- " + item);
                }
            }
        }

        public int GetScore()
        {
            return _score;
        }
    }
}
