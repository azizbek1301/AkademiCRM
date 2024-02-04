using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.TeacherClasses.Command;

namespace StudyCenter.Service.UseCases.TeacherClasses.Handler
{
    public class UpdateTeacherClassesHandler : IRequestHandler<UpdateTeacherClassesCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public UpdateTeacherClassesHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateTeacherClassesCommand request, CancellationToken cancellationToken)
        {
            var teacherClass = await _context.TeacherClasses.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (teacherClass==null)
            {
                throw new Exception("Not Found");
                
            }
            teacherClass.Subject_id = request.Subject_id;
            teacherClass.Teacher_id = request.Teacher_id;
            teacherClass.Student_id = request.Student_id;

            _context.TeacherClasses.Update(teacherClass);
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
