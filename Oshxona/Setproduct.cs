using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Oshxona
{
    class Setproduct 
    {
        /// <summary>
        /// Taom qo'shish.
        /// </summary>
        /// <param name="taom_nomi"></param>
        /// <param name="taom_miqdori"></param>
        /// <param name="taom_narxi"></param>
        public void nomi(string taom_nomi, int taom_miqdori,int taom_narxi)
        {
            string path = $"{taom_nomi}.txt";

            bool res = File.Exists(path);
            if (!res)
            {
                File.AppendAllText(path, $"{taom_nomi}\n{taom_miqdori}\n{taom_narxi}");
                File.AppendAllText("Umumiy.txt", $"{taom_nomi}\n{taom_miqdori}\n{taom_narxi}\n");
            }

            if (res)
            {
                string[] str = File.ReadAllLines(path);
                int m = int.Parse(str[1]);
                int n = int.Parse(str[2]);
                m += taom_miqdori;
                n += taom_narxi;
                str[1] = m.ToString();
                str[2] = n.ToString();
                File.Delete(path);
                foreach (var item in str)
                {
                    File.AppendAllText(path, item + "\n");
                }

                string[] date = File.ReadAllLines("Umumiy.txt");
                for (int i = 0; i < date.Length; i++)
                {
                    if (date[i] == taom_nomi)
                    {
                        int mm = int.Parse(str[i + 1]);
                        int nn = int.Parse(str[i + 2]);
                        mm += taom_miqdori;
                        nn += taom_narxi;
                        date[i + 1] = mm.ToString();
                        date[i + 2] = nn.ToString();
                    }
                }
                File.Delete("Umumiy.txt");
                foreach (var t in date)
                {
                    File.AppendAllText("Umumiy.txt", t + "\n");
                }


            }

            
            
        }
    }
}
