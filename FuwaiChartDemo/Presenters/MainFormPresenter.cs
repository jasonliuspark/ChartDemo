namespace FuwaiChartDemo
{
    internal class MainFormPresenter
    {
        public void CardiacUltrasoundChartClick()
        {
            var chart = new ChartForm();
            chart.Show();
        }

        public void CardiacUltrasoundConfigClick()
        {
            var setting = new ChartSettingDialog();
            setting.Show();
        }
    }
}