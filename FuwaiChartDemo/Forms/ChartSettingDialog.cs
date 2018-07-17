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
            _presenter = new ChartSettingDialogPresenter(this);
            InitializeComponent();
        }

        public string XAxialSetting { get; set; }
        public string YAxialSetting { get; set; }
        public void PopulateSelection(DataTable columTable)
        {
            throw new NotImplementedException();
        }

        public string keyword
        {
            get { return keyWordTextBox.Text; }
            set { keyWordTextBox.Text = value; }
        }
        public string patientNum
        {
            get { return patientNumberTextBox1.Text; }
            set { patientNumberTextBox1.Text = value; }
        }

        private void ChartSettingDialog_Load(object sender, EventArgs e)
        {
            _presenter.LoadSettings();
        }

        private readonly ChartSettingDialogPresenter _presenter;

        private void ChartSettingDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            _presenter.CloseSettings();
        }
    }
}
