using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Oshxona
{
    class SoldProduct
    {
        /// <summary>
        /// Taom sotish.
        /// </summary>
        /// <param name="nomi"></param>
        /// <param name="miqdori"></param>
        public void Sold(string nomi, int miqdori)
        {
            string path1 = "SoldProduct.txt";
            bool res3 = File.Exists(path1);
            if (!res3)
            {

                File.AppendAllText(path1, $"{nomi}\n{miqdori} {miqdori}");
            }
            if (res3)
            {
                string[] date1 = File.ReadAllLines(path1);
                if (date1.Length > 2)
                {
                    for (int i = 0; i < date1.Length; i++)
                    {
                        if (date1[i] == nomi)
                        {
                            int e;
                            int q = int.Parse(date1[i + 1]);
                            int w = int.Parse(date1[i + 2]);
                            e = w / q;
                            q += miqdori;
                            w += miqdori * e;
                            date1[i + 1] = q.ToString();
                            date1[i + 2] = w.ToString();
                        }
                    }
                    File.Delete(path1);
                    foreach (var s in date1)
                    {
                        File.AppendAllText(path1, s + "\n");
                    }
                }
                else
                {
                    File.AppendAllText(path1, $"{nomi}\n{miqdori}\n{miqdori * 10000}");
                }
            }


            string path = $"{nomi}.txt";
            bool res = File.Exists(path);
            if (!res)
            {
                Console.WriteLine("\n   >> Hali bu taom M E N U da shakillantirilmagan ??? (U Z U R A A A:)))");
            }
            if (res)
            {
                string[] date = File.ReadAllLines(path);
                int o;
                int m = int.Parse(date[1]);
                int n = int.Parse(date[2]);
                o = n / m;
                n -= miqdori * o;
                m -= miqdori;
                date[1] = m.ToString();
                date[2] = n.ToString();
                File.Delete(path);
                foreach(var item in date)
                {
                    File.AppendAllText(path, item + "\n");
                }

                string path2 = "Umumiy.txt";
                string[] date2 = File.ReadAllLines(path2);
                for (int i = 0; i < date2.Length; i++)
                {
                    if (date2[i] == nomi)
                    {
                        int e;
                        int q = int.Parse(date2[i + 1]);
                        int w = int.Parse(date2[i + 2]);
                        e = w / q;
                        q -= miqdori;
                        w -= miqdori * e;
                        date2[i + 1] = q.ToString();
                        date2[i + 2] = w.ToString();
                    }
                }
                File.Delete(path2);
                foreach (var s in date2)
                {
                    File.AppendAllText(path2, s + "\n");
                }

            }
        }
    }
}
