using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLostTemple
{
    using System;

    class Game
    {
        private Player _player;
        private Room _entrance;
        private Room _hallway;
        private Room _treasureRoom;
        private Merchant _merchant;

        public Game()
        {
            _player = new Player();

            _entrance = new Room(
                "Temple Entrance",
                "You stand in front of an ancient temple."
            );

            _hallway = new Room(
                "Temple Hallway",
                "You enter a dark hallway. There are two paths."
            );

            _treasureRoom = new Room(
                "Treasure Room",
                "You enter a large room filled with ancient treasure."
            );

            _merchant = new Merchant("Mysterious Merchant");
        }

        /// <summary>
        /// Starts the game.
        /// </summary>
        public void Start()
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("          THE LOST TEMPLE");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.WriteLine("You are an adventurer searching for");
            Console.WriteLine("the legendary treasure hidden inside");
            Console.WriteLine("an ancient temple.");
            Console.WriteLine();

            Console.WriteLine("Press ENTER to start.");
            Console.ReadLine();

            Play();
        }

        private void Play()
        {
            _entrance.Enter();

            Console.WriteLine();
            Console.WriteLine("1. Enter the temple");
            Console.WriteLine("2. Leave");

            int choice = GetChoice(2);

            if (choice == 1)
            {
                _hallway.Enter();
                ChoosePath();
            }
            else
            {
                Console.WriteLine("You decide to leave the temple.");
            }
        }

        private void ChoosePath()
        {
            Console.WriteLine();
            Console.WriteLine("1. Take the left path");
            Console.WriteLine("2. Take the right path");

            int choice = GetChoice(2);

            if (choice == 1)
            {
                LeftPath();
            }
            else
            {
                RightPath();
            }

            TreasureRoom();
        }

        private void LeftPath()
        {
            Console.WriteLine();
            Console.WriteLine("You walk down the left path.");
            Console.WriteLine("You find an old key on the ground.");

            _player.AddItem("Key");
            _player.ChangeScore(10);

            Console.WriteLine("You picked up the Key.");
            Console.WriteLine("Score +10");
        }

        private void RightPath()
        {
            Console.WriteLine();
            Console.WriteLine("You walk down the right path.");
            Console.WriteLine("A trap suddenly activates!");

            _player.ChangeHealth(-25);

            Console.WriteLine("You lost 25 health.");

            _merchant.Talk();
        }

        private void TreasureRoom()
        {
            _treasureRoom.Enter();

            Console.WriteLine();
            Console.WriteLine("You see a large treasure chest.");
            Console.WriteLine();
            Console.WriteLine("1. Open the chest");
            Console.WriteLine("2. Leave the treasure");

            int choice = GetChoice(2);

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

            ShowEnding();
        }

        private void ShowEnding()
        {
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("             ENDING");
            Console.WriteLine("=================================");

            _player.ShowStatus();
            Console.WriteLine();

            if (_player.GetScore() >= 50)
            {
                Console.WriteLine("You leave the temple with the treasure.");
                Console.WriteLine("You have completed your adventure!");
            }
            else if (_player.GetScore() > 0)
            {
                Console.WriteLine("You leave the temple with some discoveries.");
                Console.WriteLine("The treasure remains hidden.");
            }
            else
            {
                Console.WriteLine("You leave the temple empty-handed.");
                Console.WriteLine("Your adventure ends without treasure.");
            }

            Console.WriteLine();
            Console.WriteLine("Thanks for playing!");
        }

        private int GetChoice(int maxChoice)
        {
            int choice;

            while (true)
            {
                Console.Write("Choice: ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out choice))
                {
                    if (choice >= 1 && choice <= maxChoice)
                    {
                        return choice;
                    }
                }

                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
