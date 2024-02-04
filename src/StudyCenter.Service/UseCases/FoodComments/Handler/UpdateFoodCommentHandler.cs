using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.FoodComments.Command;

namespace StudyCenter.Service.UseCases.FoodComments.Handler
{
    public class UpdateFoodCommentHandler : IRequestHandler<UpdateFoodCommentCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public UpdateFoodCommentHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateFoodCommentCommand request, CancellationToken cancellationToken)
        {
            var foodComment=await _context.Food_Comments.FirstOrDefaultAsync(x=>x.Id==request.Id,cancellationToken);
            if (foodComment==null)
            {
                throw new Exception("Not Found");
            }
            _context.Food_Comments.Update(foodComment);
            int response=await _context.SaveChangesAsync(cancellationToken);
            return response;
        }
    }
}
