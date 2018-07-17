using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using FuwaiChartDemo.Properties;

namespace FuwaiChartDemo
{
    public class ChartFormPresenter
    {
        private readonly IChartDataManagerable _chartDataManager;

        private readonly IChartformViewable _chartForm;

        //dumb data
        private readonly List<string> _units = new List<string> {"mm", "cm", "%"};

        public ChartFormPresenter(IChartformViewable chartForm)
        {
            _chartForm = chartForm;
            _chartDataManager = new ChartDataManager();
            _chartDataManager.PopulateDB();
        }

        public void LoadChart(object sender, EventArgs e)
        {
            var data = _chartDataManager.GetData(Settings.Default.PatientNumber);
            data = DataKeyWordExtraction(data, Settings.Default.Keyword);
            _chartForm.SetPropertiesToChart();
            _chartForm.SetSeriesToChart(ToDataTable(data));
        }

        #region Private Methods

        private List<Data> DataKeyWordExtraction(List<Data> datas, string keyword)
        {
            foreach (var data in datas)
            {
                var content = data.Content.Split(new[] {','}, StringSplitOptions.None).ToList();
                foreach (var property in content)
                    //Console.WriteLine(a);
                    if (property.Contains(keyword))
                    {
                        datas[datas.IndexOf(data)].Content = FigureExtraction(property, keyword);
                        //Console.WriteLine(FigureExtraction(property, keyword));
                        break;
                    }

                //Console.WriteLine(data.SubmissionTime);
                data.SubmissionTime = data.SubmissionTime.Date;
            }

            return datas;
        }

        private string FigureExtraction(string data, string keyword)
        {
            var dataList = new List<string>();
            data = data.Remove(0, data.IndexOf(":"));
            if (data.Contains("||"))
            {
                dataList = data.Split(new[] {"||"}, StringSplitOptions.None).ToList();
                foreach (var item in dataList)
                    if (item.Contains(keyword))
                    {
                        _chartForm.Unit = UnitExtraction(item);
                        return Regex.Replace(item, @"[^0-9]+", "");
                    }
            }

            return Regex.Replace(data, @"[^0-9]+", "");
        }

        private string UnitExtraction(string content)
        {
            foreach (var t in _units)
                if (content.Contains(t))
                    return t;

            return string.Empty;
        }

        private DataTable ToDataTable<T>(IEnumerable<T> collection)
        {
            var props = typeof(T).GetProperties();
            var dt = new DataTable();
            dt.Columns.AddRange(props.Select(p => new DataColumn(p.Name, p.PropertyType)).ToArray());
            if (collection.Count() > 0)
                for (var i = 0; i < collection.Count(); i++)
                {
                    var tempList = new ArrayList();
                    foreach (var pi in props)
                    {
                        var obj = pi.GetValue(collection.ElementAt(i), null);
                        tempList.Add(obj);
                    }

                    var array = tempList.ToArray();
                    dt.LoadDataRow(array, true);
                }

            return dt;
        }

        #endregion
    }
}