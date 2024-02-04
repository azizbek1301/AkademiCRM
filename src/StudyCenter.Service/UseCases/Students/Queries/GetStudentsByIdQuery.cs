using MediatR;
using StudyCenter.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter.Service.UseCases.Students.Queries
{
    public class GetStudentsByIdQuery:IRequest<Student>
    {
        public int Id {  get; set; }    
    }
}
