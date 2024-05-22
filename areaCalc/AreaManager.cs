using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


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

        // CSV読み込み
        public void LoadFromCsv(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath, Encoding.GetEncoding("shift_jis")))
                {
                    string line;
                    while (sr.Peek() > -1)
                    {
                        line = sr.ReadLine();
                        string[] parts = line.Split(',');
                        string name = parts[0];
                        double.TryParse(parts[1], out double areaValue);

                        BaseArea area = new Concrete(name, areaValue);
                        _area.Add(area);
                    }
                }
            }
        }

        // CSV保存
        public void SaveToCsv(string filePath)
        {

            var lines = _area.Select(a => $"{a.Name},{a.AreaValue()}").ToArray();
            File.WriteAllLines(filePath, lines, Encoding.GetEncoding("shift_jis"));

        }
    }
}
