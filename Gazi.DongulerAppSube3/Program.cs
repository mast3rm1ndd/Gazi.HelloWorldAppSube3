using System.ComponentModel.Design;
using System.Diagnostics.Tracing;

namespace Gazi.DongulerAppSube3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("İsim giriniz:");
            //string isim = Console.ReadLine();

            //Console.WriteLine("İsminizin kaç kere tekrarlanmasını istiyorsunuz?");
            //int tekrar = int.Parse(Console.ReadLine());

            //for (int i = 0; i < tekrar; i++)
            //{
            //    Console.WriteLine($"{i + 1} {"-"} {isim}");
            //}

            //Console.WriteLine("Sayı giriniz");
            //int sayi = int.Parse(Console.ReadLine());

            //Console.WriteLine("İkinci sayıyı giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Tek / Çift");
            //string cvp = Console.ReadLine();

            //int sonuc = 0;

            //if (sayi > sayi2)
            //{
            //    int temp = sayi;
            //    sayi = sayi2;
            //    sayi2 = temp;
            //}

            //for (int i = sayi; i < sayi2; i++)
            //{
            //    if (i % 2 == (cvp == "tek" ? 1 : 0))
            //    {
            //        Console.WriteLine(i);
            //        //sonuc = sonuc + i;
            //        sonuc += i;
            //    }

            //    Console.WriteLine(sonuc);
            //}

            //Console.WriteLine("Taban değeri giriniz");
            //int taban = int.Parse(Console.ReadLine());

            //Console.WriteLine("Üs değeri giriniz");
            //int us = int.Parse(Console.ReadLine());

            //int sonuc = 1;

            //for (int i = 0; i < us; i++)
            //{

            //    sonuc = sonuc * taban;
            //}
            //Console.WriteLine(sonuc);

            //Console.WriteLine("Sayı giriniz");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;

            //for (int i = 2; i <= sayi; i++)
            //{
            //    sonuc = sonuc * i;
            //}

            //Console.WriteLine(sonuc);

            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = int.Parse(Console.ReadLine());
            //int sayac = 0;
            //if (sayi > 2 && sayi % 2 == 0)
            //{
            //    Console.WriteLine("Çift sayı girdiniz. Asal değildir");
            //    return;
            //}
            //for (int i = 2; i <= (sayi / 2); i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        sayac++;
            //        break;
            //    }
            //}
            //Console.WriteLine(sayac == 0 ? "Sayı asaldır" : "Asal değildir");

            //for (; ; )
            //{
            //    Console.WriteLine("Kullanıcı adı girin:");
            //    string ad = Console.ReadLine();
            //    Console.WriteLine("Şifre girin:");
            //    string sifre = Console.ReadLine();

            //    if (ad == "admin" && sifre == "admin")
            //    {
            //        Console.WriteLine("Giriş Başarılı");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı giriş. Tekrar deneyin.");
            //    }

            //    int max = int.MinValue;
            //    double toplam = 0;
            //    double sayac = 0;
            //    for (; ; )
            //    {
            //        Console.WriteLine("Sayı giriniz");
            //        int sayi = int.Parse(Console.ReadLine());
            //        toplam += sayi;
            //        sayac++;
            //        double ortalama = toplam / sayac;
            //        if (sayi > max)
            //        {
            //            max = sayi;
            //        }
            //        Console.WriteLine("Devam etmek istiyor musunuz? E/H");
            //        string karar = Console.ReadLine();

            //        if (karar == "E")
            //        {
            //        }
            //        else if (karar == "H")
            //        {
            //            Console.WriteLine($"Girdiğiniz en büyük sayı: {max}\n Sayıların toplamı:{toplam}\n Sayıların aritmetik ortalaması:{ortalama}");
            //            break;
            //        }
            //    }

            //    for (int i = 0; i < 4; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            Console.Write($"{i}, {j}\t");
            //        }
            //        Console.WriteLine();
            //    }

            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            int toplam = i + j;
            //            if (toplam % 2 == 0)
            //            {
            //                Console.Write("*");
            //            }
            //            else
            //            {
            //                Console.Write(" ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }

            //    Console.WriteLine("Enter row count:");
            //    int row = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter column count:");
            //    int column = int.Parse(Console.ReadLine());

            //    for (int i = 0; i < row; i++)
            //    {
            //        for (int j = 0; j < column; j++)
            //        {
            //            Console.Write((i + j) % 2 == 0 ? "*" : " ");
            //        }
            //        Console.WriteLine();
            //    }

            //    for (int a = 1; a <= 9; a++)
            //    {
            //        for (int b = 0; b <= 9; b++)
            //        {
            //            for (int c = 0; c <= 9; c++)
            //            {
            //                for (int d = 1; d <= 9; d++)
            //                {
            //                    if (1000 * a + 100 * b + 10 * c + d == 4 * (1000 * d + 100 * c + 10 * b + a))
            //                    {
            //                        Console.WriteLine($"{a} {b} {c} {d}");
            //                        break;
            //                    }
            //                }
            //            }
            //        }
            //    }

            //    for (int a = 1; a <= 100; a++)
            //    {
            //        for (int b = 1; b <= 100; b++)
            //        {
            //            for (int c = 1; c <= 100; c++)
            //            {
            //                if (a * a + b * b == c * c)
            //                {
            //                    Console.WriteLine($"{a} - {b} - {c}");
            //                }
            //            }
            //        }
            //    }

            //    Console.WriteLine("Enter starting number");
            //    int number1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter ending number");
            //    int number2 = int.Parse(Console.ReadLine());

            //    for (int i = number1; i < number2; i++)
            //    {
            //        int count = 0;
            //        for (int j = 2; j <= (i / 2); j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                count++;
            //                break;
            //            }
            //        }
            //        Console.WriteLine(count == 0 ? $"{i} - Is Prime" : $"{i} - Is Not Prime");
            //    }

            //    int count = 0;
            //    while (count < 5)
            //    {
            //        Console.WriteLine("Gazi");
            //        count++;
            //    }

            //    int max = int.MinValue;
            //    double toplam = 0;
            //    double sayac = 0;
            //    bool sonuc = true;
            //    while (sonuc)
            //    {
            //        Console.WriteLine("Sayı giriniz");
            //        int sayi = int.Parse(Console.ReadLine());
            //        toplam += sayi;
            //        sayac++;
            //        double ortalama = toplam / sayac;
            //        if (sayi > max)
            //        {
            //            max = sayi;
            //        }
            //        Console.WriteLine("Devam etmek istiyor musunuz? E/H");
            //        string karar = Console.ReadLine();

            //        if (karar == "E")
            //        {
            //        }
            //        else if (karar == "H")
            //        {
            //            Console.WriteLine($"Girdiğiniz en büyük sayı: {max}\n Sayıların toplamı:{toplam}\n Sayıların aritmetik ortalaması:{ortalama}");
            //            break;
            //        }

            //        do
            //        {
            //            Console.WriteLine("Gazi");
            //        } while (false);

            //        int max = int.MinValue;
            //        int toplam = 0;
            //        int sayac = 0;
            //        bool sonuc = true;
            //        string cevap;
            //        do
            //        {
            //            Console.WriteLine("Sayı giriniz");
            //            int sayi = int.Parse(Console.ReadLine());
            //            toplam += sayi;
            //            sayac++;
            //            if (sayi > max)
            //            {
            //                max = sayi;
            //            }
            //            Console.WriteLine("Devam etmek istiyor musunuz? E/H");
            //            cevap = Console.ReadLine();

            //        } while (cevap != "H");

            //        try
            //        {
            //            checked
            //            {
            //                Random rnd = new Random();
            //                byte sayi = (byte)rnd.Next(5, 500);
            //                Console.WriteLine(sayi);
            //            }
            //        }
            //        catch (OverflowException)
            //        {
            //            Console.WriteLine("255'ten büyük bir değer geldi.");
            //        }
            //        catch (Exception)
            //        {
            //            Console.WriteLine("Bir hata oluştu.");
            //        }

            //        for (int i = 0; i < 10; i++)
            //        {
            //            Random random = new Random();
            //            int number = random.Next(33, 127);
            //            Console.Write((char)number);
            //        }

            //        Random random = new Random();
            //        int number = random.Next(15, 25);
            //        Random random2 = new Random();
            //        int number2 = random2.Next(15, 45);
            //        for (; ; )
            //        {
            //            Console.WriteLine("Easy Chapter: Guess a number between 15 and 25:");
            //            int sayi = int.Parse(Console.ReadLine());

            //            if (sayi != number)
            //            {
            //                Console.WriteLine("Try again.");
            //            }

            //            else
            //            {
            //                Console.WriteLine("Congrats brat! Now you will guess a number between 15 and 45");
            //                int sayi2 = int.Parse(Console.ReadLine());

            //            }
            //        }


                    int guess;
                    int have = 100;
                    Console.WriteLine("Select a difficulty:\n 1 - Easy \n 2 - Normal \n 3 - Hardcore :*");
                    int diff = int.Parse(Console.ReadLine());
                    int value = 0; int decrease = 0;

                    switch (diff)
                    {
                        case 1:
                            value = 10;
                            decrease = 10;
                            break;
                        case 2:
                            value = 55;
                            decrease = 50;
                            break;
                        case 3:
                            value = 100;
                            decrease = 100;
                            break;
                        default:
                            break;
                    }

                    Random rnd = new Random();
                    int number = rnd.Next(value);
                    do
                    {
                        Console.WriteLine("Guess a number.");
                        guess = int.Parse(Console.ReadLine());

                        if (guess == number)
                        {
                            Console.WriteLine("Congrats brat!");
                        }
                        if (guess < number)
                        {
                            have -= decrease;
                        }
                        else if (guess > number)
                        {
                            have -= decrease;
                        }
                        if (have == 0) {break;}
                    }
                    while (guess != number);
                }
            }
        }

//int guess = 0, yourNumber;
//string hint;


//int secretNumber = (new Random()).Next(1, 10);

//Console.WriteLine("Pick a number between 1 and 10. You'll have 4 turns.");
//do
//{
//    guess++;

//    Console.Write($"Turn #{guess}. Your number:");
//    yourNumber = Convert.ToInt32(Console.ReadLine());

//    if (yourNumber < secretNumber)
//    {
//        hint = $"Your guess: {yourNumber}, which is too low.";
//    }
//    else if (yourNumber > secretNumber)
//    {
//        hint = $"Your guess: {yourNumber}, which is too high.";
//    }
//    else
//    {
//        hint = $"Bingo!";
//    }
//    Console.WriteLine(hint);

//} while (guess < 4 && yourNumber != secretNumber);


//if (yourNumber != secretNumber)
//{
//    Console.WriteLine("You lost :(");
//}




//Hak ve seviye ekle
//Puan sistemi olsun



