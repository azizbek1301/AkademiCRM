using StudyCenter.Domain.Enums;

namespace StudyCenter.Domain.Models
{
    public class School_Expence
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExpenceDate {  get; set; }
        public decimal Price {  get; set; }
        public Status Status { get; set; }
    }
}
