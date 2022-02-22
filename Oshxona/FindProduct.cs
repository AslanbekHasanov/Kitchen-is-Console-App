using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Oshxona
{
    class FindProduct
    {
        /// <summary>
        /// Taom qidirish
        /// </summary>
        /// <param name="nomi"></param>
        public void Find(string nomi)
        {
            string path = $"{nomi}.txt";
            bool res = File.Exists(path);
            if (!res)
            {
                Console.WriteLine("\n========== Bunday taom ruyxatda yuq ( bub turadi :))==============\n");
            }
            if (res)
            {
                string[] str = File.ReadAllLines(path);

                Console.WriteLine("\n========== Izlangan taom xarakteristikasi ===========\n");
                Console.WriteLine("      >> Taomni nomi va 1 porsi narxi : " + str[0]);
                Console.WriteLine("      >>Taomni miqdori : " + str[1]);
                Console.WriteLine("      >>Taomni umumiy narxi : " + str[2]);

            }
        }
    }
}
