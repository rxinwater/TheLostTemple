using System;

namespace TheLostTemple
{
    public class LeftPathRoom : Room
    {
        private Player _player;

        public LeftPathRoom(Player player)
            : base("Left Path")
        {
            _player = player;
        }

        public override void Enter()
        {
            Console.WriteLine();
            Console.WriteLine("=== " + _name + " ===");
            Console.WriteLine("You walk down the left path.");
            Console.WriteLine("You find an old key on the ground.");

            _player.AddItem("Key");
            _player.ChangeScore(10);

            Console.WriteLine("You picked up the Key.");
            Console.WriteLine("Score +10");
        }
    }
}