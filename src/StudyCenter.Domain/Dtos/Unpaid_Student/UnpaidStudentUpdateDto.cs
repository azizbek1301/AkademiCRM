using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter.Domain.Dtos.Unpaid_Student
{
    public class UnpaidStudentUpdateDto
    {
        public int Id { get; set; }
        public int StudentId { get; set; }

        public decimal Price { get; set; }
    }
}
