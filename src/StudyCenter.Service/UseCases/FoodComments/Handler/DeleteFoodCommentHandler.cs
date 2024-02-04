using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.FoodComments.Command;

namespace StudyCenter.Service.UseCases.FoodComments.Handler
{
    public class DeleteFoodCommentHandler : IRequestHandler<DeleteFoodCommentCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public DeleteFoodCommentHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteFoodCommentCommand request, CancellationToken cancellationToken)
        {
            FoodComment? foodComment=await _context.Food_Comments.FirstOrDefaultAsync(x=>x.Id == request.Id,cancellationToken);
            if (foodComment == null)
            {
                throw new Exception("Not Found");
            }
            _context.Food_Comments.Remove(foodComment);
            int response = await _context.SaveChangesAsync(cancellationToken);
            return response;
        }
    }
}
