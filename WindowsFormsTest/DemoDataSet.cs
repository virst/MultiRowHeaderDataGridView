using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsTest
{
    class DemoDataSet : DataSet
    {
        public DemoDataSet()
        {
            Random rnd = new Random();

            var t = Tables.Add("DemoTable");

            t.Columns.Add("A", typeof(int));
            t.Columns.Add("C", typeof(int));
            t.Columns.Add("G", typeof(int));
            t.Columns.Add("Z", typeof(int));
            t.Columns.Add("T", typeof(int));

            for (int i = 0; i < 50; i++)
            {
                var r = t.Rows.Add();
                for (int j = 0; j < t.Columns.Count; j++) r[j] = rnd.Next(1, 999);
            }
        }
    }
}
