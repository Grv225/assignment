using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.ProblemDomain
{
    internal class Dishwasher:Appliance
    {
        private string _feature;
        public string Feature {  get { return _feature; }set { _feature = value; } }
        
        private string _soundRating;
        public string SoundRating { get { return _soundRating; }set { _soundRating = value; } }

        public Dishwasher(string _itemNumber, string _brand, int _quantity, int _wattage, string _color, double _price, string _feature, string _soundRating )
        : base(_itemNumber, _brand, _quantity, _wattage, _color, _price)
        {
            Feature = _feature;
            SoundRating = _soundRating;
        }
        public override string FormatForFile()
        {
            return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price};{Feature};{SoundRating}";
        }

        public override string type()
        {
            return "Dishwasher";   
        }

        public override string ToString()
        {
            return $"Item Number: {ItemNumber}\nBrand: {Brand}\nQuantity: {Quantity}\nWattage: {Wattage}\nColor: {Color}\nPrice: {Price}\nFeature: {Feature}\nSoundRating: {SoundRating}";
        }
    }
}
