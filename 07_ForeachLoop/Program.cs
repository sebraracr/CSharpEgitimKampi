using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "milano", "roma", "ankara" };
            //foreach (String x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] number = { 45, 82, 452, 4541, 478, 12, 2 };
            //foreach(int x in number)
            //{
            //    Console.WriteLine(x);

            //}

            //int[] number = { 45, 82, 452, 4541, 478, 12, 2 };
            //foreach (int x in number)
            //{
            //    if (x % 2 == 0) 
            //    {  Console.WriteLine(x);
            //    }


            //}

            //int[] number = { 45, 82, 452, 4541, 478, 12, 2 };
            //int total = 0;
            //foreach (int x in number)
            //{
            //    total += x;


            //}
            //Console.WriteLine(total);



            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6
            //};

            //foreach (int i in numbers)
            //{

            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";

            //foreach(char i in word)
            //{
            //    Console.WriteLine(i);
            //}



            #endregion

            #region Örnek sınav sistemi uygulaması

            //Console.WriteLine("*****  C# Eğitim Kampı Sınav Uygulaması *******");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();



            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Sınıfınızda Kaç Ögrenci Var: ");
            //int studentCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("---------------------------");

            //string[] studentName = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for(int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i+1}.öğrencinin ismini giriniz: ");
            //    studentName[i] = Console.ReadLine();

            //    double totalExamResult = 0;


            //    // Her öğrenci için 3 sınav girişi

            //    for (int j = 0;j<3;j++)
            //    {
            //        Console.Write($"{studentName[i]} adlı öğrencinin {j+1 }. sınav notunu giriniz:");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value; // notları topluyoruz.

            //    }
            //    studentExamAvg[i]= totalExamResult/3;
            //}


            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("---------------------------");
            //    Console.WriteLine($"{studentName[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
            //    if (studentExamAvg[i]>=50)
            //    {
            //        Console.WriteLine($"{studentName[i]} adlı öğrenci dersten geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentName[i]} adlı öğrenci dersten kaldı.");
            //    }
            //    Console.WriteLine("---------------------------");
            //}

            







            #endregion

            Console.ReadLine();
        }
    }
}
