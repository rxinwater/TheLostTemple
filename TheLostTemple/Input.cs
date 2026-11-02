using System;

namespace TheLostTemple
{
    public static class Input
    {
        public static int GetChoice(int maxChoice)
        {
            while (true)
            {
                Console.Write("Choice: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= maxChoice)
                {
                    Console.Clear();
                    return choice;
                }

                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}