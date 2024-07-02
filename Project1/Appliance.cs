using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1 {
    public abstract class Appliance
    {
        private string _brand;
        public string Brand { get { return _brand; } set { _brand = value; } }

        private string _color;
        public string Color { get { return _color; } set { _color = value; } }

        private string _itemNumber;
        public string ItemNumber { get { return _itemNumber; } set { _itemNumber = value; } }

        private double price;
        public double Price { get { return price; } set { price = value; } }

        private int _quantity;
        public int Quantity { get { return _quantity; } set { _quantity = value; } }

        private int _wattage;
        public int Wattage { get { return _wattage; } set { _wattage = value; } }




        public Appliance(string _itemNumber, string _brand, int _quantity, int _wattage, string _color, double _price)
        {
            ItemNumber = _itemNumber;
            Brand = _brand;
            Quantity = _quantity;
            Wattage = _wattage;
            Color = _color;
            Price = _price;
        }

        public abstract string FormatForFile();

        public abstract string type();




    }
    







}

 


