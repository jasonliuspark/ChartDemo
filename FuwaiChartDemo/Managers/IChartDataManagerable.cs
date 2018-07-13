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
        DataTable GetData(string accesionNum);
        
    }
}
