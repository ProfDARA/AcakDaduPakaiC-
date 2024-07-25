using System;

namespace DiceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string input = "";

            Console.WriteLine("Selamat datang di aplikasi acak dadu!");

            while (input.ToLower() != "exit")
            {
                Console.WriteLine("tekan enter untuk acak dadu atau ketik 'exit' untuk keluar:");
                input = Console.ReadLine();

                if (input.ToLower() != "exit")
                {
                    int diceRoll = random.Next(1, 7); // generate angka 1-6, lowe nya 1 dan upper 6
                    Console.WriteLine($"You rolled a {diceRoll}");
                }
            }

            Console.WriteLine("terima kasih telah bermain");
        }
    }
