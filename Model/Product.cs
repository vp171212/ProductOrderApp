using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrderApp.Model
{
    internal class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private double _discountPercent;
        public Product(int id, string name, double price, double discountPercent)
        {
            _id = id;
            _name = name;
            _price = price;
            _discountPercent = discountPercent;
        }
        public int Id { get { return _id; } }
        public string Name { get { return _name;} }
        public double Price { get { return _price; } }
        public double DiscountPercent { get { return _discountPercent; } }

        public double CalculateDiscountedPrice()
        { return _price - _price * DiscountPercent / 100; }
    }
}
