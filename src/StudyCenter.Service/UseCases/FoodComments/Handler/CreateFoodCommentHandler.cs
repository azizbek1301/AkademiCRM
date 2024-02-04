using MediatR;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.FoodComments.Command;

namespace StudyCenter.Service.UseCases.FoodComments.Handler
{
    public class CreateFoodCommentHandler : IRequestHandler<CreateFoodCommentCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateFoodCommentHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateFoodCommentCommand request, CancellationToken cancellationToken)
        {
            FoodComment? foodComment = new FoodComment()
            {
                Comment = request.Comment,
                Date=DateTime.UtcNow, 
                Food_id=request.Food_id 
            };
            await _context.Food_Comments.AddAsync(foodComment,cancellationToken);
            int response = await _context.SaveChangesAsync(cancellationToken);
            return response;
        }
    }
}
