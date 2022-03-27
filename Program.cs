using System;

namespace RPS3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Taş Kağıt Makas Oyununa Hoş geldiniz");
            Player player = new Player();
            Computer computer = new Computer();
            do
            {
                Console.WriteLine("Lütfen seçiminizi yapınız (Taş, Kağıt, Makas)");
                player.choice = Console.ReadLine();

                computer.computerchoices();
                player.versus(player.choice, computer.Computerchoice);
                player.Proceed();
                System.Threading.Thread.Sleep(3000);
                Console.Clear();


            }
            while (player.flag);
            player.scoreboard();
            Console.ReadKey();
        }
    }
}
