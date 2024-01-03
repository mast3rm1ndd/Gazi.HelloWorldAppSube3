using System.Runtime.InteropServices;

namespace Gazi.HelloWorldAppSube3
{
    internal class Program
    {
        //static int oyuncusayi = 500;
        static void Main(string[] args)
        {
            //int sayi = 100; // Değer tipi
            //string isim = "Ahmet"; // Referans tipi 


            //byte a;     
            //double d;

            //a = 30;
            //d = 20;

            /* byte a = 30;  -  double d = 20; */

            //Aynı türden değişkenler tek satırda tanımlanıp değer alabilir.

            //byte a = 30 , b;
            //b = 40;

            //byte = a, b;
            //b = 30; a = 40;

            //const int sayi = 10; // const = sabit değişkenlerdir. const = a; tanımından sonraki satırlarda a'ya değer atanamaz.
            //Console.WriteLine(sayi);
            //sayi = 20;
            //Console.WriteLine(sayi);    

            //byte yas;
            //Console.WriteLine(yas); // Hatalı kullanım

            //Değişkenlerden sonraki tanımlar ancak _ ile başlayabilir. byte _yas; gibi.

            //var sayi = 3.25f; 

            //string isim = "Ahmet", soyad = "Mehmet";

            //Console.WriteLine("Merhaba " + isim + " " + soyad);

            //Console.WriteLine("Merhaba {0} {1}" , isim, soyad );

            //Console.WriteLine($"Merhaba {isim} {soyad}"); 

            //Console.WriteLine("İsminizi giriniz:");
            //string isim = Console.ReadLine();

            //Console.WriteLine("Soyadınızı giriniz:");
            //string soyad = Console.ReadLine();

            //Console.WriteLine("Yaşınızı giriniz:");
            //string yas = Console.ReadLine();
            //byte number = Convert.ToByte(yas);

            //byte yas = byte.Parse(Console.ReadLine());

            //Console.WriteLine($"Hoş geldiniz {isim} {soyad}, yaşınız şudur = {yas}");

            //Tür Dönüşümleri (Type Casting)
            //C# programlama dili, tip güvenliği (type safety) sağlayan bir dildir. Örneğin byte bir veriye string bir değer atanamaz.)
            //Ancak atadığımız değeri istediğimiz veri tipine dönüştürerek atama gerçekleştirebilirsiniz.

            //byte sayi = 10;
            //int number = sayi; // Implicit type casting

            //checked
            //{
            //    int sayi = 20;
            //    byte number = (byte)sayi; // Explicit type casting  
            //    Console.WriteLine(number); 
            //}

            //RİSK: Eğer atanmak istenen değer, atanacak veri tipinden büyükse veri kaybı olur.
            //Bunun önüne geçmek için checked blokları kullanılır. Bu blok risk durmunda hat vererek atama yapılmasını önler.

            //string sayi = "25";
            ////byte number = Convert.ToByte(sayi); 
            //int number = int.Parse(sayi);
            //Console.WriteLine(number); 

            //double maas = 5000;
            //maas += 1000; // maas = maas + 1000

            Console.WriteLine("Bir sayı giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Bir sayı giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());

            //int sayi1 = 5, sayi2 2 = 10;
            //int sayi2 = 10;

            string sonuc = sayi1 > sayi2 ? "Sayı 1 büyüktür":
                "Sayı 2 büyük ya da sayılar eşit";

            Console.WriteLine(sonuc);

            Console.ReadKey();

        }
    }
}

//Tam sayı türleri

//Bit: 0-1 
//8 Bit = 1 Byte
//1024 Byte = 1 Kilobyte 
//1024 KB = 1 Megabyte
//1024 MB = 1 Gigabyte
//1024 GB = 1 Terabyte

//sbyte = -128 ile 127 arasında değer alır. işaret alabilen byte değeridir.
//short = 16 bitlik bir değerdir
//ushort = 16 bitlik fakat unsigned (işaretsiz) bir değerdir.
//long = 64 bitlik veri tipi
//ulong = unsigned long 

//Temel reel sayı türleri

//float = 32 bitlik reel değerleri saklamak için kullanılır. float a = 3.12F; 
//double = 64 bitlik reel değerleri saklamak için kullanılır. Sonunda harf kullanma zorunluluğu yoktur. double a = 3.12;
//decimal = 128 bitlik reel değerleri saklamak için kullanılır. Sonunda küçük veya büyük m harfi ile kullanılır. decimal a = 3.12m;
//bool = true veya false değerleri saklamak için kullanılır. bool sonuc = false; 
//char = tek bir karakter saklamak için kullanılır. 16 bitlik alan kaplar. char değişkenine atanan değerler tek tırnak içinde yazılır. char c='A';
//string = metinsel verileri saklamak için kullanılır. değer ataması yapılırken çift tırnak kullanılır. string isim = "Cem Karaca";

//Namespace: İçinde classları bulunduran block yapılarıdır.
//{}: Block (Scope) yapılarıdır.
//Class: İçinde metodları barındıran yapılardır.
//Metod: İş yapan kod bloklarıdır.
//Main metodu: Console uygulamalarının giriş noktasıdır.
//IntelliSense: Kod yazım yardımcısı penceresi.
//IntelliCode: Yapay zeka destekli kod yazım yardımcısı.
//Syntax: Kod yazım kurallarına denir.
//Ctrl+B: Kodu derler.
//Ctrl+K+D: Hiyerarşiyi düzenler. 
//Ctrl+K+C: Toplu yorum 
//Ctrl+U: Yoruma çevirilenleri geri döndürür
//Ctrl+K+S: Kodu sar.
//  /*: Altına yazılanlar yoruma dönüşür
//  */: Yorumu bitirir
//Solution: İçinde projeleri tutan yapılardır.
//Derleme (Compile): C# -> Derleme -> MS-IL -> Runtime (İkinci Derleme) -> Makine Dili
//MS-IL: Microsoft Intermediate Language
//.net: Microsoft tarafından geliştirilmiş bir yazılım geliştirme ortamıdır.(Framework)
//Programlama Dilleri: C#, VB, F#
//Editörler: Visual Studio, VSCode etc.
//Derleyiciler (Compiler) - Runtime
//Kütüphaneler (Namespace)
//Desktop Applications: Masaüstü uygulamaları, Console, Windows Forms App
//Web Based Applications: Web Tabanlı Uygulamalar
//Mobile Apps: Xamarin -> Android ve iOS
//IOT: Internet of Things
//AI
//Game Development: Unity



