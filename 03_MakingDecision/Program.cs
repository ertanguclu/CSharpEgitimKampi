﻿namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış.");
            //}

            //string capital, country;
            //Console.Write("Lütfen başkenti giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Lütfen ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi");
            //}

            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı.");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata";
            //Console.Write("1. sınav notunu giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("2. sınav notunu giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3. sınav notunu giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ORtalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil.");
            //}

            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}


            #endregion

            #region Mod işlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.Write("1.sayının 2.sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}





            #endregion

            #region Char değişkenler ile karar yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //if (team == 't' | team == 'T')
            //{
            //    Console.WriteLine("Trabzonspor");
            //}

            #endregion

            #region Örnek proje uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi:  ");
            //menuItem = Console.ReadLine();
            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Ana Yemekler---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-PAtlıcan Musakka");
            //    Console.WriteLine("--------------Ana Yemekler---------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Çorbalar ---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-MErcimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("--------------Çorbalar---------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Pizzalar---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("--------------Pizzalar---------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------İçecekler---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("--------------İçecekler---------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Tatlılar---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("--------------Tatlılar---------------");
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.Write("Ocak");
            //        break;
            //    case 2:
            //        Console.Write("Şubat");
            //        break;
            //    case 3:
            //        Console.Write("Mart");
            //        break;
            //    case 4:
            //        Console.Write("Nisan");
            //        break;
            //    case 5:
            //        Console.Write("Mayıs");
            //        break;
            //    case 6:
            //        Console.Write("Haziran");
            //        break;
            //    case 7:
            //        Console.Write("Temmuz");
            //        break;
            //    case 8:
            //        Console.Write("Ağustos");
            //        break;
            //    case 9:
            //        Console.Write("Eylül");
            //        break;
            //    case 10:
            //        Console.Write("Ekim");
            //        break;
            //    case 11:
            //        Console.Write("Kasım");
            //        break;
            //    case 12:
            //        Console.Write("Aralık");
            //        break;
            //    default:
            //        Console.Write("Hatalı Veri Giriş Yaptınız.");
            //        break;
            //}
            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;
            //Console.Write("1.sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("2.sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
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
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı veri girişi yaptınız.");
            //        break;
            //}

            #endregion
        }
    }
}
