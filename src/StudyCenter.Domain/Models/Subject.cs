namespace StudyCenter.Domain.Models
{
    public class Subject
    {
        public int Id {  get; set; }
        public string Name { get; set; }

        public ICollection<Events> Events { get; set; }
        public ICollection<TeacherClass> TeacherClassess { get; set; }
    }
}
