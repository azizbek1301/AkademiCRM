using StudyCenter.Domain.Enums;

namespace StudyCenter.Domain.Dtos.Admins
{
    public class UpdateAdminDto
    {
        public int AdminId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
