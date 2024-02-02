namespace StudyCenter.Domain.Models
{
    public class Events
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Subject_id { get; set; }

        public Subject Subject { get; set; }
    }
}
