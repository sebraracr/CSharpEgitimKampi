using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.1;
            //Console.WriteLine(number);
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine("******* Fiyat Listesi ********");
            //Console.WriteLine();
            //double applePrice, orangePrice, bananaPrice, tomatoPrice, potatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //bananaPrice = 45;
            //potatoPrice = 9.75;
            //tomatoPrice = 6.88;
            //Console.WriteLine("------ Elma Fiyatı:" + applePrice + " $"); 
            //Console.WriteLine("------ Portakal Fiyatı:" + orangePrice + " $"); 
            //Console.WriteLine("------ Muz Fiyatı:" + bananaPrice + " $"); 
            //Console.WriteLine("------ Domates Fiyatı:" + tomatoPrice + " $"); 
            //Console.WriteLine("------ Patates Fiyatı:" + potatoPrice + " $" );

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram,OrangeGram, BananaGram, TomatoGram, PotatoGram;
            //appleGram = 1.245;
            //OrangeGram = 2.650;
            //BananaGram = 0.750;
            //PotatoGram = 4.859;
            //TomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * OrangeGram;
            //double bananaTotalPrice = bananaPrice * BananaGram;
            //double tomatoTotalPrice = tomatoPrice * TomatoGram;
            //double potatoTotalPrice = potatoPrice * PotatoGram;

            //Console.WriteLine("Alınan Ürün: Elma- " + "Birim Fiyatı: " + applePrice + " - Gramaj: " + appleGram + " Toplam Tutar: " + appleTotalPrice);

            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı: " + orangePrice + " - Gramaj: " + OrangeGram + " Toplam Tutar: " + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün: Muz - " + "Birim Fiyatı: " + bananaPrice + " - Gramaj: " + BananaGram + " Toplam Tutar: " + bananaTotalPrice);

            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyatı: " + tomatoPrice + " - Gramaj: " + TomatoGram + " Toplam Tutar: " + tomatoTotalPrice);

            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı: " + potatoPrice + " - Gramaj: " + PotatoGram + " Toplam Tutar: " + potatoTotalPrice);

            //double totalPrice = appleTotalPrice + orangeTotalPrice + bananaTotalPrice + tomatoTotalPrice + potatoTotalPrice;
            //Console.WriteLine("Toplam Tutar: " + totalPrice);
            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'A';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişleri  String Değişkenler


            //Console.WriteLine("**** CSharp Hava Yolları Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity,passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı:");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi:");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi:");
            //passengerCity= Console.ReadLine();

            //Console.Write("Yaş Bilgisi:");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No:");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Yolcu  Tc Kimlik No:"+ passengerIdentityNumber +
            //    "- Yolcu Ad Soyad:    " + passengerName+" "+passengerSurname + " " + "İlçe: " + passengerDistrict + "  Şehir: " +
            //    passengerCity + "  Yaş: " + passengerAge );



            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, ComputerPrice, ChairPrice, tvPrice;

            //shoesPrice = 1000;
            //ComputerPrice = 20000;
            //ChairPrice = 5000;
            //tvPrice = 12000;


            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen Aldıgınız ayakkabı sayısını giriniz:");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldıgınız bilgisayar sayısını giriniz:");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldıgınız sandalye sayısını giriniz:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldıgınız televizyon sayısını giriniz:");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice = (shoesPrice * shoesCount) + (ComputerPrice * computerCount) + (ChairPrice * chairCount) + (tvPrice * tvCount);
            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");
            #endregion

            #region Klavyeden Ondalıklı Sayı Girişleri ve Dönüşümler

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. Sınav notunuzu giriniz:");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav notunuzu giriniz:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav notunuzu giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalama: " + result);

            #endregion

            #region  Klavyeden Karakter Girişleri  

            //char gender;
            //Console.Write("Lütfen cinsiyet giriniz: (E/K)");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            #endregion

            Console.ReadLine();
        }
    }
}
