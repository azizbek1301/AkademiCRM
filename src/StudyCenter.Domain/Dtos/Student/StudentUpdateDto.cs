using Microsoft.AspNetCore.Http;

namespace StudyCenter.Domain.Dtos.Student
{
    public class StudentUpdateDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ParentName { get; set; }
        public decimal Grade { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public IFormFile ImageUrl { get; set; }
    }
}
