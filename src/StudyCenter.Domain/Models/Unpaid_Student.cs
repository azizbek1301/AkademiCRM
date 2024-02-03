namespace StudyCenter.Domain.Models
{
    public class Unpaid_Student
    {
        public int Id { get; set; }
        public int StudentId { get;set; }

        public decimal Price { get; set; }

        public Student Student { get; set; }
    }
}
