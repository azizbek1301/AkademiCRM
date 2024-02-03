using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Event.Command;

namespace StudyCenter.Service.UseCases.Event.Handler
{
    public class UpdateEventHandler : IRequestHandler<UpdateEventCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public UpdateEventHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async  Task<int> Handle(UpdateEventCommand request, CancellationToken cancellationToken)
        {
            Events? events = await _context.Event.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if(events == null)
            {
                throw new Exception("Document Not Found");
            }
            events.Name = request.Name;
            events.Subject_id=request.Subject_id;
            events.Date = DateTime.UtcNow;

            _context.Event.Update(events);
            int response = await _context.SaveChangesAsync(cancellationToken);
            return response;
        }

        
    }
}
