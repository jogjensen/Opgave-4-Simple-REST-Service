using System;
using System.Collections.Generic;
using System.Text;

namespace Bike
{
    public class QueryBike
    {
        #region Instance fields
        private int _gear;
        private string _color;
        #endregion


        #region Constructors
        public QueryBike(int gear, string color)
        {
            _gear = gear;
            _color = color;
        }

        public QueryBike()
        {

        }
        #endregion


        #region Properties
        public int Gear
        {
            get => _gear;
            set => _gear = value;
        }

        public string Color
        {
            get => _color;
            set => _color = value;
        }
        #endregion


        #region Methods

        public override string ToString()
        {
            return $"{nameof(_gear)}: {_gear}, {nameof(_color)}: {_color}";
        }

        #endregion

    }


}
