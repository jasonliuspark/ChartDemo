using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FuwaiChartDemo
{
    public partial class ChartForm : Form, IChartformViewable
    {


        public ChartForm()
        {
            InitializeComponent();
            _presenter = new ChartFormPresenter(this);
        }

        public void SetPropertiesToChart(int index, CardiacChartProperties properties)
        {
            _presenter.SetPropertiesToChart();
        }

        public int SelectedFetusNumberIndex { get; set; }
        public void SetSeriesToChart(int index, DataTable dt)
        {
            _presenter.SetSeriesToChart();
        }

        public void AddDataSeriesToChart(int index, string name, DataTable dt)
        {
            _presenter.AddDataSeriesToChart();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            _presenter.LoadChart(sender,e);
        }

        public void ShowChart(Series s)
        {
            cardiacChart.Series.Add(s);
        }

        private readonly ChartFormPresenter _presenter;
    }
}
