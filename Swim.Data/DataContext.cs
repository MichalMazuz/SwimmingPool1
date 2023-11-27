using Swim.Core.Entities;

namespace Swim.Data
{
    public class DataContext
    {
        public List<Lesson> lessons { get; set; }
        public List<Presence> presences { get; set; }
        public List<Student> students { get; set; }
        public List<Teacher> teachers { get; set; }
        public int LessonCount = 1;
        public int StudentCount = 1;
        public int TeacherCount = 1;
        public DataContext()
        {
            lessons = new List<Lesson>();
            presences = new List<Presence>();
            students = new List<Student>();
            teachers = new List<Teacher>();
            students.Add(new Student { StudentId = StudentCount++, StudentFirstName = "elish", StudentLastName = "katz", Address = "Sorotzkin4", StudentPhone = "0504153454", ParentsPhone = "0504153089", DateOfBirth = DateTime.Now, StudentEmail = "elishstar1@gmail.com", StudentStatus = true, StudentStatusDescription = "שחיה חופשית" });
            teachers.Add(new Teacher { TeacherId = TeacherCount++, TeacherFirstName = "malka", TeacherLastName = "brok", TeacherAddress = "kriatHertzog", TeacherPhone = "0527603743", TeacherEmail = "mabrok@gmail.com", TeacherStatus = true,TeacherDays=DayOfWeek.Monday ,TeacherHour = DateTime.Now });
            teachers.Add(new Teacher { TeacherId = TeacherCount++, TeacherFirstName = "hadasa", TeacherLastName = "coen", TeacherAddress = "chavakok", TeacherPhone = "035732865", TeacherEmail = "hadsac@gmail.com", TeacherStatus = true,TeacherDays=DayOfWeek.Sunday, TeacherHour = DateTime.Now });
            lessons.Add(new Lesson { LessonId = LessonCount++, LessonDescription = "שיפור שחיה", LessonHour = DateTime.Now, TeacherId = 1 });
            lessons.Add(new Lesson { LessonId = LessonCount++, LessonDescription = "שחיה מתחילות", LessonHour = DateTime.Now, TeacherId = 2 });
            presences.Add(new Presence { LessonId = 1, TeacherId = 1, StudentId = 1, IsPresent = true });

        }
    }
}