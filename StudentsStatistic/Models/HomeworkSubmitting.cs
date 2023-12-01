using StudentStatistic.Enums;
using StudentStatistic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatistic.Models
{
    internal class HomeworkSubmitting
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int StudentId { get; set; }
        public HomeWorkStatus Status { get; set; }
    }
}
