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
    public partial class ChartSettingDialog : Form, IChartSettingViewable
    {
        public ChartSettingDialog()
        {
            InitializeComponent();
        }

        public string XAxialSetting { get; set; }
        public string YAxialSetting { get; set; }
        public void PopulateSelection(DataTable columTable)
        {
            throw new NotImplementedException();
        }
    }
}
