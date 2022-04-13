using System;

namespace hesapmakinasi
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime born = DateTime.Now;
            Console.WriteLine(born);
            Console.WriteLine("Hoşgeldiniz :)");
            Console.WriteLine("");//boşluk

            while (true)
            {
                try
                {
                    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
                    Console.WriteLine("");
                    Console.WriteLine("Toplama(1)-Çıkarma(2)-Çarpma(3)-Bölme(4)-Çıkış(5)");

                    byte enter = byte.Parse(Console.ReadLine());
                    if (enter == 1)
                    {
                        Console.WriteLine("sayi1 gir:");
                        int sayi1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("sayi2 gir:");
                        int sayi2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Toplama İşlemi sonucun: {sayi1 + sayi2}");
                    }
                    else if (enter == 2)
                    {
                        Console.WriteLine("Sayi1 gir:");
                        int sayi1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("sayi2 gir:");
                        int sayi2 = int.Parse(Console.ReadLine());

                        if (sayi2 > sayi1)
                        {
                            Console.WriteLine($"Çıkarma sonucu: {sayi2 + sayi1}");
                        }
                        else if (sayi1 > sayi2)
                        {
                            Console.WriteLine($"Çıkarma sonucu: {sayi1 - sayi2}");
                        }
                        else
                        {
                            Console.WriteLine("Sayılar birbirine eşit sonuç:0");
                        }
                    }
                    else if (enter == 3)
                    {
                        Console.WriteLine("Sayi1 gir:");
                        int sayi1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Sayi2 gir:");
                        int sayi2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Çarpma işlemi sonucu: {sayi1 * sayi2}");
                    }
                    else if (enter == 5)
                    {
                        break;
                    }
                    else if (enter == 4)
                    {
                        Console.WriteLine("Sayi1 gir:");
                        int sayi1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Sayi2 gir:");
                        int sayi2 = int.Parse(Console.ReadLine());
                        if (sayi1 > sayi2)
                        {
                            Console.WriteLine($"Bölme sonucu: {sayi1 / sayi2}");
                        }
                        else if (sayi2 > sayi1)
                        {
                            Console.WriteLine($"Bölme sonucu:{sayi2 / sayi1 }");
                        }
                        else
                        {
                            Console.WriteLine($"Bölme işlemi sonucu :1");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş");
                        Console.WriteLine("Tekrar deneyiniz");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Yönetici ile görüş");

                }
                finally
                {
                    Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz :) ");
                }
                Console.ReadLine();

            }
        }
    }
}
