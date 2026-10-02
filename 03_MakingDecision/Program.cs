using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifrenizi giriniz:");

            //string password = Console.ReadLine();
            //if (password=="abcd")

            //{

            //    Console.WriteLine("Şifre Dogru");

            //}
            //else
            //{

            //    Console.WriteLine("Şifre Yanlış");
            //}
            //



            //string capital, country;
            //Console.Write("Başkenti Giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz:");
            //country = Console.ReadLine();

            //if(capital =="ankara" && country == "türkiye")
            //{ 
            //    Console.WriteLine("Doğru");
            // }
            //else
            //{
            //    Console.WriteLine("Yanlış");
            //}


            //int number;
            //Console.WriteLine("Sayiyi giriniz:");

            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı 5");

            //}
            //else if (number == 10)
            //{
            //    Console.WriteLine("Sayı 10");
            //}
            //else if (number == 15)
            //{
            //    Console.WriteLine("Sayı dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlıs");

            //}

            //int exam1, exam2, exam3,average;
            //string result="";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması:" + average);

            //if(average>0 && average < 50)
            //{
            //    result = "Kaldınız";
            //}
            //else if (average >= 50 && average < 70)
            //{
            //    result = "Orta";
            //}
            //else if (average >= 70 && average < 90)
            //{
            //    result = "İyi";
            //}
            //else if (average >= 90 && average <= 100)
            //{
            //    result = "Pekiyi";
            //}
            //else

            //{
            //    result = "Hatalı giriş yaptınız";
            //}

            //Console.Write("Sonuc:" + result);


            //string city;
            //Console.Write("Lütfen bir şehir giriniz:");
            //city = Console.ReadLine();

            //if(city == "istanbul" || city == "izmir" || city == "ankara")
            //{
            //    Console.WriteLine("Girdiğiniz şehir Türkiye'de bulunmaktadır.");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz şehir Türkiye'de bulunmamaktadır.");
            //


            //Console.WriteLine("Lütfen bir kullanıcı adı giriniz:");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı adı yanlış");

            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz admin");
            //}




            #endregion


            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //Console.WriteLine("Lütfen 1. sayıyı giriniz:");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1. sayının 2. sayıya bölümünden kalan: " + result);


            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz sayı tektir.");
            //}
            #endregion
            #region Char Değişkenler İle Karar yapıları
            //char team;
            //Console.Write("Lütfen bir takım sembolu giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'F' || team == 'f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if (team == 'G' || team == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if (team == 'B' || team == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz takım sembolu girdiniz.");
            //}
            #endregion
            #region Örnek Proje Uygulaması





            //Console.WriteLine("***** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();

            //Console.WriteLine("------------------------------");
            //Console.WriteLine("1-Ana yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("------------------------------");
            //Console.WriteLine();


            //string menuItem;
            //Console.Write("Lütfen görmek istediğiniz menü öğesini seçiniz: ");
            //menuItem = Console.ReadLine();

            //if (menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Ana Yemekler Menüsü:");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Tavuk Sote");
            //    Console.WriteLine("2- Kuzu Tandır");
            //    Console.WriteLine("3 - Izgara Somon");
            //    Console.WriteLine("4-Karnıyarık");
            //    Console.WriteLine("--------------------------");

            //}
            //if(menuItem=="2") {
            //    Console.WriteLine();
            //    Console.WriteLine("Çorbalar Menüsü:");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Yoğurt Çorbası");
            //    Console.WriteLine("3 - Tarhana Çorbası");
            //    Console.WriteLine("4-Kelle Püresi");
            //    Console.WriteLine("--------------------------");
            //} if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Pizzalar Menüsü:");
            //    Console.WriteLine("1-Akdeniz Pizzasi");
            //    Console.WriteLine("2-Klasik Pizza");
            //    Console.WriteLine("3 - Karışık Pizza");
            //    Console.WriteLine("4-Sucuklu Pizza");
            //    Console.WriteLine("--------------------------");
            //}
            //if(menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("İçecekler Menüsü:");
            //    Console.WriteLine("1-Ayran");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3 - Fanta");
            //    Console.WriteLine("4-Soda");
            //    Console.WriteLine("--------------------------");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Tatlılar Menüsü:");
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3 - Baklava");
            //    Console.WriteLine("4-Künefe");
            //    Console.WriteLine("--------------------------");
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız (1-12): ");
            //  int monthNumber = int.Parse(Console.ReadLine());

            //  switch(monthNumber)
            //  {
            //      case 1:Console.WriteLine("Ocak"); break;
            //      case 2: Console.WriteLine("Şubat"); break;
            //      case 3: Console.WriteLine("Mart"); break;
            //          case 4: Console.WriteLine("Nisan"); break;
            //      case 5: Console.WriteLine("Mayıs"); break;
            //      case 6: Console.WriteLine("Haziran"); break;
            //      case 7: Console.WriteLine("Temmuz"); break;
            //      case 8: Console.WriteLine("Ağustos"); break;
            //      case 9: Console.WriteLine("Eylül"); break;
            //      case 10: Console.WriteLine("Ekim"); break;
            //      case 11: Console.WriteLine("Kasım"); break;
            //      case 12: Console.WriteLine("Aralık"); break;
            //      default: Console.WriteLine("Geçersiz ay numarası girdiniz."); break;
            //  }


            #endregion
            #region Switch case hesap makinesi
            //int number1, number2, result;
            //char symbol;


            //Console.WriteLine("1. Sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. Sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: (+, -, *, /)");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        if (number2 != 0)
            //        {
            //            result = number1 / number2;
            //            Console.WriteLine("Bölüm: " + result);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz.");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz işlem seçtiniz.");
            //        break;
            //}




            #endregion
            Console.ReadLine();
        }
    }
}
