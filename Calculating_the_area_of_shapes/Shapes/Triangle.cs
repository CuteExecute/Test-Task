using System;
using System.Collections.Generic;
using System.Text;

namespace Calculating_the_area_of_shapes
{
    public class Triangle : IShape
    {
        public decimal first_side   { get; set; }
        public decimal second_side  { get; set; }
        public decimal third_side   { get; set; }

        public bool IsRightTriangle()
        {
            if (first_side  > 0 &&
                second_side > 0 &&
                third_side  > 0)
            {
                decimal[] sides = { first_side, second_side, third_side };
                Array.Sort(sides);

                decimal a = sides[0];
                decimal b = sides[1];
                decimal c = sides[2];

                // Whether a triangle is right-angled (by the Pythagorean theorem) c^2 = a^2 + b^2 where c is the big side
                decimal inaccuracy = (decimal)Math.Abs(c * c - ((a * a) + (b * b)));
                if (inaccuracy < 0.2m)
                    return true;
                else
                    return false;
            }
            else
            {
                throw new Exception("The sides of the triangle were not initialized." +
                                    "Perhaps one or more sides were zero or negative." +
                                    "The value of either side must be greater than zero.");
            }
        }

        public decimal GetArea()
        {
            if (first_side  > 0 &&
                second_side > 0 &&
                third_side  > 0)
            {
                decimal a = first_side;
                decimal b = second_side;
                decimal c = third_side;

                // Use formula
                //      _________________________
                // S = √p (p - a) (p - b) (p - c) where p = 1/2 (a + b + c)
                decimal p = 0.5m * (a + b + c);
                decimal S = (decimal)Math.Sqrt(Convert.ToDouble(p * (p - a) * (p - b) * (p - c)));

                return S;
            }
            else
            {
                throw new Exception("The sides of the triangle were not initialized." +
                                    "Perhaps one or more sides were zero or negative." +
                                    "The value of either side must be greater than zero.");
            }
        }
    }
}
