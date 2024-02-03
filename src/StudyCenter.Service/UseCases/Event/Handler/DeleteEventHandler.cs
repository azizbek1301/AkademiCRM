using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Event.Command;

namespace StudyCenter.Service.UseCases.Event.Handler
{
    public class DeleteEventHandler : IRequestHandler<DeleteEvenetCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public DeleteEventHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteEvenetCommand request, CancellationToken cancellationToken)
        {
            Events? events = await _context.Event.FirstOrDefaultAsync(x => x.Id == request.Id);
            if(events == null)
            {
                throw new Exception("Document Not Found");
            }
            _context.Event.Remove(events);
            int response =await _context.SaveChangesAsync(cancellationToken);
            return response;
        }
    }
}
