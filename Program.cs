using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductAppDemo.models;

namespace ProductAppDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product productNo1 = new Product();
            productNo1.SetId(1);
            productNo1.SetName("Sephora");
            productNo1.SetPrice(20000);
            productNo1.SetDiscountPercentage(20);

            Product productNo2 = new Product();
            productNo2.SetId(2);
            productNo2.SetName("Huda Beauty");
            productNo2.SetPrice(10000);
            productNo2.SetDiscountPercentage(10);

            Console.WriteLine("Details of first product is: ");
            Console.WriteLine("Product ID is: " + productNo1.GetId());
            Console.WriteLine("Product NAME is: " + productNo1.GetName());
            Console.WriteLine("Product's ACTUAL PRICE is: " + productNo1.GetPrice());
            Console.WriteLine("Product's DISCOUNTED PRICE is: " + productNo1.PriceAfterDiscount());
            Console.WriteLine("=================================================================");

            Console.WriteLine("Details of second product is: ");
            Console.WriteLine("Product ID is: " + productNo2.GetId());
            Console.WriteLine("Product NAME is: " + productNo2.GetName());
            Console.WriteLine("Product's ACTUAL PRICE is: " + productNo2.GetPrice());
            Console.WriteLine("Product's DISCOUNTED PRICE is: " + productNo2.PriceAfterDiscount());


        }
    }
}
