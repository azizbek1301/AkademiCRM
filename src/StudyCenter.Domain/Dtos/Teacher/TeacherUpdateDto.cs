﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter.Domain.Dtos.Teacher
{
    public class TeacherUpdateDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string SubjectName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string About { get; set; }
        public int Education_id { get; set; }
    }
}
