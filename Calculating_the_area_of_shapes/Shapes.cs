using System;

namespace Calculating_the_area_of_shapes
{
    public class Shapes
    {
        public decimal GetArea(IShape shape)
        {
            if (shape != null)
                return shape.GetArea();
            else
                throw new Exception($"Method({System.Reflection.MethodInfo.GetCurrentMethod().Name}) parameter is null.");
        }
    }
}
