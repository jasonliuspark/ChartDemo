using System.Data;

namespace FuwaiChartDemo
{
    public interface IChartformViewable
    {
        void SetPropertiesToChart();
        void SetSeriesToChart(DataTable dt);
        string Unit { set; }
    }
}