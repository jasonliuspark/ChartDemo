using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuwaiChartDemo
{
    public class ChartDataManager
    {

        public ChartDataManager()
        {

        }
        public static DataTable GetData(int patientID)
        {
            DataTable dt = new DataTable();
            dt?.Dispose();
            dt = new DataTable("Result");
            DataColumn dc = new DataColumn("PatientID", typeof(int));
            DataColumn dc1 = new DataColumn("AccessionNumber", typeof(string));
            DataColumn dc2 = new DataColumn("SomeFigure", typeof(string));
            DataColumn dc3 = new DataColumn("Date", typeof(DateTime));
            dt.Columns.Add(dc);
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            DataRow newRow;
            newRow = dt.NewRow();
            newRow["PatientID"] = 1;
            newRow["AccessionNumber"] = "ct1";
            newRow["SomeFigure"] = "2.0";
            newRow["Date"] = Convert.ToDateTime("1991-3-15");
            dt.Rows.Add(newRow);

            newRow = dt.NewRow();
            newRow["PatientID"] = 2;
            newRow["AccessionNumber"] = "ct2";
            newRow["SomeFigure"] = "3.0";
            newRow["Date"] = Convert.ToDateTime("1992-3-15");
            dt.Rows.Add(newRow);

            newRow = dt.NewRow();
            newRow["PatientID"] = 2;
            newRow["AccessionNumber"] = "ct3";
            newRow["SomeFigure"] = "4.0";
            newRow["Date"] = Convert.ToDateTime("1993-3-15");
            dt.Rows.Add(newRow);

            return dt;
        }
    }
}
