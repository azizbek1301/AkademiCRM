using MediatR;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Teacher_Educations.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter.Service.UseCases.Teacher_Educations.Handler
{
    public class CreateTeacher_EducationHandler : IRequestHandler<CreateTeacher_EducationCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateTeacher_EducationHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateTeacher_EducationCommand request, CancellationToken cancellationToken)
        {
            var teacherEdu = new Teacher_Education()
            {
                EducationName = request.EducationName,
                StartDate = DateTime.UtcNow,
            };
            await _context.Teacher_Educations.AddAsync(teacherEdu,cancellationToken);
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
