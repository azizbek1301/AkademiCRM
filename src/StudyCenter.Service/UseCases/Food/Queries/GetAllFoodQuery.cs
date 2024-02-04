using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.Food.Queries
{
    public class GetAllFoodQuery:IRequest<List<Foods>>
    {

    }
}
