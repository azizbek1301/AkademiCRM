using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.TeacherClasses.Command;

namespace StudyCenter.Service.UseCases.TeacherClasses.Handler
{
    public class DeleteTeacherClassesHandler:IRequestHandler<DeleteTeacherClassesCommand,int>
    {
        private readonly IApplicationDbContext _context;

        public DeleteTeacherClassesHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteTeacherClassesCommand request, CancellationToken cancellationToken)
        {
            var teacherClass = await _context.TeacherClasses.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (teacherClass == null)
            {
                throw new Exception("Not Found");
            }
            _context.TeacherClasses.Remove(teacherClass);
            return await _context.SaveChangesAsync(cancellationToken);



        }
    }
}
