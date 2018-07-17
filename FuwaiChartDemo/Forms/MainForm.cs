using System;
using System.Windows.Forms;

namespace FuwaiChartDemo
{
    public partial class MainForm : Form
    {
        private readonly MainFormPresenter _presenter;

        public MainForm()
        {
            _presenter = new MainFormPresenter();
            InitializeComponent();
        }

        private void CardiacUltrasoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _presenter.CardiacUltrasoundChartClick();
        }

        private void CalculationFigureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _presenter.CardiacUltrasoundConfigClick();
        }
    }
}