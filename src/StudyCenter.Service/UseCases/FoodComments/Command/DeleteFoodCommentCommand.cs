using MediatR;

namespace StudyCenter.Service.UseCases.FoodComments.Command
{
    public class DeleteFoodCommentCommand:IRequest<int>
    {
        public int Id { get; set; } 
    }
}
