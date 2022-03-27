using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS3
{
    internal class Player
    {
        public string choice;
        public int scorehuman = 0;
        public int scorecomputer = 0;
        public string result;
        public string proceed;
        public bool flag = true;
        public bool Proceed()
        {
            //OYUNCUNUN DEVAM ETMEK İSTEYİP İSTEMEDİĞİNİ BELİRLEYECEK FONKSİYON
            repeat:
            Console.WriteLine("Devam etmek istiyor musunuz? (Evet,Hayır)");
            proceed = Console.ReadLine();
            if (proceed.ToLower() == "evet") ;
            else if (proceed.ToLower() == "hayır")
            {
                flag = false;
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız Lütfen tekrar deneyiniz.");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();    
                goto repeat;    
            }
            return flag;

        }

        public void scoreboard()
        {
            //OYUNCU OYUNDAN ÇIKMAK İSTERSE SONUCU EKRANA YAZDIRACAK FONKSİYON
            if (scorecomputer < scorehuman)
            {
                Console.WriteLine("{0}-{1} KAZANDINIZ", scorehuman, scorecomputer);
            }
            else if (scorecomputer > scorehuman)
            {
                Console.WriteLine("{1}-{0} KAYBETTİNİZ", scorehuman, scorecomputer);
            }
            else
            {
                Console.WriteLine("{0}-{1} BERABERE", scorehuman, scorecomputer);
            }
        }
        public void versus(string choice, string Computterchoice)
        {
            // KARŞILAŞMADA KAZANAN VE KAYBEDENİ BELİRLEYECEK FONKSİYON


            switch (choice.ToLower())
            {
                case "makas":
                    if (Computterchoice == "Taş")
                    {
                        result = "Kaybetttiniz";
                        Console.WriteLine("Bilgisyarın seçimi= {0}  {1} ", Computterchoice, result);

                        scorecomputer++;
                    }
                    else if (Computterchoice == "Kağıt")
                    {
                        result = "Kazandınız";
                        Console.WriteLine("Bilgisyarın seçimi= {0}  {1} ", Computterchoice, result);

                        scorehuman++;
                    }
                    else
                    {
                        result = "Berabere";
                        Console.WriteLine("Bilgisyarın seçimi= {0}  {1} ", Computterchoice, result);

                    }



                    break;
                case "kağıt":
                    if (Computterchoice == "Taş")
                    {
                        result = "Kzandınız";
                        Console.WriteLine("Bilgisyarın seçimi= {0}  {1} ", Computterchoice, result);
                        scorehuman++;
                    }
                    else if (Computterchoice == "Kağıt")
                    {
                        result = "Berabere";
                        Console.WriteLine("Bilgisyarın seçimi= {0}  {1} ", Computterchoice, result);


                    }
                    else
                    {
                        result = "Kaybettiniz";
                        Console.WriteLine("Bilgisyarın seçimi= {0}  {1} ", Computterchoice, result);

                        scorecomputer++;
                    }
                    break;
                case "taş":
                    if (Computterchoice == "Taş")
                    {
                        result = "Berabere";
                        Console.WriteLine("Bilgisyarın seçimi= {0}  {1} ", Computterchoice, result);


                    }
                    else if (Computterchoice == "Kağıt")
                    {
                        result = "Kaybettiniz";
                        Console.WriteLine("Bilgisyarın seçimi= {0}  {1} ", Computterchoice, result);

                        scorecomputer++;

                    }
                    else
                    {
                        result = "Kazandınız";
                        Console.WriteLine("Bilgisyarın seçimi= {0}  {1} ", Computterchoice, result);

                        scorehuman++;
                    }
                    break;
                default: Console.WriteLine("Hatalı giriş yaptınız."); break;
            }
        }
    }
}
