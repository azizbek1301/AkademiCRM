namespace StudyCenter.Domain.Models
{
    public class Teacher_Education
    {
        public int Id { get; set; }
        public string EducationName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }
}
