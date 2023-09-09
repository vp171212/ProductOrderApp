using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrderApp.Model
{
    internal class Order
    {
        private int _id;
        private DateTime _date;
        private List<LineItem> _items;
        public Order(int id, DateTime date, List<LineItem> items)
        {
            _id = id;
            _date = date;
           _items = items;
        }
        public int Id { get { return _id; } }
        public DateTime Date { get { return _date;} }
        public List<LineItem> Items { get {  return _items; } }
        public double CalculateOrderPrice()
        {
            double orderCost = 0;
            foreach (LineItem item in _items)
            {
                orderCost += item.CalculateLineItemCost();
            }
            return orderCost;
        }
    }
}
