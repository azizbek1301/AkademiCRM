using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Teachers.Command;

namespace StudyCenter.Service.UseCases.Teachers.Handler
{
    public class DeleteTeacherHandler : IRequestHandler<DeleteTeacherCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public DeleteTeacherHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteTeacherCommand request, CancellationToken cancellationToken)
        {
            var teacher=await _context.Teachers.FirstOrDefaultAsync(x=>x.Id==request.Id,cancellationToken);
            if (teacher==null)
            {
                throw new Exception("not Found");
            }
            _context.Teachers.Remove(teacher);
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
