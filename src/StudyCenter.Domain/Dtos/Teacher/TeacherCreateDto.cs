namespace StudyCenter.Domain.Dtos.Teacher
{
    public class TeacherCreateDto
    {

        public string FullName { get; set; }
        public string SubjectName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string About { get; set; }
        public int Education_id { get; set; }
    }
}
