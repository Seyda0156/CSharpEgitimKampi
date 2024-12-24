using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.75;
            //tomatoPrice = 6.88;

            //Console.WriteLine("*** Elma Birim Fiyatı :" + applePrice + "TL");
            //Console.WriteLine("*** Portakal Birim Fiyatı :" + orangePrice + "TL");
            //Console.WriteLine("*** Çilek Birim Fiyatı :" + strawberryPrice + "TL");
            //Console.WriteLine("*** Patates Birim Fiyatı :" + potatoPrice + "TL");
            //Console.WriteLine("*** Domates Birim Fiyatı :" + tomatoPrice + "TL");

            //double appleGram, orangeGram,strawberryGram,potatoGram,tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice =applePrice * appleGram;
            //double orangeTotalPrice =orangePrice * orangeGram;
            //double strawberryTotalPrice =strawberryPrice * strawberryGram;
            //double potatoTotalPrice =potatoPrice * potatoGram;
            //double tomatoTotalPrice =tomatoPrice * tomatoGram;

            //Console.WriteLine("***** ALINAN ÜRÜNLER *****");
            //Console.WriteLine("1-Elma =" + "Birim Fiyat: " + applePrice + " - Gramaj:" + appleGram + " - Toplam Tutar:" + appleTotalPrice);
            //Console.WriteLine("2-portakal =" + "Birim Fiyat: " + orangePrice + " - Gramaj:" + orangeGram + " - Toplam Tutar:" + orangeTotalPrice);
            //Console.WriteLine("3-çilek =" + "Birim Fiyat: " + strawberryPrice + " - Gramaj:" + strawberryGram + " - Toplam Tutar:" + strawberryTotalPrice);
            //Console.WriteLine("4-patates =" + "Birim Fiyat: " + potatoPrice + " - Gramaj:" + potatoGram + " - Toplam Tutar:" + potatoTotalPrice);
            //Console.WriteLine("5-domates =" + "Birim Fiyat: " + tomatoPrice + " - Gramaj:" + tomatoGram + " - Toplam Tutar:" + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + "TL");
            #endregion

            #region Char Değişkenleri

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Değişkenleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string PassengerName, PassengerSurname, PassengerDistrict, PassengerCity, PassengerAge, PassengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //PassengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //PassengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //PassengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //PassengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //PassengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //PassengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + PassengerIdentityNumber + " - Yolcu Ad Soyad:" + PassengerName + " " + PassengerSurname + " " + PassengerDistrict + "/" + PassengerCity + " " + PassengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz :");
            //shoesCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz :");
            //computerCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz :");
            //chairCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz :");
            //tvCount=int.Parse(Console.ReadLine());

            //int tOtalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar :" + tOtalPrice);


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //Double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. sınavı Giriniz :");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınavı Giriniz :");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınavı Giriniz :");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız :" + result);


            #endregion

            #region Klavyeden Karakter Girişi

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz :");
            //gender  =char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet :" + gender);

            #endregion

            Console.Read();
        }
    }
}
