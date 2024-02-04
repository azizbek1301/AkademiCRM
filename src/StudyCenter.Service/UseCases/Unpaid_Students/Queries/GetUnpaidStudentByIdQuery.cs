using MediatR;
using StudyCenter.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter.Service.UseCases.Unpaid_Students.Queries
{
    public class GetUnpaidStudentByIdQuery:IRequest<Unpaid_Student>
    {
        public int Id { get; set; } 
    }
}
