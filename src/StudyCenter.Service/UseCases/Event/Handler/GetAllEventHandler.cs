using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Event.Queries;

namespace StudyCenter.Service.UseCases.Event.Handler
{
    public class GetAllEventHandler : IRequestHandler<GetAllEventQuery, List<Events>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllEventHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Events>> Handle(GetAllEventQuery request, CancellationToken cancellationToken)
        {
            var events=await _context.Event.ToListAsync(cancellationToken);
            
            return events;
        }
    }
}
