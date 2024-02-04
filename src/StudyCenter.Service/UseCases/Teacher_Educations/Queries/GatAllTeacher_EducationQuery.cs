using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.Teacher_Educations.Queries
{
    public class GatAllTeacher_EducationQuery : IRequest<List<Teacher_Education>>
    {
    }
}
