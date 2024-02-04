using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.School_Expences.Queries;

namespace StudyCenter.Service.UseCases.School_Expences.Handler
{
    public class GetSchool_ExtenceByIdHandler : IRequestHandler<GetSchool_ExtenceByIdQuery, School_Expence>
    {
        private readonly IApplicationDbContext _context;

        public GetSchool_ExtenceByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<School_Expence> Handle(GetSchool_ExtenceByIdQuery request, CancellationToken cancellationToken)
        {
            var res=await _context.School_Expences.FirstOrDefaultAsync(x=>x.Id==request.Id,cancellationToken);
            if (res == null)
                throw new Exception("Not Found");
            return res;
        }
    }
}
