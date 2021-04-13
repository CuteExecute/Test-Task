using System;
using System.Collections.Generic;
using System.Text;

namespace Calculating_the_area_of_shapes
{
    public class Circle : IShape
    {
        public decimal radius { get; set; }

        public decimal GetArea()
        {
            if (radius > 0)
            {
                // Use formula S=πr^2
                decimal r  = radius;
                decimal Pi = (decimal)Math.PI;
                decimal S  = Pi * (r * r); 

                return S;
            }
            else
            {
                throw new Exception("The radius of the circle has not been initialized." +
                                    "Possibly the radius was zero or negative." +
                                    "Radius must be greater than zero.");
            }
        }
    }
}
