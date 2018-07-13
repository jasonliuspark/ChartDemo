using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuwaiChartDemo
{
    interface IChartSettingViewable
    {
        string XAxialSetting { get; set; }
        string YAxialSetting { get; set; }
        void PopulateSelection(DataTable columTable);
    }
}
