using System.Windows.Forms;

namespace areaCalc
{
    public static class AreaCalculator
    {
        public static double CalculateTotalArea(ListView listView)
        {
            double totalArea = 0.0;

            foreach (ListViewItem list in listView.Items)
            {
                if (double.TryParse(list.SubItems[1].Text, out double areaValue))
                    totalArea += areaValue;
            }

            return totalArea;
        }
    }
}
