using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.ComponentModel;
using DentalCareForms;

namespace SQLiteDb
{
    public partial class SQLiteConn
    {
        internal List<Day> GetDays()
        {
            var daysList = new List<Day>();

            using (var rs = ExecuteQuery("SELECT DISTINCT a.day_id, d.name\r\nFROM appointments a\r\nINNER JOIN days d ON (a.day_id = d.id)\r\nORDER BY a.day_id"))
            {
                while (rs.NextRecord())
                {
                    daysList.Add(new Day(rs.GetInt32("day_id"), rs.GetString("name")));
                }
            }

            return daysList;
        }
    }
}
