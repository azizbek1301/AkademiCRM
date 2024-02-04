using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Food.Command;

namespace StudyCenter.Service.UseCases.Food.Handler
{
    public class UpdateFoodHandler : IRequestHandler<UpdateFoodCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public UpdateFoodHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateFoodCommand request, CancellationToken cancellationToken)
        {
            Foods? food = await _context.Foods.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (food == null)
            {
                throw new Exception("Not Found");
            }
            food.Name = request.Name;
            food.Food_Rate = request.Food_Rate;
            food.FoodCategory_id = request.FoodCategory_id;

            _context.Foods.Update(food);
            int respons=await _context.SaveChangesAsync(cancellationToken);
            return respons; 
        }

    }
}
