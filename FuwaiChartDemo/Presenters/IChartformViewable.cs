using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuwaiChartDemo
{
    public interface IChartformViewable
    {
        void SetPropertiesToChart(int index, CardiacChartProperties properties);
        int SelectedFetusNumberIndex { set; }
        void SetSeriesToChart(int index,DataTable dt );
        void AddDataSeriesToChart(int index, string name,DataTable dt);
    }
}
