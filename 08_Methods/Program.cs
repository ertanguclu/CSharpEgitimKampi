using System;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            //()
            //Geriye değer döndürmeyen metotlar
            //customer --> Listele,ekle,sil,güncelle

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakn Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region geriye değer döndürmeyen string parametreli metotlar

            //void WriteMEthod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMEthod("Mehmet Yıldırım");

            //void customerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}
            //customerCard("Mehmet", "Yıldız");
            //customerCard("Ayşegül", "Kaya");


            #endregion

            #region geriye değer döndürmeyen int parametreli metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);
            #endregion

            #region geriye değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";
            //    return name + " " + surName;

            //}
            //Console.WriteLine(StudentCard());



            #endregion

            #region  geriye değer döndüren string parametreli metotlar

            //string CountryCard(string countryName, string capital, string flagcolor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " Başkent: " + capital + " Bayrak Rengi: " + flagcolor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adnı Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini girniz:");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));



            #endregion

            #region geriye değer döndüren int parametreli metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));

            #endregion

            #region örnek uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + "isimli öğrenci sınavı geçti " + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + "isimli öğrenci sınavı geçemedi " + "Ortalama: " + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Ali", 25, 41, 85));
            //Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));

            #endregion



            Console.Read();
        }
    }
}
