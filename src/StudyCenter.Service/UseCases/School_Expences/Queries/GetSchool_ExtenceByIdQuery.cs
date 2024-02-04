using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.School_Expences.Queries
{
    public class GetSchool_ExtenceByIdQuery:IRequest<School_Expence>
    {
        public int Id { get; set; } 
    }
}
