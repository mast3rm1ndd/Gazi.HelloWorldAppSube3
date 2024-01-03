using System.ComponentModel.Design;

namespace Gazi.KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if (false)
            //{
            //    Console.WriteLine("True Değer");
            //}
            //else 
            //{
            //    Console.WriteLine("False Değer");
            //}

            //Console.WriteLine("1.Sayıyı giriniz:");
            //double sayi1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("2.Sayıyı giriniz:");
            //double sayi2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("İşlem seçiniz: +, -, /, *");
            //char islem = char.Parse(Console.ReadLine());
            //string msg = "İşlemin sonucu:";
            //if (islem == '+')
            //{
            //    Console.WriteLine($"{msg} {sayi1 + sayi2}");
            //}
            //else if (islem=='-')
            //{
            //    Console.WriteLine($"{msg} {sayi1 - sayi2}");
            //}
            //else if (islem == '/')
            //{
            //    Console.WriteLine($"{msg} {sayi1 / sayi2}");
            //}
            //else if (islem == '*')
            //{
            //    Console.WriteLine($"{msg} {sayi1 * sayi2}");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı işlem yaptınız.");
            //}

            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("Birinci sayı büyüktür");
            //}


            //else if (sayi2 > sayi1)
            //{
            //    Console.WriteLine("İkinci sayı büyüktür");
            //}

            //else
            //{
            //    Console.WriteLine("Sayılar eşittir");
            //}

            //Console.WriteLine("Dil seçiniz. Select language. TR / EN");
            //string dil = Console.ReadLine().ToUpper();
            //string msg1, msg2, msg3, msg4, msg5;

            //if (dil == "TR")
            //{
            //    msg1 = "1.Sayıyı giriniz:";
            //    msg2 = "2.Sayıyı giriniz:";
            //    msg3 = "İşlem seçiniz:";
            //    msg4 = "İşlemin sonucu:";
            //    msg5 = "Hatalı işlem giriniz:";
            //}
            //else
            //{
            //    msg1 = "Enter the first number:";
            //    msg2 = "Enter the second number:";
            //    msg3 = "Select an operation:";
            //    msg4 = "Result:";
            //    msg5 = "Incorrect Operation Selected:";
            //}

            //Console.WriteLine(msg1);
            //double sayi1 = double.Parse(Console.ReadLine());

            //Console.WriteLine(msg2);
            //double sayi2 = double.Parse(Console.ReadLine());

            //Console.WriteLine(msg3);
            //char islem = char.Parse(Console.ReadLine());

            //if (islem == '+')
            //{
            //Console.WriteLine($"{msg4} {sayi1 + sayi2}");
            //}
            //else if (islem == '-')
            //{
            //Console.WriteLine($"{msg4} {sayi1 - sayi2}");
            //}
            //else if (islem == '/')
            //{
            //Console.WriteLine($"{msg4} {sayi1 / sayi2}");
            //}
            //else if (islem == '*')
            //{
            //Console.WriteLine($"{msg4} {sayi1 * sayi2}");
            //}

            //Console.WriteLine("Hava nasıl?");
            //string cevap = Console.ReadLine().ToLower().Trim();

            //if (cevap == "hava güzel" || cevap == "hava iyi")
            //{
            //    Console.WriteLine("Kaç derece?");
            //    sbyte derece = sbyte.Parse(Console.ReadLine());

            //    if (derece < 15)
            //    {
            //        Console.WriteLine("Soğuk, evde otur");
            //    }
            //    else if (15 <= derece && derece <=35)
            //    {
            //        Console.WriteLine("Hava güzel, dışarı çık");
            //    }
            //    else if (derece > 35 )
            //    {
            //        Console.WriteLine("Çok sıcak, evde otur");
            //    }
            //}


            //else if (cevap == "hava kötü")
            //{
            //Console.WriteLine("Evde otur.");
            //}

            //else
            //{
            //Console.WriteLine("Hatalı giriş yaptınız.");
            //}

            //try
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    byte sayi = byte.Parse(Console.ReadLine());
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Rakamla giriniz.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("0-255 arası bir değer giriniz");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Bilinmeyen hata.");
            //    Console.WriteLine($"Tarih:{DateTime.Now}\n Hata mesajı:{ex.Message}\n Hata Detayı:{ex.StackTrace}");
            //}

            //try
            //{
            //    checked
            //    {
            //        Random rnd = new Random();
            //        byte sayi = (byte)rnd.Next(5, 500);
            //        Console.WriteLine(sayi);
            //    }
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("255'ten büyük bir değer geldi.");
            //}
            //catch(Exception)
            //{
            //    Console.WriteLine("Bir hata oluştu.");
            //}

            Console.WriteLine("Bir sayı giriniz:");
            byte sayi = byte.Parse(Console.ReadLine());
            if (sayi == 1)
            {
                Console.WriteLine("Bir");
            }

            else if (sayi == 2) 
            {
                Console.WriteLine("İki");
            }

            else if (sayi == 3)
            {
                Console.WriteLine("Üç");
            }

            else
            {
                Console.WriteLine("Yanlış giriş yaptınız.");
            }

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Bir");
                    break;

                case 2:
                    Console.WriteLine("İki");
                    break;

                case 3:
                    Console.WriteLine("Üç");
                    break;

                default:
                    Console.WriteLine("Yanlış giriş!");
                    break; 
            }
        }
    }
}

//Exception Handling - try-catch

//ÖDEV1

//Dil Seçiniz / Select Language: TR
//1.Sayıyı giriniz: 10
//2.Sayıyı giriniz: 5
//İşlem seçiniz: +
//İşlemin sonucu: 15

//Dil Seçiniz / Select Language: EN
//Please enter first number: 10
//Please enter second number: 5
//Select operation: +
//Result: 15

//Do it without repeating yourself. DRY 