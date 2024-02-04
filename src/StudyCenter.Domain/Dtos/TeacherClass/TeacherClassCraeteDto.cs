using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter.Domain.Dtos.TeacherClass
{
    public class TeacherClassCraeteDto
    {
     
        public int Teacher_id { get; set; }
        public int Subject_id { get; set; }
        public int Student_id { get; set; }
    }
}
