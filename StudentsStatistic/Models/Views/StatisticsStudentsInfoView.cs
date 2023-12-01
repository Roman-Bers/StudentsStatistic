using StudentStatistic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatistic.Models.Views
{
    internal class StatisticsStudentInfoView
    {
        public int StudentId { get; set; }
        public string StudentFullName { get; set; }
        public int VisitCount { get; set; }
        public int SendHomeWorkCount { get; set; }
        public int FeedbackCount { get; set; }
        public int GradeingCount { get; set; }
        public LearningStatus LearningStatus { get; set; }
    }
}
