using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrudd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //crud-create-read-delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------");

            #region Kategori Ekleme İşlemi



            //Console.Write("Eklemek İstediğiniz Katagori Adı: ");
            //string categoryName = Console.ReadLine();


            //SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;initial Catalog=EgitimkampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarıyl Eklendi. ");
            #endregion

            #region Ürün ekleme işlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;initial Catalog=EgitimkampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command= new SqlCommand (" insert into TblProduct (ProductName, ProductPrice,ProductStatus) values " +
            //    "(@productName, @productPrice, @productStatus)",connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);

            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün eklemesi başarılı! ");

            //Console.ReadLine();


            #endregion

            #region Ürün Listeleme İşleme

            //SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;initial Catalog=EgitimkampiDb;integrated security=true");
            //connection.Open();


            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach(DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");

            //    }
            //    Console.WriteLine();
            //}



            //connection.Close();


            #endregion

            #region Ürün Listeleme İşlemi

            //Console.WriteLine("Silinecek ürün İd: ");
            //int productId = int.Parse(Console.ReadLine());



            //SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;initial Catalog=EgitimkampiDb;integrated security=true");
            //connection.Open();


            //SqlCommand command = new SqlCommand("Delete From TblProduct Where Productid=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi yapıldı! ");








            #endregion


            #region Güncelleme işlemi 


            //Console.WriteLine("Güncellenecek ürün İd: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.WriteLine("Güncellenecek ürün Adı: ");
            //string productName = Console.ReadLine();


            //Console.WriteLine("Güncellenecek ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());



            //SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;initial Catalog=EgitimkampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice where Productid=@productId",connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);

            //command.ExecuteNonQuery();




            //connection.Close();

            //Console.WriteLine("Güncellendi");
            #endregion
            Console.Read();




        }
    }
}
