namespace StudyCenter.Domain.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName {  get; set; }
        public string SubjectName {  get; set; }
        public string PhoneNumber {  get; set; }
        public string Email { get; set; }
        public string Address {  get; set; }
        public string About {  get; set; }
        public int Education_id {  get; set; }

        public ICollection<TeacherClass> TeacherClasses { get; set; }
        public ICollection<Teacher_Education> Teacher_Educations {  get; set; }
    }
}
