using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Method
            //Void
            //void CustomerList()
            //        {
            //            Console.WriteLine("Ebrar Acar");
            //            Console.WriteLine("Yusuf Ay");
            //            Console.WriteLine("Emre Demir");

            //        }

            //        CustomerList();



            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();









            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Methodlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Yusuf Acar");



            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);

            //}
            //CustomerCard("Deniz", "Yıldız");
            //CustomerCard("Ayşegül", "Çınar");





            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Methodlar



            //void Sum(int number1,int number2,int number3)
            //{
            //    int result=number1+ number2+number3 ;
            //    Console.WriteLine(result);
            //}
            //Sum(1,2,3);

            #endregion

            #region Geriye Değer Döndüren Methodlar


            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();


            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string soyad = "Kaya";


            //    return name + " " + soyad;  
            //}
            //Console.WriteLine(StudentCard());


            #endregion

            #region Geriye Değer Döndüren Parametreli Methodlar 


            //string CountryCard(string CountryName, string capital,string FlagColor) 

            //    {
            //        string cardInfo = "Ülke: " + CountryName + " - Başkent: " + capital + " - Bayrak Rengi: " + FlagColor;
            //        return cardInfo;



            //    }


            //    string x, y, z;
            //    Console.Write("Ülke adını giriniz: ");
            //    x = Console.ReadLine();

            //    Console.Write("Başkenti Giriniz: ");

            //    y = Console.ReadLine();

            //    Console.Write("Bayrak Rengini Giriniz:");
            //    z = Console.ReadLine();

            //    Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "ankara", "kırmızı - beyaz"));



            #endregion

            #region Geriye Değer Döndüren Int Parametreli Methodlar 

            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(2, 85));
            //Console.WriteLine(Sum(2, 565));








            #endregion


            #region Örnek uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result=(exam1 + exam2+exam3)/3;
            //    if(result>=50)
            //    {
            //        return student + " isimli Öğrenci geçti. " + "Ortalama: " + result;

            //    }

            //    else
            //    {
            //        return student + " isimli Öğrenci kaldı. " + "Ortalama: " + result;
            //    }

            //}

            //Console.WriteLine(ExamResult("Deniz", 25, 65, 23));

            //Console.WriteLine(ExamResult("Ayşe",45,78,98));



            #endregion



            Console.Read();

        }
    }
}
