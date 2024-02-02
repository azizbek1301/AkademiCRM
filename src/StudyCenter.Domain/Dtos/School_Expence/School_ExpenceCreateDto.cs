using StudyCenter.Domain.Enums;

namespace StudyCenter.Domain.Dtos.School_Expence
{
    public class School_ExpenceCreateDto
    {
        
        public string Name { get; set; }
        public DateTime ExpenceDate { get; set; }
        public decimal Price { get; set; }
        public Status Status { get; set; }
    }
}
