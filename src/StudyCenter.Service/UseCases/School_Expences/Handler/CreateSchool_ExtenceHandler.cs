using MediatR;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.School_Expences.Command;

namespace StudyCenter.Service.UseCases.School_Expences.Handler
{
    public class CreateSchool_ExtenceHandler : IRequestHandler<CreateSchool_ExpenceCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateSchool_ExtenceHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateSchool_ExpenceCommand request, CancellationToken cancellationToken)
        {
            School_Expence? school_Expence = new School_Expence()
            {
                Name = request.Name,
                ExpenceDate = DateTime.UtcNow,
                Price = request.Price,
                Status = request.Status,
            };
            await _context.School_Expences.AddAsync(school_Expence, cancellationToken);
            int response = await _context.SaveChangesAsync(cancellationToken);
            return response;
        }
    }
}
