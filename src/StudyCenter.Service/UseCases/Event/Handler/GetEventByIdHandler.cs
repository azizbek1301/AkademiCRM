using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Event.Queries;

namespace StudyCenter.Service.UseCases.Event.Handler
{
    public class GetEventByIdHandler : IRequestHandler<GetEventByIdQuery, Events>
    {
        private readonly IApplicationDbContext _context;

        public GetEventByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Events> Handle(GetEventByIdQuery request, CancellationToken cancellationToken)
        {
            Events? events = await _context.Event.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (events == null)
            {
                throw new Exception("Document Not Found");
            }
            return events;
        }
    }
}
