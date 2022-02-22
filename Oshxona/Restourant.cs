using System;
using System.IO;

namespace Oshxona
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n    Assalomu alaukum bizning OSHXONA mizgaa xush kelibsiz!!!\n");
            Console.WriteLine("      Y O Q I M L I    I SH T A H A !!!  :))\n");
            Console.WriteLine("            ======== Q O' L A N M A =======\n");
            Console.WriteLine("             1).  M E N U (yani umumiy taomlar royhati) :");
            Console.WriteLine("             2). Menuda yuq taom buyrutma berish ( yangi taom qoshish) :");
            Console.WriteLine("             3). Buyrutmani bekor qilish ( taomni menudan uchirish) :");
            Console.WriteLine("             4). M E N U dan taom buyrutma qilish ( taom sotilishi) :");
            Console.WriteLine("             5). Buyrutma beriladigan tom bor yuqligini tekshirish ( taom izlash) :");
            Console.WriteLine("\n=== Eslatma: quydagi bandlarni raqamlar orqali tanlang yani 1, 2 va hokazo :) ===");
            
            Console.Write(">>"); int a = int.Parse(Console.ReadLine());
            if( a == 1)
            {
               Console.WriteLine("\n===== umumiy taomlar royhati =====:)\n");
                Menu ob = new Menu();
                ob.MenuUmumiy();
            }
            if(a == 2)
            {
                Console.WriteLine("==== Menuga yangi taom qoshish =====:) ");
                Console.WriteLine("     >> Nechita taom kiritasiz ==>");
                Console.Write("     >>"); int d = int.Parse(Console.ReadLine());
                for (int i = 0; i < d; i++)
                {
                    Console.WriteLine("     >>Taom nomini, miqdori va narxini Enter tugmasini bosib kiriting:)");
                    Setproduct b = new Setproduct();
                    Console.Write("     >> Taom nomi va bir pors taom narxini kiriting : "); string nomi = Console.ReadLine();
                    Console.Write("     >> Necha pors taom borligini kiriting : "); int miqdori = int.Parse(Console.ReadLine());
                    Console.Write("     >> Taomning umumiy narxi : ");  int strukturasi = int.Parse(Console.ReadLine());
                    b.nomi(nomi, miqdori, strukturasi);
                    Console.WriteLine("\n     M E N U GA taom kiritildi :))\n");
                }
                Menu ww = new Menu();
                ww.MenuUmumiy();
            }

            if(a == 3)
            {
                Console.WriteLine("==== O'chirish kerak bo'lgan taom nomini kiriting ====:)");
                DeleteProduct ob = new DeleteProduct();
                Console.Write("     >>Taom nomi va bir pors taom narxini kiriting :"); string s = Console.ReadLine();
                ob.DeleteTaom(s);
                Console.WriteLine("\n      M E N U dan taom uchirildi :)) ");
                Menu ss = new Menu();
                ss.MenuUmumiy();
            }

            if(a == 4)
            {
                Console.WriteLine("Sotiladigan taomning nomi bilan miqdorini Enter tugmasini bosib kiriting kirting:)");
                SoldProduct sol = new SoldProduct();
                Console.Write("     >> Sotiladigan taom nomi va bir pors taom narxini kiriting : "); string nomi = Console.ReadLine();
                Console.Write("     >> Necha pors taom sotilishini kiriting : "); int miqdori = int.Parse(Console.ReadLine());
                sol.Sold(nomi, miqdori);
                Console.WriteLine();
                Menu ssz = new Menu();
                ssz.Menu_Sotish(nomi);
            }
            if(a == 5)
            {
                Console.WriteLine("===== Izlanadigan taomning nomini kiriting :) =====\n");
                FindProduct find = new FindProduct();
                Console.Write("    Taom nomini va 1 pos narxini kiriting :)) >> "); string str = Console.ReadLine();
                Console.WriteLine("\n              ======= M E N U ======== \n");
                Menu ss = new Menu();
                ss.MenuUmumiy();
                find.Find(str);
               
            }
            Console.ReadKey();
        }
    }
}
