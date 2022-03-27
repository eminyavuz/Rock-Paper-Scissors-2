using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS3
{
    internal class Computer
    {
        public int choicer()
        {

            int num1 = new Random().Next(0, 4);
            return num1;
        }
        public string Computerchoice;
        public int num2;
        public string computerchoices()
        {
            //CHOİCER FONKSİYONU İLE GELEN RASTGELE SAYIYI  TAŞ, KAĞIT YA DA MAKAS STRİNGİNE ÇEVİRECEK FONKSİYON 
            num2 = choicer();

            if (num2 == 1)
            {
                Computerchoice = "Taş";

            }
            else if (num2 == 2)
            {
                Computerchoice = "Kağıt";
            }
            else if (num2 == 3)
            {
                Computerchoice = "Makas";
            }

            return Computerchoice;
        }

    }
}
