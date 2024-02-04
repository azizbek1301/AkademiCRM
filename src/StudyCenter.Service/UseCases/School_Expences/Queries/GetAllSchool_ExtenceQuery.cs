using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.School_Expences.Queries
{
    public class GetAllSchool_ExtenceQuery:IRequest<List<School_Expence>>
    {
    }
}
