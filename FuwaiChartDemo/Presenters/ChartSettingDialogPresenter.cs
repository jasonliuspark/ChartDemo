using FuwaiChartDemo.Properties;

namespace FuwaiChartDemo
{
    public class ChartSettingDialogPresenter
    {
        private readonly IChartSettingViewable _chartSetting;

        public ChartSettingDialogPresenter(IChartSettingViewable chartSetting)
        {
            _chartSetting = chartSetting;
        }

        public void LoadSettings()
        {
            _chartSetting.keyword = Settings.Default.Keyword;
            _chartSetting.patientNum = Settings.Default.PatientNumber;
        }

        public void CloseSettings()
        {
            Settings.Default.Keyword = _chartSetting.keyword;
            Settings.Default.PatientNumber = _chartSetting.patientNum;
            Settings.Default.Save();
        }
    }
}