using MediatR;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.TeacherClasses.Command;

namespace StudyCenter.Service.UseCases.TeacherClasses.Handler
{
    public class CreateTeacherClassesHandler : IRequestHandler<CreateTeacherClassesCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateTeacherClassesHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateTeacherClassesCommand request, CancellationToken cancellationToken)
        {
            var teacherClass = new TeacherClass()
            {
                Student_id = request.Student_id,
                Subject_id = request.Subject_id,
                Teacher_id = request.Teacher_id,
            };
            await _context.TeacherClasses.AddAsync(teacherClass);
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
