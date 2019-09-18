using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokerr
{
    public class CreationCard
    {
        string[] pack = {"туз черви","туз буби","туз крести","туз пики",
                         "король черви", "король буби", "король крести", "король пики",
                         "валет черви", "валет буби", "валет крести", "валет пики",
                         "дама черви", "дама буби", "дама крести", "дама пики",
                         "10 черви", "10 буби", "10 крести", "10 пики",
                         "9 черви", "9 буби", "9 крести", "9 пики",
                         "8 черви", "8 буби", "8 крести", "8 пики",
                         "7 черви", "7 буби", "7 крести", "7 пики",
                         "6 черви", "6 буби", "6 крести", "6 пики",
                         "5 черви", "5 буби", "5 крести", "5 пики",
                         "4 черви", "4 буби", "4 крести", "4 пики",
                         "3 черви", "3 буби", "3 крести", "3 пики",
                         "2 черви", "2 буби", "2 крести", "2 пики", };

        string[] mixedPack = new string[52];

        public void mixPack()
        {
            Random r = new Random();
            for (int i = 0; i < pack.Length - 1; i++)
            {

                while (true)
                {
                    int k = r.Next(0, 52);

                    if (mixedPack[k] == null)
                    {
                        mixedPack[k] = pack[i];
                        break;
                    }

                }


            }
        }
        public string[] getPack()
        {
            return mixedPack;
        }






    }
}









