using System;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud --> Create, Read, Update, Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("--------------------------------");
            #region Kategori ekleme işlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection(@"Data Source=ERTAN;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori Başarılı Bir Eklendi!");
            #endregion

            #region Ürün Ekleme işlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection(@"Data Source=ERTAN;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("ürün eklemesi başarılı!");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection(@"Data Source=ERTAN;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * from TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();


            #endregion

            #region Ürün silme işlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection(@"Data Source=ERTAN;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete from TblProduct where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Silme işlemi yapıldı!");

            #endregion

            #region Ürün Güncelleme işlemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection(@"Data Source=ERTAN;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct set ProductName = @productName, ProductPrice = @productPrice where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Güncelleme başarılı!");


            #endregion

            Console.ReadLine();
        }
    }
}
