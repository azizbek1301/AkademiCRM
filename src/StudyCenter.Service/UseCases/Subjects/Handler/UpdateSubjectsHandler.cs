using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Subjects.Command;

namespace StudyCenter.Service.UseCases.Subjects.Handler
{
    public class UpdateSubjectsHandler : IRequestHandler<UpdateSubjectsCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public UpdateSubjectsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateSubjectsCommand request, CancellationToken cancellationToken)
        {
            var subject = await _context.Subjects.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (subject == null)
            {
                throw new Exception("Not Found");
            }
            _context.Subjects.Update(subject);
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
