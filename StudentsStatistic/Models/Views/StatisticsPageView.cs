using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatistic.Models.Views
{
    internal class StatisticsPageView
    {
        public string GroupName { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public List<StatisticsWeekItemView> Items { get; set; }
    }
}
