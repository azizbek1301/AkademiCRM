using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Food_Categories.Queries;

namespace StudyCenter.Service.UseCases.Food_Categories.Handler
{
    public class GetAllFood_CategoryHandler : IRequestHandler<GetAllFood_CategoryQuery, List<Food_Category>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllFood_CategoryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Food_Category>> Handle(GetAllFood_CategoryQuery request, CancellationToken cancellationToken)
        {
            List<Food_Category> food_categories = await _context.Food_Categories.ToListAsync(cancellationToken);
            if (food_categories.Count() == 0)
                throw new Exception("Not Found");
            return food_categories;
        }
    }
}
