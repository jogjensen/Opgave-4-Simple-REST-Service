using System;

namespace Bike
{
    public class Bikes
    {
        private int _id;
        private string _color;
        private int _price;
        private int _gear;

        public Bikes(int id, string color, int price, int gear)
        {
            _id = id;
            _color = color;
            _price = price;
            _gear = gear;
        }

        public Bikes()
        {
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Color
        {
            get => _color;
            set => _color = value;
        }

        public int Price
        {
            get => _price;
            set => _price = value;
        }

        public int Gear
        {
            get => _gear;
            set => _gear = value;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Color)}: {Color}, {nameof(Price)}: {Price}, {nameof(Gear)}: {Gear}";
        }
    }
}
