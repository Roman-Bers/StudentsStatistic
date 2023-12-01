using StudentStatistic.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatistic.Models.Views
{
    internal class StatisticsWeekItemView
    {
        public int WeekNumber { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public List<StatisticsStudentInfoView> StudentInfos { get; set; }

    }
}
