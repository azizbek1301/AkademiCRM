using MediatR;
using StudyCenter.Domain.Dtos.Food_Category;

namespace StudyCenter.Service.UseCases.Food_Categories.Command
{
    public class CreateFood_CategoryCommand:Food_CatCreateDto,IRequest<int>
    {
    }
}
