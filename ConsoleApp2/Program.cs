using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OtomatUygulamasi
{
    internal class Program
    {
        static string kullaniciAdi = "csharpinallahi";
        static string sifre = "mervecokiyi";
        static string[] urunler = { "Kola", "Bisküvi", "Çikolata" };
        static int[] fiyatlar = { 7, 3, 2 };

        static void Main(string[] args)
        {
            bool devamEt = true;

            while (devamEt)
            {
                Console.WriteLine("Dünyanın en iyi otomatı olan Mervemat'a hoş geldiniz. Müşteri iseniz 2'ye basın. Yoksa admin misiniz? O zaman 1'e basın");
                int cevap = Convert.ToInt32(Console.ReadLine());

                if (cevap == 1)
                {
                    bool adminGirisBasarili = false;

                    while (!adminGirisBasarili)
                    {
                        Console.WriteLine("Kullanıcı adı: ");
                        string kullaniciAdiGiris = Console.ReadLine();
                        Console.WriteLine("Şifre: ");
                        string sifreGiris = Console.ReadLine();

                        if (kullaniciAdiGiris == kullaniciAdi && sifreGiris == sifre)
                        {
                            Console.WriteLine("EFENDİMİZ İYİ Kİ GELDİNİZ HOŞ GELDİNİZ SAFALAR GETİRDİNİZ.");
                            adminGirisBasarili = true;
                        }
                        else
                        {
                            Console.WriteLine("sen bizim efendimiz değilsin git ötede ağla");

                            Console.WriteLine("Ana menüye mi döncen çakma admin? 1'e bas o zaman, ha ben adminim diye diretiyosan 0'a bas o zaman.");
                            int secim = Convert.ToInt32(Console.ReadLine());

                            if (secim == 1)
                            {
                                break;
                            }
                        }
                    }

                    if (!adminGirisBasarili)
                    {
                        continue;
                    }

                    Console.WriteLine("Oyy efendimiz selamınaleyküm demek siz geldiniz. yeni ürün ekleyecekseniz lütfen 1'e, ürün çıkaracaksanız 2'ye basınız?");
                    int adminSecim = Convert.ToInt32(Console.ReadLine());

                    if (adminSecim == 1)
                    {
                        Console.WriteLine("efendimiz yeni ürünün adı nedir:");
                        string yeniUrun = Console.ReadLine();
                        Console.WriteLine("lütfen fiyatını da girin efendimiz:");
                        int yeniFiyat = Convert.ToInt32(Console.ReadLine());

                        Array.Resize(ref urunler, urunler.Length + 1);
                        urunler[urunler.Length - 1] = yeniUrun;

                        Array.Resize(ref fiyatlar, fiyatlar.Length + 1);
                        fiyatlar[fiyatlar.Length - 1] = yeniFiyat;
                    }
                    else if (adminSecim == 2)
                    {
                        Console.WriteLine("neyi sileceksiniz yüce efendimiz?");
                        string gidicekurun = Console.ReadLine();

                        int urununindexi = -1;
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            if (urunler[i] == gidicekurun)
                            {
                                urununindexi = i;
                                break;
                            }
                        }

                        if (urununindexi != -1)
                        {
                            for (int i = urununindexi; i < urunler.Length - 1; i++)
                            {
                                urunler[i] = urunler[i + 1];
                                fiyatlar[i] = fiyatlar[i + 1];
                            }

                            Array.Resize(ref urunler, urunler.Length - 1);
                            Array.Resize(ref fiyatlar, fiyatlar.Length - 1);
                        }
                        else
                        {
                            Console.WriteLine("ya efendimiz maalesef isteğiniz gerçekleşmedi daha sonra tekrar dener misiniz?");
                        }
                    }
                }
                else if (cevap == 2)
                {
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        Console.WriteLine($"Ürün: {urunler[i]}, Fiyat: {fiyatlar[i]}");
                    }

                    Console.WriteLine("ne yemek istion:");
                    string satinalincakurun = Console.ReadLine();

                    int urununindexi = -1;
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        if (urunler[i] == satinalincakurun)
                        {
                            urununindexi = i;
                            break;
                        }
                    }

                    if (urununindexi != -1)
                    {
                        int fiyat = fiyatlar[urununindexi];
                        Console.WriteLine($"Ürün fiyatı: {fiyat}");

                        Console.WriteLine("parayı ver öyle beleşe mal yok");
                        int odeme = Convert.ToInt32(Console.ReadLine());

                        if (odeme > fiyat)
                        {
                            int paraUstu = odeme - fiyat;
                            Console.WriteLine($"Para üstü: {paraUstu}");
                        }
                        else if (odeme < fiyat)
                        {
                            Console.WriteLine("fakir misin düzgün gir şu parayı");
                        }
                        else
                        {
                            Console.WriteLine("helal lan afiyet olsun");
                        }
                    }
                    else
                    {
                        Console.WriteLine("üf bi haltı da beceremiyosun aç kal ezik");
                    }
                }

                Console.WriteLine("Ana menüye dönmek için 1'e, çıkış yapmak için 0'a basın.");
                int secim2 = Convert.ToInt32(Console.ReadLine());

                if (secim2 == 1)
                {
                    continue;
                }
                else
                {
                    devamEt = false;
                }
            }
        }
    }
}
