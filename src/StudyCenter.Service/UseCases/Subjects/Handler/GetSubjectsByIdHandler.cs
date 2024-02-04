using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Subjects.Queries;

namespace StudyCenter.Service.UseCases.Subjects.Handler
{
    public class GetSubjectsByIdHandler : IRequestHandler<GetSubjectsByIdQuery, Subject>
    {
        private readonly IApplicationDbContext _context;

        public GetSubjectsByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Subject> Handle(GetSubjectsByIdQuery request, CancellationToken cancellationToken)
        {
            var subject = await _context.Subjects.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (subject == null)
                throw new Exception("Not Found");
            return subject;
        }
    }
}
