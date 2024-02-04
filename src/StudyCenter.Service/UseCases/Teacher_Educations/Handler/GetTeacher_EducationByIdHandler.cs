using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Teacher_Educations.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter.Service.UseCases.Teacher_Educations.Handler
{
    public class GetTeacher_EducationByIdHandler : IRequestHandler<GetTeacher_EducationByIdQuery, Teacher_Education>
    {
        private readonly IApplicationDbContext _context;

        public GetTeacher_EducationByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Teacher_Education> Handle(GetTeacher_EducationByIdQuery request, CancellationToken cancellationToken)
        {
            var teacherEdu = await _context.Teacher_Educations.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (teacherEdu == null)
            {
                throw new Exception("Not Found");

            }
            return teacherEdu;
        }
    }
}
