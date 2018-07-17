using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuwaiChartDemo
{
    public interface IChartDataManagerable
    {
        void PopulateDB();
        List<Data> GetData(string patientNumber);
    }
}
