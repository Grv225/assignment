using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.ProblemDomain
{
    internal class Vacuum : Appliance
    {
        private int _batteryVoltage;
        public int BatteryVoltage {  get { return _batteryVoltage; } set {  _batteryVoltage = value; } }

        private string _grade;

        public string Grade { get { return _grade; } set { _grade = value; } }


        public Vacuum(string _itemNumber, string _brand, int _quantity, int _wattage, string _color, double _price, string _grade, int _batteryVoltage)
        : base(_itemNumber, _brand, _quantity, _wattage, _color, _price)
        {
            Grade = _grade;
            BatteryVoltage = _batteryVoltage;
        }


        public override string FormatForFile()
        {
            return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price};{Grade};{BatteryVoltage}";
        }

        public override string type()
        {
            return "Vacuum";
        }

        public override string ToString() 
        {
            return $"Item Number: {ItemNumber}\nBrand: {Brand}\nQuantity: {Quantity}\nWattage: {Wattage}\nColor: {Color}\nPrice: {Price}\nGrade: {Grade}\nBattery voltage: {(BatteryVoltage == 18 ? "Low" : "High")}"; 
        }





    }
}
