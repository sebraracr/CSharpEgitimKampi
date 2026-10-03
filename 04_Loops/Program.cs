using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Dongüsü

            //int i;

            //for(i=0;i<50;i+=3)
            //{
            //    Console.WriteLine(i);

            //}

            //Console.Write("Lütfen ekrana yazılmasını ıstedıgınız  adedı gırınız: ");
            //int finishValue=int.Parse(Console.ReadLine());
            //for(int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine(i);
            //}   



            #endregion

            #region For Döngüsü ile Karar Yapıları


            //for(int i=0;i<=100;i++)
            //{
            //    if ((i%5==0))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0;
            //for(int i=0;i<=10;i++)
            //{

            //    totalvalue += i;

            //}
            //Console.WriteLine(totalvalue);

            //int totalvalue = 0;
            //for(int i=0;i<20;i++)
            //{
            //    if ((i%2==0))
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);

            //    }
            //}

            //Console.WriteLine("----------------------");
            //Console.WriteLine(totalvalue);

            //int count = 0;
            //for(int i =1; i < 50; i++)
            //{
            //    if ((i % 7 == 0))
            //    {
            //        count++;

            //    }

            //}
            //Console.WriteLine(count);


            //int bacterium = 1;

            //for(int i=1;i<=24;i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + " saat sonra bakteri sayısı: " + bacterium);
            //}
            #endregion

            #region While Döngüsü

            //int i = 1;
            //while(i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while(i <= 10)
            //{

            //    if (i % 3 == 0)
            //    {

            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            // int i = 1;
            // int sum = 0;
            // while (i<=10)
            //{
            //     sum += i;
            //     i++;
            // }

            // Console.WriteLine(sum);



            #endregion

            #region Örnek Sınav Sorusu

            int number, sum;
            Console.Write("Lütfen 3 basamaklı bir sayı giriniz:");
            number = int.Parse(Console.ReadLine());

            int a, b, c;

            a = number / 100;
            b = (number / 10) % 10;
            c = number % 10;

            sum = a + b + c;
            Console.WriteLine(sum);



            #endregion 

            Console.ReadLine();
        }
    }
}
