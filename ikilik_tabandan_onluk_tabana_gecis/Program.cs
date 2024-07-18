using System;

namespace ikilik_tabandan_onluk_tabana_gecis
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ikilik sayinin okunmasi
            string ikilikSayi = Console.ReadLine();

            // uzunlugu belirle
            int n = ikilikSayi.Length;

            // her bir basamagin dizide tutulmasi
            int[] basamaklar = new int[n];

            //onluk karsiligi
            int sayi = 0;

            bool kontrol = true;


            for (int i = 0; i < n; i++)
            {
                if (!(ikilikSayi[i]=='0'|| ikilikSayi[i]=='1'))
                {
                    Console.WriteLine("\aHatali Giris!");
                    kontrol = false;
                    break;
                }

                basamaklar[i] = (int)(ikilikSayi[i] - '0');
            }


            //2lik sistemden 10luk sisteme geçiş
            if (kontrol)
            {
                for (int i = 0; i < n; i++)
                    sayi += (int)Math.Pow(2, n - 1 - i) * basamaklar[i];
                Console.WriteLine("({0}) ikilik sayi={1}",ikilikSayi,sayi);
            }

        }
    }
}
