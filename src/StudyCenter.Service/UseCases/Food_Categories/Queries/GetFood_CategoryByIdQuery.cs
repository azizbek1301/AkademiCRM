using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.Food_Categories.Queries
{
    public class GetFood_CategoryByIdQuery:IRequest<Food_Category>
    {
        public int Id { get; set; } 
    }
}
