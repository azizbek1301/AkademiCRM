using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.Food_Categories.Queries
{
    public class GetAllFood_CategoryQuery : IRequest<List<Food_Category>>
    {

    }
}
