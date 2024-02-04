using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.FoodComments.Queries
{
    public class GetFoodCommentByIdQuery:IRequest<FoodComment>
    {
        public int Id { get; set; }
    }
}
