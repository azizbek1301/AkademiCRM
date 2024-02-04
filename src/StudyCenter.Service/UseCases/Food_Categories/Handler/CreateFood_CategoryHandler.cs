using MediatR;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Food_Categories.Command;

namespace StudyCenter.Service.UseCases.Food_Categories.Handler
{
    public class CreateFood_CategoryHandler : IRequestHandler<CreateFood_CategoryCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateFood_CategoryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateFood_CategoryCommand request, CancellationToken cancellationToken)
        {
            Food_Category? food_category = new Food_Category()
            {
                Name = request.Name,    
                
            };
            await _context.Food_Categories.AddAsync(food_category,cancellationToken);
            int response=await _context.SaveChangesAsync(cancellationToken);
            return response;
        }
    }
}
