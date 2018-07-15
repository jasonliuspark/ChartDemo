using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace FuwaiChartDemo
{
    public class ChartFormPresenter
    {
        public ChartFormPresenter(IChartformViewable chartForm)
        {
            _chartForm = chartForm;

        }
        public void LoadChart(object sender, EventArgs e)
        {
            DataTable dt = ChartDataManager.GetData(1);
            Series dataTableSeries = new Series(dt.ToString());
            dataTableSeries.Points.DataBind(dt.AsEnumerable(), "Date", "SomeFigure", "");
            dataTableSeries.XValueType = ChartValueType.DateTime;
            dataTableSeries.ChartType = SeriesChartType.Line;
            _chartForm.ShowChart(dataTableSeries);


        }

        public void SetPropertiesToChart()
        {
            throw new NotImplementedException();
        }

        public void SetSeriesToChart()
        {
            throw new NotImplementedException();
        }

        public void AddDataSeriesToChart()
        {
            throw new NotImplementedException();
        }
        private readonly IChartDataManagerable _chartDataManager;
        private readonly IChartformViewable _chartForm;
    }
}
