using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Dtos.School_Expence;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.School_Expences.Command;

namespace StudyCenter.Service.UseCases.School_Expences.Handler
{
    public class UpdateSchool_ExtenceHandler : IRequestHandler<UpdateSchool_ExtenceCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public UpdateSchool_ExtenceHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateSchool_ExtenceCommand request, CancellationToken cancellationToken)
        {
            var res = await _context.School_Expences.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (res == null)
                throw new Exception("Not Found");
            res.Name = request.Name;
            res.ExpenceDate = DateTime.UtcNow;
            res.Price = request.Price;
            res.Status = request.Status;

            _context.School_Expences.Update(res);
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
