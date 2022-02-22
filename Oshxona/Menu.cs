using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Oshxona
{
    class Menu
    {
        /// <summary>
        /// umumiy ruyhat.
        /// </summary>
        public void MenuUmumiy()
        {
            bool res = File.Exists("Umumiy.txt");
            {
                string[] ob = File.ReadAllLines("Umumiy.txt");
                for (int i = 0; i < ob.Length; i += 3)
                {
                    
                    if(ob[i] == null)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.Write(">> Taom nomi va 1 pors taom narxi ( so'mda) ==> "); Console.WriteLine(ob[i]);
                    }  
                }
            }
            if(!res)
            {
                Console.WriteLine(">> Hali M E N U shakillantirilmagan ??? (U Z U R A A A:)))");
            }
        }
        public void Menu_Sotish(string nomi)
        {
            string path = $"{nomi}.txt";
            bool res = File.Exists(path);
            if (res)
            {
                string[] ob = File.ReadAllLines(path);
                
                    Console.WriteLine("\n===== Kiritilgan taomning keyingi vazyati =====\n");
                    Console.Write("     >> Taom nomi va 1 pors taom narxi ( so'mda) ==> "); Console.WriteLine(ob[0]);
                    Console.Write("     >> Necha pors taom borligi : ==> "); Console.WriteLine(ob[1]);
                    Console.Write("     >> Taomning umumiy narxi ( so'mda) ==>"); Console.WriteLine(ob[2]);

            }
            if (!res)
            {
                Console.WriteLine("");
            }
        }
    }
}
