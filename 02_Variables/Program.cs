using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            double number;
            number = 4.85;
            Console.WriteLine(number);

            Console.WriteLine("***Fiyat Listesi***");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 29.45;
            strawberryPrice = 34.50;
            potatoPrice = 6.25;
            tomatoPrice = 40.15;
            Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice + " TL");
            Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice + " TL");
            Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice + " TL");
            Console.WriteLine("---- Patates Birim Fiyatı:" + potatoPrice + " TL");
            Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice + " TL");
            
            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.869;
            tomatoGram = 3.485;

            double appleTotalPrice = applePrice * appleGram;
            double orangeTotalPrice = orangePrice * orangeGram;
            double potatoTotalPrice = potatoPrice * potatoGram;
            double strawberryTotalPrice = strawberryPrice * strawberryGram;
            double tomatoTotalPrice = tomatoPrice * tomatoGram;
           
            Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);
            Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            
            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + potatoTotalPrice + strawberryTotalPrice+ tomatoTotalPrice;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + " TL");

            // start tuşunun yanındaki yerden projeleri değiştirebiliriz.
            //double değişkenler, ondalıklı işlemler için kullanılır.
            //ondalıklı sayıda kod tarafında nokta(.) kullanırız. çıktı olarak virgül olur

            #endregion

            #region Char Değişkenler

            char symbol;
            symbol = 'a';

            Console.WriteLine(symbol);

            //karakter türünde değişkenler oluşturmak için
            //gizli şifrelemelerde kullanılabilir.
            //stringi bir bütün olarak değil, tek tek karakter olarak ele alır
            //string karakterler " çift tırnak ile tanımlanır. charlar ' tek tırnak ile tanımlanır

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            Console.WriteLine("****A Hava Yolları Yolcu Bilgisi");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerID;

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("İl Bilgisi: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaşı: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu TC Kimlik No: ");
            passengerID = Console.ReadLine();

            Console.WriteLine();

            Console.Write("-------------------");
            Console.WriteLine("Yolcu TC Kimlik No: " + passengerID + " " + "Yolcu Adı Soyadı: " + passengerName + " " + passengerSurname + " " + "İlçe/İl: " + passengerDistrict + " / " + passengerCity + " " + "Yolcu Yaşı: " + passengerAge);

            //control+f find ve replace kısmıyla x yerine y yazdırabiliriz.
            //değer dışarıdan girilir
            //console.readline ile dışarıdan değer girebiliriz.

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 2000;
            computerPrice = 25000;
            chairPrice = 500;
            tvPrice = 10000;

            int shoesCount, computerCount, chairCount, tvCount;
            Console.Write("Lütfen aldığınız ayakkabı adedini giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız bilgisayar adedini giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız sandalye adedini giriniz: ");
            chairCount = int.Parse(Console.ReadLine());
            Console.Write("Lütfen aldığınız televizyon adedini giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoesCount*shoesPrice + computerCount* computerPrice + chairCount* chairPrice + tvCount* tvPrice;

            Console.WriteLine();
            Console.WriteLine("Toplam ödemek zorunda olduğunuz tutar: " + totalPrice);

            //console üzerinde girilen değerler başlangıçta string olarak kabul ediliyor. bunları sonradan dönüştürebiliriz.
            //console readline metodu veriyi her zaman string kabul eder. eğer int veri gireceksek dönüşüm yapmak zorundayız.
            //parse = dönüşüm metodudur. dönüşüm yapar. 'int.parse()'

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            double exam1, exam2, exam3, result;

            Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine();
            Console.WriteLine("Sınav Ortalamanız: " + result);

            //parse dönüşümü yine kullanılır.

            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen Cinsiyet Seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.Read();








        

        }
    }
}
