using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.TeacherClasses.Queries;

namespace StudyCenter.Service.UseCases.TeacherClasses.Handler
{
    public class GetTeacherClassesByIdHandler : IRequestHandler<GetTeacherClassesByIdQuery, TeacherClass>
    {
        private readonly IApplicationDbContext  _context;

        public GetTeacherClassesByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TeacherClass> Handle(GetTeacherClassesByIdQuery request, CancellationToken cancellationToken)
        {
            var teacherClass = await _context.TeacherClasses.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (teacherClass == null)
            {
                throw new Exception("Not Found");
            }
            return teacherClass;
        }
    }
}
