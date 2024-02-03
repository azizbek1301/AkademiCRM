namespace StudyCenter.Domain.Models
{
    public class Food_Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Foods> Foods { get; set; }
    }
}
