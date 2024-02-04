using MediatR;

namespace StudyCenter.Service.UseCases.Food.Command
{
    public class DeleteFoodCommand:IRequest<int>
    {
        public int Id { get; set; } 
    }
}
