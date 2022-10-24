using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Rectangle
    {
        private float _side1;
        private float _side2;

        public float Area { get{ return AreaCalculator(); } }
        public float Perimeter { get{ return PerimeterCalculator(); } }

        public Rectangle(float side1, float side2)
        {
            _side1 = side1;
            _side2 = side2; 
        }

        private float AreaCalculator()
        {
            return _side1 * _side2;
        }

        private float PerimeterCalculator()
        {
            return (_side1 + _side2) * 2f;
        }
    }
}
