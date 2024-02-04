using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Food_Categories.Queries;

namespace StudyCenter.Service.UseCases.Food_Categories.Handler
{
    public class GetFood_CategoryByIdHandler : IRequestHandler<GetFood_CategoryByIdQuery, Food_Category>
    {
        private readonly IApplicationDbContext _context;

        public GetFood_CategoryByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Food_Category> Handle(GetFood_CategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var food_category=await _context.Food_Categories.FirstOrDefaultAsync(x=>x.Id==request.Id,cancellationToken);        
            if (food_category == null)
            {
                throw new Exception("Not Found");
            }
            return food_category;   
        }
    }
}
