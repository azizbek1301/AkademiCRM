using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.Admins.Queries
{
    public class GetAllAdminQuery : IRequest<List<Admin>>
    {
    }
}
