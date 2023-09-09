using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrderApp.Model
{
    internal class Customer
    {
        private int _id;
        private string _name;
        private List<Order> _ordersList;
        public Customer() { }
        public Customer(int id, string name, List<Order> orderList)
        {
            _id = id;
            _name = name;
            _ordersList = orderList;
        }
        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public List<Order> OrdersList { get {  return _ordersList; } }
    }
}
