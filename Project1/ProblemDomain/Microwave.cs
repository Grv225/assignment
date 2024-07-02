using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.ProblemDomain
{
    internal class Microwave:Appliance
    {
        private double _capacity;
        public double Capacity { get { return _capacity; } set { _capacity = value; } }

        private string _roomType;
        public string RoomType {  get { return _roomType; } set {_roomType = value; } }


        public Microwave(string _itemNumber, string _brand, int _quantity, int _wattage, string _color, double _price, double _capacity, string _roomType)
       : base(_itemNumber, _brand, _quantity, _wattage, _color, _price)
        {
            Capacity= _capacity;
            RoomType= _roomType;

        }

        public override string FormatForFile()
        {
            return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price};{Capacity};{RoomType}";
        }

        public override string type() 
        {
            return "Microwave";
        }

        public override string ToString()
        {
            return $"Item Number: {ItemNumber}\nBrand: {Brand}\nQuantity: {Quantity}\nWattage: {Wattage}\nColor: {Color}\nPrice: {Price}\nCapacity: {Capacity}\nRoom Type: {RoomType}";
        }



    }


}
