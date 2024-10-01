using System;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");

            //Console.WriteLine("***** Yemek Kateorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kateorileri *****");
            #endregion

            #region Değişkenler

            //String
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Ertan";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, disctrict, city;

            //customerName = "Ertan";
            //customerSurname = "Güçlü";
            //customerPhone = "0535 353 53 535";
            //customerEmail = "deneme@gmail.com";
            //disctrict = "Beyoğlu";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + disctrict + "/" + city);
            //Console.WriteLine("-------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Eray";
            //customerSurname = "Güçlü";
            //customerPhone = "0535 555 55 55";
            //customerEmail = "deneme2@gmail.com";
            //disctrict = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + disctrict + "/" + city);
            //Console.WriteLine("-------------------------------------------------");


            #endregion

            #region Int Değişkenler

            //int tam sayı türündeki değişkenlerdir.
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("----Kola: " + cokePrice + " TL");
            Console.WriteLine("----Limota: " + lemonadePrice + " TL");
            Console.WriteLine("----Kızartma: " + friesPrice + " TL");
            Console.WriteLine("----Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");


            Console.WriteLine();
            int hamburgerCount;
            int pizzaCount;
            int cokeCount;
            int lemonadeCount;
            int friesCount;
            int waterCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;


            hamburgerCount = 3;
            pizzaCount = 0;
            cokeCount = 3;
            lemonadeCount = 0;
            friesCount = 1;
            waterCount = 3;

            totalHamburgerPrice = (hamburgerPrice * hamburgerCount);
            totalCokePrice = (cokePrice * cokeCount);
            totalWaterPrice = (waterPrice * waterCount);
            totalFriesPrice = (friesPrice * friesCount);
            totalPizzaPrice = (pizzaPrice * pizzaCount);
            totalLemonadePrice = (lemonadePrice * lemonadeCount);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;
            Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");
            #endregion


        }
    }
}

//Yazdırma Komutları
