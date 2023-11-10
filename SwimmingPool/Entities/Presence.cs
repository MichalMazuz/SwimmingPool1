namespace SwimmingPool.Entities
{
    public class Presence
    {
        public int LessonId { get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public bool IsPresent { get; set; }
       
    }
}
