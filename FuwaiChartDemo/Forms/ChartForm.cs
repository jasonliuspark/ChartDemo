using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FuwaiChartDemo.Properties;

namespace FuwaiChartDemo
{
    public partial class ChartForm : Form, IChartformViewable
    {

        public ChartForm()
        {
            InitializeComponent();
            _presenter = new ChartFormPresenter(this);
        }

        public void SetPropertiesToChart()
        {
            cardiacChart.Legends.Add(new Legend("Cardiac Legend"));
            cardiacChart.ChartAreas[0].AxisX.Title = "DateTime";
            cardiacChart.ChartAreas[0].AxisX.MajorGrid.Enabled = true;

            cardiacChart.ChartAreas[0].AxisY.Title = Settings.Default.Keyword + " " + _unit + " ";
            cardiacChart.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            cardiacChart.ChartAreas[0].AxisY.Interval = 20;
        }

        public void SetSeriesToChart(DataTable dt)
        {
            var dataTableSeries = new Series(dt.ToString());
            dataTableSeries.Points.DataBind(dt.AsEnumerable(), "SubmissionTime", "Content", "");
            dataTableSeries.Sort(PointSortOrder.Ascending, "X");
            dataTableSeries.XValueType = ChartValueType.DateTime;
            dataTableSeries.ChartType = SeriesChartType.Line;
            dataTableSeries.Name = "Cardiac Data";
            dataTableSeries.Legend = "Cardiac Legend";
            dataTableSeries.IsVisibleInLegend = true;
            dataTableSeries.MarkerStyle = MarkerStyle.Circle;
            dataTableSeries.IsValueShownAsLabel = true;
            dataTableSeries.MarkerColor = Color.Red;
            dataTableSeries.MarkerSize = 5;
            cardiacChart.Series.Add(dataTableSeries);
        }

        public string Unit
        {
            set { _unit = value; }
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            _presenter.LoadChart(sender, e);
        }

        private readonly ChartFormPresenter _presenter;
        private string _unit;
    }
}