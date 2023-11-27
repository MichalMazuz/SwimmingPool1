namespace Swim.Core.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? StudentFirstName { get; set; }
        public string? StudentLastName { get; set; }
        public string? Address { get; set; }
        public string StudentPhone { get; set; }
        public string ParentsPhone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? StudentEmail { get; set; }
        public bool StudentStatus { get; set; }
        public string? StudentStatusDescription { get; set; }
      
    }
}
