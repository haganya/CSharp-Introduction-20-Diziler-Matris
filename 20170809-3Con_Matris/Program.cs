using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170809_3Con_Matris
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir diziyi iki boyutlu yapmak , string[,] kisiler = new string[eleman sayısı, sütun adedi];
            // şeklinde tanımlama yapmamız gerekir.

            //en sonda yaş ortalaması bilgisi versin "girilen kişilerin yaş ortalaması : {0}" verisini versin

            string[,] kisiler = new string[5, 4];
            for (int i = 0; i < (kisiler.Length / 4); i++) //kisiler.Lenght yaparsak 5*4=20 verir. o yüzden kullanılamaz. Ancak (kisiler.Lenght / sutün sayısı) olarak kullanırsak sorun çıkmayacaktır.
            {
                Console.Write((i + 1)+". İsmi giriniz : ");
                kisiler[i, 0] = Console.ReadLine();

                Console.Write((i + 1) + ". Soyismi giriniz : ");
                kisiler[i, 1] = Console.ReadLine();

                Console.Write((i + 1) + ". Cinsiyet giriniz (E/K): ");
                kisiler[i, 2] = Console.ReadLine();

                Console.Write((i + 1) + ". Yas giriniz : ");
                kisiler[i, 3] = Console.ReadLine();
            }

            Console.Write("Aranacak cinsiyet giriniz : ");
            string aranacak = Console.ReadLine();
            int sayac = 0;
            int toplamYas = 0;

            for (int i = 0; i < (kisiler.Length / 4); i++)
            {
                toplamYas += int.Parse(kisiler[i, 3]);

                if (aranacak == kisiler[i,2])
                {
                    sayac++;
                }
            }
            
            double ortalama = toplamYas / 5;

            Console.WriteLine("girilen kişilerin yaş ortalamaları {0}",ortalama);
            Console.Write("{0} cinsiyetinden {1} kişi bulunmaktadır.",aranacak,sayac);
            Console.Read();

        }
    }
}
