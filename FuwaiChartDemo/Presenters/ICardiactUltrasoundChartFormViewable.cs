using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuwaiChartDemo
{
    public interface ICardiactUltrasoundChartFormViewable
    {

    }

    public class CardiacChartProperties
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string TitleToolTip { get; set; }
        public bool LegendVisible { get; set; }

        public string AxisXTitle { get; set; }
        public bool AxisXGridVisible { get; set; }
        public double AxisXGridInterval { get; set; }
        public double AxisXMinimum { get; set; }
        public double AxisXMaximum { get; set; }
        public double AxisXInterval { get; set; }

        public string AxisYTitle { get; set; }
        public bool AxisYGridVisible { get; set; }
        public double AxisYGridInterval { get; set; }
        public double AxisYMinimum { get; set; }
        public double AxisYMaximum { get; set; }
        public double AxisYInterval { get; set; }
    }
}
