using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region YazdirmaKomutlari
            //Console.WriteLine("Merhaba Dunya");
            //Console.Read();

            //Console.WriteLine("***** Yemek Katagorisi ******");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçeçekler");
            //Console.WriteLine();

            //Console.WriteLine("******************************");

            #endregion

            #region StringDegiskenler
            ////string name;
            ////name = "Deniz";
            ////Console.WriteLine(name);
            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail,district, city;


            //customerName = "Ebrar";
            //customerSurname = "Dunya";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıkoy";
            //city = "istanbul";


            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Müsteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + " " + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------------");

            //customerName = "Derya";
            //customerSurname = "saglam";
            //customerPhone = "+90 500 452 30 20";
            //customerEmail = "deneme3@gmail.com";
            //district = "kartal";
            //city = "istanbul";


            //Console.WriteLine("Müsteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + " " + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------------");

            #endregion
            #region int degiskenler
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menu Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("------Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("------Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("-----Kola: " + cokePrice + "TL");
            Console.WriteLine("------Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("-----Kızartma: " + friesPrice + "TL");
            Console.WriteLine("-----Su: " + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("***** Restorant Menü Fiyati");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int lemonadeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;

            int totalHamburgerPrice;
            int totalCokePrice ;
            int totalWaterPrice ;
            int totalFriesPrice ;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalCokePrice= cokePrice * cokeCount;
            totalWaterPrice= waterPrice * waterCount;
            totalLemonadePrice= lemonadePrice * lemonadeCount;
            totalFriesPrice= friesPrice * friesCount;
            totalPizzaPrice= pizzaPrice * pizzaCount;

            Console.WriteLine("---------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Hamburger Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("Hamburger Tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine("Hamburger Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Hamburger Tutarı: " + totalWaterPrice + "TL");
             
            Console.WriteLine();
            int totalPrice = totalLemonadePrice + totalCokePrice + totalFriesPrice + totalHamburgerPrice + totalPizzaPrice + totalWaterPrice;
            Console.WriteLine(totalPrice);
            
            #endregion

            Console.ReadLine();
            

        }
    }
}
