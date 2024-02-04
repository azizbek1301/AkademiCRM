using MediatR;
using StudyCenter.Domain.Dtos.FoodComment;

namespace StudyCenter.Service.UseCases.FoodComments.Command
{
    public class UpdateFoodCommentCommand : FoodCommentUpdateDto, IRequest<int>
    {
    }
}
