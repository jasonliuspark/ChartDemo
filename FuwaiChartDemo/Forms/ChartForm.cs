using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuwaiChartDemo
{
    public partial class ChartForm : Form, IChartformViewable
    {
        public ChartForm()
        {
            InitializeComponent();
        }

        public void SetPropertiesToChart(int index, CardiacChartProperties properties)
        {
            throw new NotImplementedException();
        }

        public int SelectedFetusNumberIndex { get; set; }
        public void SetSeriesToChart(int index, DataTable dt)
        {
            throw new NotImplementedException();
        }

        public void AddDataSeriesToChart(int index, string name, DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}
