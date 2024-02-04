using MediatR;
using StudyCenter.Domain.Dtos.Foods;

namespace StudyCenter.Service.UseCases.Food.Command
{
    public class UpdateFoodCommand:FoodsUpdateDto,IRequest<int>
    {
    }
}
