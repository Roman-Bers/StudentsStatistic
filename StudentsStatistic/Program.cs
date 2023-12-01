using StudentStatistic.Enums;
using StudentStatistic.Models;
using StudentStatistic.Models.Views;
using System.Collections.Generic;

Group[] DB_groups = { new Group() { Id = 1, Name = "Группа 1" }, new Group() { Id = 2, Name = "Группа 2" }, };

Student[] DB_students =
{
    new Student() { Id = 1, GroupId = 1, FullName = "Ivan" },
    new Student() { Id = 2, GroupId = 1, FullName = "Oleg" },
    new Student() { Id = 3, GroupId = 2, FullName = "Roman" },
    new Student() { Id = 4, GroupId = 2, FullName = "Anna" },
    new Student() { Id = 5, GroupId = 3, FullName = "Elena" },
    new Student() { Id = 6, GroupId = 4, FullName = "Kristina" },
};

StudentVisit[] DB_visits =
{
    new StudentVisit() { Id = 1, Date = new DateTime(2023, 4, 10, 22, 10, 10), StudentId = 1 },
    new StudentVisit() { Id = 2, Date = new DateTime(2023, 4, 11, 22, 10, 10), StudentId = 1 },
    new StudentVisit() { Id = 3, Date = new DateTime(2023, 4, 12, 22, 10, 10), StudentId = 1 },
    new StudentVisit() { Id = 4, Date = new DateTime(2023, 4, 17, 22, 10, 10), StudentId = 1 },

    new StudentVisit() { Id = 5, Date = new DateTime(2023, 4, 18, 22, 10, 10), StudentId = 1 },
    new StudentVisit() { Id = 6, Date = new DateTime(2023, 4, 19, 22, 10, 10), StudentId = 1 },
    new StudentVisit() { Id = 7, Date = new DateTime(2023, 4, 24, 22, 10, 10), StudentId = 1 },

    new StudentVisit() { Id = 8, Date = new DateTime(2023, 4, 25, 22, 10, 10), StudentId = 1 },
    new StudentVisit() { Id = 9, Date = new DateTime(2023, 4, 26, 22, 10, 10), StudentId = 1 },

    new StudentVisit() { Id = 14, Date = new DateTime(2023, 4, 17, 22, 10, 10), StudentId = 2 },

    new StudentVisit() { Id = 18, Date = new DateTime(2023, 4, 25, 22, 10, 10), StudentId = 2 },
    new StudentVisit() { Id = 19, Date = new DateTime(2023, 4, 26, 22, 10, 10), StudentId = 2 },


    //new StudentVisit() { Id = 21, Date = new DateTime(2023, 4, 10, 22, 10, 10), StudentId = 3 },
    //new StudentVisit() { Id = 22, Date = new DateTime(2023, 4, 11, 22, 10, 10), StudentId = 3 },
    //new StudentVisit() { Id = 23, Date = new DateTime(2023, 4, 12, 22, 10, 10), StudentId = 3 },
    //new StudentVisit() { Id = 24, Date = new DateTime(2023, 4, 17, 22, 10, 10), StudentId = 3 },

    //new StudentVisit() { Id = 25, Date = new DateTime(2023, 4, 18, 22, 10, 10), StudentId = 3 },
    //new StudentVisit() { Id = 26, Date = new DateTime(2023, 4, 19, 22, 10, 10), StudentId = 3 },
    //new StudentVisit() { Id = 27, Date = new DateTime(2023, 4, 24, 22, 10, 10), StudentId = 3 },

    //new StudentVisit() { Id = 28, Date = new DateTime(2023, 4, 25, 22, 10, 10), StudentId = 3 },
    //new StudentVisit() { Id = 29, Date = new DateTime(2023, 4, 26, 22, 10, 10), StudentId = 3 },
};

HomeworkSubmitting[] DB_submittings =
{
    new HomeworkSubmitting() { Id = 1, Date = new DateTime(2023, 4, 10, 22, 10, 10), StudentId = 1, Status = HomeWorkStatus.Sended },
    new HomeworkSubmitting() { Id = 2, Date = new DateTime(2023, 4, 11, 22, 10, 10), StudentId = 1, Status = HomeWorkStatus.NeedWork },
    new HomeworkSubmitting() { Id = 3, Date = new DateTime(2023, 4, 12, 22, 10, 10), StudentId = 1, Status = HomeWorkStatus.NeedWork },
    new HomeworkSubmitting() { Id = 4, Date = new DateTime(2023, 4, 17, 22, 10, 10), StudentId = 1, Status = HomeWorkStatus.NeedWork },

    new HomeworkSubmitting() { Id = 5, Date = new DateTime(2023, 4, 18, 22, 10, 10), StudentId = 1, Status = HomeWorkStatus.HasGrade },
    new HomeworkSubmitting() { Id = 6, Date = new DateTime(2023, 4, 19, 22, 10, 10), StudentId = 1, Status = HomeWorkStatus.Sended },
    new HomeworkSubmitting() { Id = 7, Date = new DateTime(2023, 4, 24, 22, 10, 10), StudentId = 1, Status = HomeWorkStatus.Sended },

    new HomeworkSubmitting() { Id = 8, Date = new DateTime(2023, 4, 25, 22, 10, 10), StudentId = 1, Status = HomeWorkStatus.HasGrade },
    new HomeworkSubmitting() { Id = 9, Date = new DateTime(2023, 4, 26, 22, 10, 10), StudentId = 1, Status = HomeWorkStatus.HasGrade },



    new HomeworkSubmitting() { Id = 11, Date = new DateTime(2023, 4, 10, 22, 10, 10), StudentId = 2, Status = HomeWorkStatus.Sended },
    new HomeworkSubmitting() { Id = 12, Date = new DateTime(2023, 4, 11, 22, 10, 10), StudentId = 2, Status = HomeWorkStatus.NeedWork },
    new HomeworkSubmitting() { Id = 13, Date = new DateTime(2023, 4, 12, 22, 10, 10), StudentId = 2, Status = HomeWorkStatus.NeedWork },
    new HomeworkSubmitting() { Id = 14, Date = new DateTime(2023, 4, 17, 22, 10, 10), StudentId = 2, Status = HomeWorkStatus.NeedWork },

    new HomeworkSubmitting() { Id = 18, Date = new DateTime(2023, 4, 25, 22, 10, 10), StudentId = 2, Status = HomeWorkStatus.NeedWork },
    new HomeworkSubmitting() { Id = 19, Date = new DateTime(2023, 4, 26, 22, 10, 10), StudentId = 2, Status = HomeWorkStatus.HasGrade },


    //new HomeworkSubmitting() { Id = 21, Date = new DateTime(2023, 4, 10, 22, 10, 10), StudentId = 3, Status = HomeWorkStatus.Sended },
    //new HomeworkSubmitting() { Id = 22, Date = new DateTime(2023, 4, 11, 22, 10, 10), StudentId = 3, Status = HomeWorkStatus.HasGrade },
    //new HomeworkSubmitting() { Id = 23, Date = new DateTime(2023, 4, 12, 22, 10, 10), StudentId = 3, Status = HomeWorkStatus.Sended },
    //new HomeworkSubmitting() { Id = 24, Date = new DateTime(2023, 4, 17, 22, 10, 10), StudentId = 3, Status = HomeWorkStatus.HasGrade },

    //new HomeworkSubmitting() { Id = 25, Date = new DateTime(2023, 4, 18, 22, 10, 10), StudentId = 3, Status = HomeWorkStatus.Sended },
    //new HomeworkSubmitting() { Id = 26, Date = new DateTime(2023, 4, 19, 22, 10, 10), StudentId = 3, Status = HomeWorkStatus.HasGrade },
    //new HomeworkSubmitting() { Id = 27, Date = new DateTime(2023, 4, 24, 22, 10, 10), StudentId = 3, Status = HomeWorkStatus.Sended },

    //new HomeworkSubmitting() { Id = 28, Date = new DateTime(2023, 4, 25, 22, 10, 10), StudentId = 3, Status = HomeWorkStatus.HasGrade },
    //new HomeworkSubmitting() { Id = 29, Date = new DateTime(2023, 4, 26, 22, 10, 10), StudentId = 3, Status = HomeWorkStatus.Sended },
};


DateTime dtFrom = new DateTime(2023, 4, 10);
DateTime dtTo = new DateTime(2023, 6, 10);

int groupId = 1;

StatisticsPageView spv = GetStudentsStatistics(dtFrom, dtTo, groupId, DB_groups, DB_students, DB_visits, DB_submittings);

foreach (StatisticsWeekItemView weekItem in spv.Items)
{
    Console.WriteLine("----------");
    Console.WriteLine($"{weekItem.WeekNumber} {weekItem.DateFrom} - {weekItem.DateTo}");
    foreach (StatisticsStudentInfoView infoItem in weekItem.StudentInfos)
    {
        switch (infoItem.LearningStatus)
        {
            case LearningStatus.GoodStudent:
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case LearningStatus.OnlyVisit:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case LearningStatus.SkipsLesson:
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
        }

        Console.WriteLine($"FullName: {infoItem.StudentFullName,10} | Visits: {infoItem.VisitCount,2} | Send: {infoItem.SendHomeWorkCount,2} | Feedback: {infoItem.FeedbackCount,2} | Gradeing: {infoItem.GradeingCount,2}");
    }
    Console.ResetColor();
    Console.WriteLine("----------");
}


Console.WriteLine();
Console.ReadKey();

static StatisticsPageView GetStudentsStatistics(DateTime dtFrom, DateTime dtTo, int groupId, IEnumerable<Group> DB_groups, IEnumerable<Student> DB_students, IEnumerable<StudentVisit> DB_visits, IEnumerable<HomeworkSubmitting> DB_submittings)
{
    List<StudentVisit> visits = (from visit in DB_visits
                                 join student in DB_students on visit.StudentId equals student.Id
                                 where visit.Date >= dtFrom && visit.Date <= dtTo && student.GroupId == groupId
                                 select visit).ToList();

    List<HomeworkSubmitting> submittings = (from submitting in DB_submittings
                                            join student in DB_students on submitting.StudentId equals student.Id
                                            where submitting.Date >= dtFrom && submitting.Date <= dtTo && student.GroupId == groupId
                                            select submitting).ToList();

    string groupName = DB_groups.Single(x => x.Id == groupId).Name;

    StatisticsPageView spv = new StatisticsPageView()
    {
        DateFrom = dtFrom,
        DateTo = dtTo,
        GroupName = groupName,
        Items = new List<StatisticsWeekItemView>()
    };


    List<DateTime> dateTimeList = new List<DateTime>(visits.Count + submittings.Count);
    dateTimeList.AddRange(visits.Select(x => x.Date));
    dateTimeList.AddRange(submittings.Select(x => x.Date));

    DateTime dateMax = dateTimeList.Max();
    DateTime dateMin = dateTimeList.Min();

    List<DateTime> datePoints = new List<DateTime>();

    DateTime dateCurrent = dateMin;
    datePoints.Add(dateCurrent);
    while (true)
    {
        dateCurrent = dateCurrent.AddDays(7);

        if (dateCurrent >= dateMax)
        {
            datePoints.Add(dateMax);
            break;
        }
        else
        {
            datePoints.Add(dateCurrent);
        }
    }

    List<(DateTime DateFrom, DateTime DateTo)> weekIntervals = new List<(DateTime DateFrom, DateTime DateTo)>();

    for (int i = 0; i < datePoints.Count - 1; i++)
    {
        DateTime dtItemFrom = datePoints[i];
        DateTime dateFrom = new DateTime(dtItemFrom.Year, dtItemFrom.Month, dtItemFrom.Day, 0, 0, 0);

        DateTime dtItemTo = datePoints[i + 1].AddDays(-1);
        DateTime dateTo = new DateTime(dtItemTo.Year, dtItemTo.Month, dtItemTo.Day, 23, 59, 59);

        weekIntervals.Add((DateFrom: dateFrom, DateTo: dateTo));
    }

    List<int> allStudentsIds = visits.Select(x => x.StudentId).Union(submittings.Select(x => x.StudentId)).ToList();
    List<Student> allStuents = DB_students.Where(x => allStudentsIds.Contains(x.Id)).ToList();

    int weekCounter = 0;
    foreach ((DateTime DateFrom, DateTime DateTo) weekInterval in weekIntervals)
    {
        weekCounter++;

        List<StudentVisit> visitsPerWeek = visits.Where(x => x.Date >= weekInterval.DateFrom && x.Date <= weekInterval.DateTo).ToList();
        List<HomeworkSubmitting> submittingsPerWeek = submittings.Where(x => x.Date >= weekInterval.DateFrom && x.Date <= weekInterval.DateTo).ToList();

        StatisticsWeekItemView weekItemView = new StatisticsWeekItemView()
        {
            WeekNumber = weekCounter,
            DateFrom = weekInterval.DateFrom,
            DateTo = weekInterval.DateTo,
            StudentInfos = new List<StatisticsStudentInfoView>()
        };


        List<IGrouping<int, StudentVisit>> visitsPerWeekGroup = visitsPerWeek.GroupBy(x => x.StudentId).ToList();
        var submittingsPerWeekGroup = submittingsPerWeek.GroupBy(x => x.StudentId).ToList();

        foreach (Student studentItem in allStuents)
        {
            StatisticsStudentInfoView studentInfoView = new StatisticsStudentInfoView()
            {
                StudentFullName = studentItem.FullName
            };

            IGrouping<int, StudentVisit> visitsPerStudent = visitsPerWeekGroup.SingleOrDefault(x => x.Key == studentItem.Id);

            if (visitsPerStudent is not null)
            {
                studentInfoView.VisitCount = visitsPerStudent.Count();
            }

            IGrouping<int, HomeworkSubmitting> submittingsPerStudent = submittingsPerWeekGroup.SingleOrDefault(x => x.Key == studentItem.Id);

            if (submittingsPerStudent is not null)
            {
                studentInfoView.SendHomeWorkCount = submittingsPerStudent.Count(x => x.Status == HomeWorkStatus.Sended);
                studentInfoView.FeedbackCount = submittingsPerStudent.Count(x => x.Status == HomeWorkStatus.NeedWork);
                studentInfoView.GradeingCount = submittingsPerStudent.Count(x => x.Status == HomeWorkStatus.HasGrade);
            }


            if (studentInfoView.VisitCount > 0 && studentInfoView.SendHomeWorkCount > 0)
            {
                studentInfoView.LearningStatus = LearningStatus.GoodStudent;
            }
            else if (studentInfoView.VisitCount > 0)
            {
                studentInfoView.LearningStatus = LearningStatus.OnlyVisit;
            }
            else
            {
                studentInfoView.LearningStatus = LearningStatus.SkipsLesson;

            }

            weekItemView.StudentInfos.Add(studentInfoView);
        }

        spv.Items.Add(weekItemView);
    }

    return spv;
}