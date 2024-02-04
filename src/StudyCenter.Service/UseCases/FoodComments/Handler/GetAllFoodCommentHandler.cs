using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.FoodComments.Queries;

namespace StudyCenter.Service.UseCases.FoodComments.Handler
{
    public class GetAllFoodCommentHandler : IRequestHandler<GetAllFoodCommentQuery, List<FoodComment>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllFoodCommentHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<FoodComment>> Handle(GetAllFoodCommentQuery request, CancellationToken cancellationToken)
        {
            List<FoodComment> foodComments = await _context.Food_Comments.ToListAsync(cancellationToken);
            return foodComments;
        }
    }
}
