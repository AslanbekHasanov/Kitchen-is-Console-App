using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Oshxona
{
    class DeleteProduct
    {
        public void DeleteTaom(string nomi)
        {
            string path = $"{nomi}.txt";
            bool res = File.Exists(path);
            if(!res)
            {
                Console.WriteLine("Bunday taom yuq");
            }
            if (res)
            {
                File.Delete(path);
                string[] date = File.ReadAllLines("Umumiy.txt");
                for(int i = 0; i < date.Length; i++)
                {
                    if(date[i] == nomi)
                    {
                        date[i] = date[i].Remove(0);
                        date[i + 1] = date[i + 1].Remove(0);
                        date[i + 2] = date[i + 2].Remove(0);
                    }
                }
                File.Delete("Umumiy.txt");
                foreach(var rr in date)
                {
                    File.AppendAllText("Umumiy.txt", rr + "\n");
                }
            }
        }
    }
}
