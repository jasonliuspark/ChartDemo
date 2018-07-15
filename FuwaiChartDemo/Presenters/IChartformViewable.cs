using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace FuwaiChartDemo
{
    public interface IChartformViewable
    {
        void SetPropertiesToChart(int index, CardiacChartProperties properties);
        int SelectedFetusNumberIndex { set; }
        void SetSeriesToChart(int index,DataTable dt );
        void AddDataSeriesToChart(int index, string name,DataTable dt);

        void ShowChart(Series s);
    }
}
