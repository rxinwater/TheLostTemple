using System;

namespace TheLostTemple
{
    public class RightPathRoom : Room
    {
        private Player _player;
        private Merchant _merchant;

        public RightPathRoom(Player player, Merchant merchant)
            : base("Right Path")
        {
            _player = player;
            _merchant = merchant;
        }

        public override void Enter()
        {
            Console.WriteLine();
            Console.WriteLine("=== " + _name + " ===");
            Console.WriteLine("You walk down the right path.");
            Console.WriteLine("Suddenly, the floor collapses!");
            Console.WriteLine("You fall into a trap.");

            _player.ChangeHealth(-25);

            Console.WriteLine("You lost 25 health.");
            Console.WriteLine();
            Console.WriteLine("You manage to climb out of the trap.");
            Console.WriteLine("At the end of the hallway, you see a merchant.");

            Console.WriteLine();
            Console.WriteLine("1. Talk to the merchant");
            Console.WriteLine("2. Ignore the merchant and leave");

            int choice = Input.GetChoice(2);

            if (choice == 1)
            {
                _merchant.Talk();

                Console.WriteLine();
                Console.WriteLine("The merchant gives you a key.");
                _player.AddItem("Key");

                Console.WriteLine("You received a Key.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You ignore the merchant and continue towards the exit.");
            }
        }
    }
}