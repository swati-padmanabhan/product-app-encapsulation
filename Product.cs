using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppDemo.models
{
    internal class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private double _discountPercentage;

        public int GetId() { return _id; }
        public string GetName() { return _name; }
        public double GetPrice() { return _price; }
        public double GetDiscountPercentage() { return _discountPercentage; }

        public void SetId(int id) { _id = id; }
        public void SetName(string name) { _name = name; }
        public void SetPrice(double price) { _price = price; }
        public void SetDiscountPercentage(double discountPercentage) { _discountPercentage = discountPercentage; }


        public double PriceAfterDiscount()
        {
            double discountedAmount = (_discountPercentage / 100) * _price;
            return _price-discountedAmount;

        }

    }
}
