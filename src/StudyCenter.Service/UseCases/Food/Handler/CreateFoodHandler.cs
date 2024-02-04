using MediatR;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Food.Command;

namespace StudyCenter.Service.UseCases.Food.Handler
{
    public class CreateFoodHandler : IRequestHandler<CreateFoodCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateFoodHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateFoodCommand request, CancellationToken cancellationToken)
        {
            Foods? food = new Foods()
            {
                Name = request.Name,
                Food_Rate = request.Food_Rate,
                FoodCategory_id = request.FoodCategory_id,
            };

            await _context.Foods.AddAsync(food,cancellationToken);
            int response = await _context.SaveChangesAsync(cancellationToken);

            return response;
        }
    }
}
