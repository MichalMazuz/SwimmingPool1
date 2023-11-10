namespace SwimmingPool.Entities
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string? LessonDescription { get; set; }
        public DateTime LessonHour { get; set; }
        public int TeacherId { get; set; }

    }
}
