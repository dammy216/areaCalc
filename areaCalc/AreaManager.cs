using System;
using System.Collections.Generic;

namespace areaCalc
{
    public class AreaManager
    {
        private List<BaseArea> _area = new List<BaseArea>();

        public List<BaseArea> Areas { get { return _area; } }

        public void Add(BaseArea area)
        {
            _area.Add(area);
        }

        public string RoundDecimal(double areaValue, int digit)
        {
            if (digit >= 0)
            {
                return Math.Round(areaValue, digit, MidpointRounding.AwayFromZero).ToString("F" + digit);
            }
            else
            {
                return Math.Round(areaValue, 0, MidpointRounding.AwayFromZero).ToString("F" + digit);
            }
        }

        //モデルのリストを表示用リストに変える
        public string[] GetListViewItem(BaseArea area)
        {
            string[] areas = { area.Name, area.AreaValue().ToString() };
            return areas;
        }

        public void Edit(int index, BaseArea area)
        {
            _area[index] = area;
        }

        public BaseArea GetArea(int index)
        {
            return _area[index];
        }
    }
}
