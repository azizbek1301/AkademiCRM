using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Food_Categories.Command;

namespace StudyCenter.Service.UseCases.Food_Categories.Handler
{
    public class UpdateFood_CategoryHandler : IRequestHandler<UpdateFood_CategoryCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public UpdateFood_CategoryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateFood_CategoryCommand request, CancellationToken cancellationToken)
        {
            var food_category=await _context.Food_Categories.FirstOrDefaultAsync(x=>x.Id==request.Id,cancellationToken);
            if (food_category == null)
            {
                throw new Exception("not Found");
            }
            food_category.Name = request.Name;
            _context.Food_Categories.Update(food_category);

            int response=await _context.SaveChangesAsync(cancellationToken);
            return response;
        }
    }
}
