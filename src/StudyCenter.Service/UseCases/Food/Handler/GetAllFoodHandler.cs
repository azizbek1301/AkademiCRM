using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Food.Queries;

namespace StudyCenter.Service.UseCases.Food.Handler
{
    public class GetAllFoodHandler : IRequestHandler<GetAllFoodQuery, List<Foods>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllFoodHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Foods>> Handle(GetAllFoodQuery request, CancellationToken cancellationToken)
        {
            List<Foods> foods=await _context.Foods.ToListAsync(cancellationToken);

          
            return foods;


        }
    }
}
