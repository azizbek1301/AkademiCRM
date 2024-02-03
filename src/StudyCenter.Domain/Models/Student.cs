namespace StudyCenter.Domain.Models
{
    public class Student
    {
        public int Id {  get; set; }
        public string FullName {  get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } = default!;
        public string ParentName {  get; set; }
        public decimal Grade {  get; set; }
        public string Address {  get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Notifications> Notifications { get; set; }
        public ICollection<Unpaid_Student> Unpaids { get; set; }

        public ICollection<TeacherClass> TeacherClasses { get; set; }

    }
}
