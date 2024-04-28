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
    }
}
