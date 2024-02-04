using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Food.Queries;

namespace StudyCenter.Service.UseCases.Food.Handler
{
    public class GetFoodByIdHandler : IRequestHandler<GetFoodByIdQuery, Foods>
    {
        private readonly IApplicationDbContext _context;

        public GetFoodByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Foods> Handle(GetFoodByIdQuery request,CancellationToken cancellationToken)
        {
            Foods? food = await _context.Foods.FirstOrDefaultAsync(x=>x.Id == request.Id,cancellationToken);
            if(food == null)
            {
                throw new Exception("Not Found");
            }
            return food;
        }
        
    }
}
