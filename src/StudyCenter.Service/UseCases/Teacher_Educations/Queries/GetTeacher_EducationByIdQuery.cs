using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.Teacher_Educations.Queries
{
    public class GetTeacher_EducationByIdQuery : IRequest<Teacher_Education>
    {
        public int Id { get; set; }
    }
}
