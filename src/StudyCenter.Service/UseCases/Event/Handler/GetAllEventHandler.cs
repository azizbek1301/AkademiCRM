using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Event.Queries;

namespace StudyCenter.Service.UseCases.Event.Handler
{
    public class GetAllEventHandler : IRequestHandler<GetAllEventQuery, IEnumerable<Events>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllEventHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Events>> Handle(GetAllEventQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<Events> events=await _context.Event.ToListAsync(cancellationToken);
            if (events.Count() == 0)
                throw new Exception("Events Not Found");
            return events;
        }
    }
}
