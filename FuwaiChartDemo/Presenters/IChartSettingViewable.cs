using System.Data;

namespace FuwaiChartDemo
{
    public interface IChartSettingViewable
    {
        //** not used for now
        string XAxialSetting { get; set; }
        string YAxialSetting { get; set; }
        void PopulateSelection(DataTable columTable);
        //***not used for now
        string keyword { set; get; }
        string patientNum { set; get; }

    }
}