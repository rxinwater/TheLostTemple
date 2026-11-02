using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLostTemple
{
    public class Game
    {
        private Player _player;
        private Room _entrance;
        private Room _hallway;
        private Room _leftPath;
        private Room _rightPath;
        private Room _treasureRoom;
        private Merchant _merchant;

        public Game()
        {
            _player = new Player();
            _merchant = new Merchant("Mysterious Merchant");

            _entrance = new TempleEntrance();
            _hallway = new TempleHallway();
            _leftPath = new LeftPathRoom(_player);
            _rightPath = new RightPathRoom(_player, _merchant);
            _treasureRoom = new TreasureRoom(_player);
        }

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

            int choice = Input.GetChoice(2);

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

            int choice = Input.GetChoice(2);

            if (choice == 1)
            {
                _leftPath.Enter();
            }
            else
            {
                _rightPath.Enter();
            }

            _treasureRoom.Enter();
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
    }
}