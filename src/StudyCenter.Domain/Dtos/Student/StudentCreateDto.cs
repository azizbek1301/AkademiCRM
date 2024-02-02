using Microsoft.AspNetCore.Http;

namespace StudyCenter.Domain.Dtos.Student
{
    public class StudentCreateDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } = default!;
        public string ParentName { get; set; }
        public decimal Grade { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public IFormFile ImageUrl { get; set; }
    }
}
