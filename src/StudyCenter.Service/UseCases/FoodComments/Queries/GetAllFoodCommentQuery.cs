using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.FoodComments.Queries
{
    public class GetAllFoodCommentQuery:IRequest<List<FoodComment>>
    {
    }
}
