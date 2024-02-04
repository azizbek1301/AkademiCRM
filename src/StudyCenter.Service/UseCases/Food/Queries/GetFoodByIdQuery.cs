using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.Food.Queries
{
    public class GetFoodByIdQuery:IRequest<Foods>
    {
        public int Id {  get; set; }

    }
}
