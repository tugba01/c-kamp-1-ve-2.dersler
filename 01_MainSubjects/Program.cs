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
            #region YazdırmaKomutları
            Console.Write("Merhaba Dünya");
            Console.WriteLine("Selam");
            Console.WriteLine("Merhaba Dünya");

            Console.WriteLine("****Yemek Kategorileri****");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine();
            Console.WriteLine("****Yemek Kategorileri****");

            //açıklama satırı(comment) iki // ile yapılır. 
            //Yazdırma Komutları
            //Main metodunun içine yazılır. iki süslü parantezin arasına yazılır {...}
            //metod olması için sol tarafında mor renkli bir küp varsa o metottur.
            //parantez içine metodun çıktısı yazılır
            //ekranın beklemesini sağlamak için Console.Read() metodudur. enter tuşuna basana kadar açık kalır.
            //write yazdığımızda imleci yazının en sağına atar
            //writeline yazdığımızda imleci alta atar.
            //comment out the selected lines seçeneği => seçili satırları 'yorum, açıklama' satırına dönüştürür.
            //tab tuşuna basarak otomatik önerilerini seçebiliriz
            //control+d satırı kopyalayıp aşağıya da yazıyor
            //#region ve #endregion

            #endregion

            #region String Değişkenler

            string name;
            name = "Tuğba";
            Console.Write(name);

            string customerName;
            string customerSurname;
            string customerEmail, district, city;
            string customerPhone;

            customerName = "Tuğba";
            customerSurname = "Pınarbaşı";
            customerPhone = "5050771386";
            customerEmail = "tugbapinarbasi2005@gmail.com";
            district = "Ümraniye";
            city = "İstanbul";

            Console.WriteLine("****Rezervasyon Kartı****");
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("---------------------------------");

            customerName = "Ayşegül";
            customerSurname = "Kaya";
            customerPhone = "123456789";
            customerEmail = "aysegülkaya@gmail.com";
            district = "Beşiktaş";
            city = "İstanbul";

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("---------------------------------");

            //değişkenler, variable 
            //değişkenler, geçici olarak ramde tutulur
            //değişkenler, bellekte tutulup üzerinde işlem yapılır
            //değişkenler, veriler üzerinde işlem yapabiliriz. bir sürü türü vardır.
            //string değişkeni, alfabetik türde veri tutar
            //değişken_türü değişken_adı;
            //eğer altı yeşil çizgili ise => değişken atadın ama onu hiç çağırmadın
            //değişkenler adlandırılırken kulllanılan isimlendirme standartları vardır. camelcase => harfler küçük soonraki kelimenin ilk harfi büyük. araya boşluk bırakılmaz
            //bir satırda aynı türden birden fazla değişken tanımlanabilir = 55.satır
            // " "  => bu ifade boşluk bırakmak için
            //programlamada hiyerarşik bir ataması vardır. customerName değişkenin ataması değiştiğinde çıktısını da değiştirir

            #endregion

            #region Int Değişkenler

            int number = 24;
            Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 3;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            
            Console.WriteLine("----- Hamburger Fiyatı: " + hamburgerPrice + " TL");
            Console.WriteLine("----- Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("----- Kola: " + cokePrice + " TL");
            Console.WriteLine("----- Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("----- Su: " + waterPrice + " TL");
            Console.WriteLine("----- Kızartma: " + friesPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalLemonadePrice;
            int totalFriesPrice;
            int totalPizzaPrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1; 
            pizzaCount = 0;
            lemonadeCount = 5;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokeCount;
            totalWaterPrice = waterCount * waterPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("---------------");
            Console.WriteLine("Hamburger Tutarı:" + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı:" + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı:" + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı:" + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı:" + totalLemonadePrice + " TL");
            Console.WriteLine("Su Tutarı:" + totalWaterPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalCokePrice + +totalPizzaPrice + totalFriesPrice + totalLemonadePrice + totalWaterPrice + totalHamburgerPrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");

            //int => tam sayı türündeki değişkenler

            #endregion

            Console.Read();
        }
    }
}




