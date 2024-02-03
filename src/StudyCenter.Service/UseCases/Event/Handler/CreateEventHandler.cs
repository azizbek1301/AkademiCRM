using MediatR;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Event.Command;

namespace StudyCenter.Service.UseCases.Event.Handler
{
    public class CreateDocumentHandler : IRequestHandler<CreateEventCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateDocumentHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            Events events = new Events()
            {
                Name = request.Name,
                Date = request.Date,
                Subject_id = request.Subject_id,
            };

            await _context.Event.AddAsync(events, cancellationToken);
            int responce= await _context.SaveChangesAsync(cancellationToken);
            return responce;
        }
    }
}
