using MediatR;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Subjects.Command;

namespace StudyCenter.Service.UseCases.Subjects.Handler
{
    public class CreateSubjectsHandler : IRequestHandler<CreateSubjectsCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateSubjectsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateSubjectsCommand request, CancellationToken cancellationToken)
        {
            Subject? subject = new Subject()
            {
                Name = request.Name,
            };

            await _context.Subjects.AddAsync(subject);
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
