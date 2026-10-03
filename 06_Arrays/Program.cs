using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            //DeğişkenTürü[] dizininAdı = new DeğişkenTürü[Eleman sayısı];
            //string[] colors = new string[4];
            //colors[0] = "Red";
            //colors[1] = "Blue";
            //colors[2]= "Green";
            //colors[3] = "Yellow";

            //Console.WriteLine(colors[2]);


            //string[] cities = new string[5];

            //cities[0] = "Ankara";
            //cities[1] = "İstanbul";
            //cities[2] = "Mardin";
            //cities[3] = "İzmir";
            //cities[4] = "Antalya";

            //Console.WriteLine(cities[1]);




            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[4] = 55;
            //Console.WriteLine(numbers[6]);



            //string[] cities = { "Prag", "Roma", "Atina" };
            //Console.WriteLine(cities[2]);







            #endregion

            #region Dizideki Tüm Elemanları Listeleme


            //string[] colors = { "red", "blue", "Yellow" };
            //for (int i = 0; i< colors.Length;i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };
            //for(int i=0; i<numbers.Length;i++)
            //{
            //    if(numbers[i] %3==0)

            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbol = { 'A', 'B' };
            //for (int i = 0; i < symbol.Length; i++)
            //{

            //    Console.WriteLine(symbol[i]);


            //}

            //int[] myArray = { 47, 3, 35,  5, 21, 6 };
            //int maxNumber = myArray[0];
            //for (int i = 0;i<myArray.Length;i++)
            //{
            //    if (myArray[i]>maxNumber)
            //    {
            //        maxNumber= myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);




            //string[] persons = { "Ali", "Ahmet", "Ayşe" };
            //Console.WriteLine(persons.Length);  

            //int[] numbers = {  7, 8, 9, 1, 2, 3, 4, 5, 6, 10, 11, };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 7, 8, 9, 1, 2, 3, 4, 5, 6, 10, 11, };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}




            #endregion

            #region Dizi Metotları

            //string[] customers = {"sara", "yusuf", "ayse", "merve" };
            //int index = Array.IndexOf(customers, "yusuf");

            //Console.WriteLine(index);

            //int[] numbers = { 1, 2, 3, 4, 5, 6,3655, 7, 8, };
            //Console.WriteLine("Dizini en büyük Elemanı:  " + numbers.Max() + " Dizinin en kucuk elemanı " + numbers.Min());




            #endregion

            #region Kullanıcıdan Değer aLma


            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{

            //    Console.Write($"Lütfen {i + 1}.Şehri Giriniz:");
            //    cities[i]= Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}







            //int[] numbers = {10, 20, 30,40,50};
            //int sum = 0;
            //for(int i=0;i<numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            //Console.WriteLine("Çift Sayılar");
           

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("------------");
            //Console.WriteLine("Tek sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i] %2== 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion
            Console.ReadLine();
        }
    }
}
