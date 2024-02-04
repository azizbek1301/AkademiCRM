using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Teacher_Educations.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter.Service.UseCases.Teacher_Educations.Handler
{
    public class DeleteTeacher_EducationHandler : IRequestHandler<DeleteTeacher_EducationCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public DeleteTeacher_EducationHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteTeacher_EducationCommand request, CancellationToken cancellationToken)
        {
            var teacherEdu = await _context.Teacher_Educations.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (teacherEdu == null)
                throw new Exception("Not Found");
            teacherEdu.EndDate = DateTime.UtcNow;
            _context.Teacher_Educations.Remove(teacherEdu);
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
