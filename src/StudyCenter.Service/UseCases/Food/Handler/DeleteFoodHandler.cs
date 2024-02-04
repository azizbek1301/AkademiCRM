using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Food.Command;

namespace StudyCenter.Service.UseCases.Food.Handler
{
    public class DeleteFoodHandler : IRequestHandler<DeleteFoodCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public DeleteFoodHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteFoodCommand request, CancellationToken cancellationToken)
        {
            Foods? foods=await _context.Foods.FirstOrDefaultAsync(x=>x.Id==request.Id,cancellationToken);
            if (foods == null)
                throw new Exception("Not Found");
            _context.Foods.Remove(foods);
            int response=await _context.SaveChangesAsync(cancellationToken);
            return response;
        }
    }
}
