namespace StudyCenter.Domain.Models
{
    public class Notifications
    {
        public int Id { get; set; }
        public string MEssage { get; set; }
        public DateTime Date { get; set; }
        public int Student_Id { get; set; }

        public Student Student { get; set; }
    }
}
