using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter.Domain.Dtos.Unpaid_Student
{
    public class UnpaidStudentCreateDto
    {
       
        public int StudentId { get; set; }

        public decimal Price { get; set; }
    }
}
