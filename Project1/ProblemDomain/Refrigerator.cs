using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.ProblemDomain
{
    internal class Refrigerator:Appliance
    {
   
        private int _doors;
        public int Doors { get { return _doors; } set { _doors = value; } }

        private int _height;
        public int Height { get { return _height; } set { _height = value; } }

        private int _width;
        public int Width { get { return _width; } set { _width = value; } }

        public Refrigerator(string _itemNumber, string _brand, int _quantity, int _wattage, string _color, double _price, int _doors, int _height, int _width) : base(_itemNumber, _brand,
            _quantity, _wattage, _color, _price)
        {
            Doors = _doors;
            Height = _height;
            Width = _width;
        }

        public override string FormatForFile()
        {

            return ($"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price};{Doors};{Height};{Width}");

        }

        public override string type()
        {
            return "Refrigerator";
        }

        public override string ToString()
        {
            return $"Item Number: {ItemNumber} \nBrand: {Brand} \nQuantity: {Quantity} \nWattage: {Wattage} \nColor: {Color} \nPrice: {Price} \nNumber of Doors: {(Doors == 2 ? "Double Door" : Doors == 3 ? "Three Doors" : Doors == 4 ? "Four Doors" : "")} \nHeight: {Height} \nWidth: {Width}";
        }
    }

    
}

