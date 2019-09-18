using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokerr
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите количество игроков:");
            while (true)

            {
                n = Convert.ToInt32(Console.ReadLine());

                if (n < 2 || n > 10)
                {
                    Console.WriteLine("Введите число игроков от 2 до 10");
                }
                else
                {
                    break;

                }
            }
            CreationCard creationCard = new CreationCard();
            creationCard.mixPack();
            for (int i = 0; i < n * 5; i++)
            {
                if (0 == i % 5)
                {
                    Console.WriteLine(" ");
                }
                Console.WriteLine(creationCard.getPack()[i]);


            }

            Console.ReadKey();
        }
    }
}

