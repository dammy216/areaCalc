using System.Collections.Generic;

namespace areaCalc
{
    public static class AreaCalculator
    {
        public static double CalculateTotalArea(List<BaseArea> areas)
        {
            double totalArea = 0.0;

            foreach (var area in areas)
            {
                totalArea += area.AreaValue();
            }

            return totalArea;
        }
    }
}
