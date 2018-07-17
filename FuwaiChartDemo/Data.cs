using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuwaiChartDemo
{
    public class Data
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public DateTime SubmissionTime { get; set; }
    }

    public class DataContext : DbContext
    {
        static DataContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataContext>());
        }

        public DbSet<Data> DataS { get; set; }
    }

}
