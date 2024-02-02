namespace StudyCenter.Domain.Dtos.Notifications
{
    public class NotificationUpdateDto
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int Student_Id { get; set; }
    }
}
