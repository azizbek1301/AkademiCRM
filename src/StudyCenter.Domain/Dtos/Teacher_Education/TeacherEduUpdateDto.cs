using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter.Domain.Dtos.Teacher_Education
{
    public class TeacherEduUpdateDto
    {
        public int Id { get; set; }
        public string EducationName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
