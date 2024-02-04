using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.FoodComments.Queries;

namespace StudyCenter.Service.UseCases.FoodComments.Handler
{
    public class GetFoodCommentByIdHandler : IRequestHandler<GetFoodCommentByIdQuery, FoodComment>
    {
        private readonly IApplicationDbContext _context;

        public GetFoodCommentByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<FoodComment> Handle(GetFoodCommentByIdQuery request, CancellationToken cancellationToken)
        {
            var foodComment=await _context.Food_Comments.FirstOrDefaultAsync(x=>x.Id==request.Id,cancellationToken);
            if(foodComment == null)
            {
                throw new Exception("Not Found");
            }
            return foodComment;
        }
    }
}
