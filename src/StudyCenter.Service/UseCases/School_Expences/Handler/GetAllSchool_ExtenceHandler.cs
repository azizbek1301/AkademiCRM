using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.School_Expences.Queries;

namespace StudyCenter.Service.UseCases.School_Expences.Handler
{
    public class GetAllSchool : IRequestHandler<GetAllSchool_ExtenceQuery, List<School_Expence>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllSchool(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<School_Expence>> Handle(GetAllSchool_ExtenceQuery request, CancellationToken cancellationToken)
        {
            var res=await _context.School_Expences.ToListAsync(cancellationToken);
            return res;
        }
    }
}
