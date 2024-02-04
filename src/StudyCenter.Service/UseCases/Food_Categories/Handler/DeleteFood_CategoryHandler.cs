using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Food_Categories.Command;

namespace StudyCenter.Service.UseCases.Food_Categories.Handler
{
    public class DeleteFood_CategoryHandler : IRequestHandler<DeleteFood_CategoryCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public DeleteFood_CategoryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteFood_CategoryCommand request, CancellationToken cancellationToken)
        {
            Food_Category? food_category = await _context.Food_Categories.FirstOrDefaultAsync(x=>x.Id==request.Id,cancellationToken);  
            if(food_category == null)
            {
                throw new Exception("Not Found");
            }
            _context.Food_Categories.Remove(food_category);
            int response=await _context.SaveChangesAsync(cancellationToken);

            return response;
        }
    }
}
