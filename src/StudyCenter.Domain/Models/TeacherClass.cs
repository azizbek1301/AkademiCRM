using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter.Domain.Models
{
    public class TeacherClass
    {
        public int Id { get; set; }
        public int Teacher_id {  get; set; }
        public int Subject_id { get; set; }
        public int Student_id {  get; set; }

        public Teacher Teacher { get; set; }
        public Subject Subject { get; set; }
        public Student Student { get; set; }

    }
}
