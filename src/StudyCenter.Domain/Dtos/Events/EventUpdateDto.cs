namespace StudyCenter.Domain.Dtos.Events
{
    public class EventUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Subject_id { get; set; }
    }
}
