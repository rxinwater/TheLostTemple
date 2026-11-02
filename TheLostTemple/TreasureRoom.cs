using System;

namespace TheLostTemple
{
    public class TreasureRoom : Room
    {
        private Player _player;

        public TreasureRoom(Player player)
            : base("Treasure Room")
        {
            _player = player;
        }

        public override void Enter()
        {
            Console.WriteLine();
            Console.WriteLine("=== " + _name + " ===");
            Console.WriteLine("You enter a large room filled with ancient treasure.");
            Console.WriteLine("A large treasure chest sits in the middle of the room.");

            Console.WriteLine();
            _player.ShowInventory();

            Console.WriteLine();
            Console.WriteLine("1. Open the chest");
            Console.WriteLine("2. Leave the treasure");

            int choice = Input.GetChoice(2);

            if (choice == 1)
            {
                if (_player.HasItem("Key"))
                {
                    Console.WriteLine();
                    Console.WriteLine("You use the key to open the chest.");
                    Console.WriteLine("You found the legendary treasure!");

                    _player.AddItem("Treasure");
                    _player.ChangeScore(50);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("The chest is locked.");
                    Console.WriteLine("You don't have a key.");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You decide not to take the treasure.");
            }
        }
    }
}