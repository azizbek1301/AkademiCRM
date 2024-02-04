using StudyCenter.Domain.Enums;
using System.Text.Json.Serialization;

namespace Authorizatsiya.Api.Models
{
    public class Login
    {
        public string Email {  get; set; }
        public string Password { get; set; }
        [JsonIgnore]
        public Role Role {  get; set; } 
    }
}
