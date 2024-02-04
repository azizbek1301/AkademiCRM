using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.School_Expences.Command;

namespace StudyCenter.Service.UseCases.School_Expences.Handler
{
    public class DeleteSchool_ExtenceHandler : IRequestHandler<DeleteSchool_ExtenceCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public DeleteSchool_ExtenceHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteSchool_ExtenceCommand request, CancellationToken cancellationToken)
        {
            School_Expence? school_Expence = await _context.School_Expences.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (school_Expence == null)
                throw new Exception("Not found");
            _context.School_Expences.Remove(school_Expence);
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
