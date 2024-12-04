using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MainSubjecst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("*****Yemek Kategorisi*****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("*****Yemek Kategorisi*****");
            #endregion"

            #region String Değişkenler

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Şeyda";
            //customerSurname = "Ovacı";
            //customerPhone = "0543 593 78 44";
            //customerEmail = "seydanurovaci@gmail.com";
            //district = "Başakşehir";
            //city = "İstanbul";

            //Console.WriteLine("**** REZERVASYON KARTI ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Müşteri :" + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim :" + customerPhone);
            //Console.WriteLine("Email :" + customerEmail);
            //Console.WriteLine("Adres :" + district + "/" + city); 
            //Console.WriteLine("---------------------------");

            #endregion

            #region Int Değişkenler

            int hamburgerPrice = 300;   
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("*** RESTORAN MENÜ FİYATLARI ***");
            Console.WriteLine();
            Console.WriteLine("----Hamburger Fiyatı :" + hamburgerPrice + "TL");
            Console.WriteLine("----Kola Fiyatı :" + cokePrice + "TL");
            Console.WriteLine("----Su Fiyatı :" + waterPrice + "TL");
            Console.WriteLine("----Kızartma Fiyatı :" + friesPrice + "TL");
            Console.WriteLine("----Pizza Fiyatı :" + pizzaPrice + "TL");
            Console.WriteLine("----Limonata Fiyatı :" + lemonadePrice + "TL");
            Console.WriteLine("*** RESTORAN MENÜ FİYATLARI");


            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int hamburgerTotalPrice;
            int friesTotalPrice;
            int pizzaTotalPrice;
            int lemonadeTotalPrice;
            int waterTotalPrice;
            int cokeTotalPrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            hamburgerTotalPrice = hamburgerPrice * hamburgerCount;
            cokeTotalPrice =cokePrice * cokeCount;
            waterTotalPrice =waterPrice * waterCount;
            friesTotalPrice = friesPrice * friesCount;
            pizzaTotalPrice = pizzaPrice * pizzaCount;
            lemonadeTotalPrice = lemonadePrice * lemonadeCount;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Hamburger Tutarı :" + hamburgerTotalPrice + "TL");
            Console.WriteLine("Kola Tutarı:" + cokeTotalPrice + "TL");
            Console.WriteLine("Su Tutarı:" + waterTotalPrice + "TL");
            Console.WriteLine("Kızartma Tutarı:" + friesTotalPrice + "TL");
            Console.WriteLine("Pizza Tutarı:" + pizzaTotalPrice + "TL");
            Console.WriteLine("Limonata Tutarı:" + lemonadeTotalPrice + "TL");

            Console.WriteLine();

            int totalPrice = cokeTotalPrice + waterTotalPrice + friesTotalPrice + lemonadeTotalPrice + hamburgerTotalPrice + pizzaTotalPrice;

            Console.WriteLine("Toplam Ödenecek Tutar :" + totalPrice + "TL");

            #endregion

            Console.Read();
        }
    }
}
