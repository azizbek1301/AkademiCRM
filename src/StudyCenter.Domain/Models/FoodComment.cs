namespace StudyCenter.Domain.Models
{
    public class FoodComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public int Food_id { get; set; }

        public Foods Foods { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}
