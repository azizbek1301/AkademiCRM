using MediatR;
using StudyCenter.Domain.Dtos.Food_Category;

namespace StudyCenter.Service.UseCases.Food_Categories.Command
{
    public class UpdateFood_CategoryCommand:Food_CatUpdateDto,IRequest<int>
    {

    }
}
