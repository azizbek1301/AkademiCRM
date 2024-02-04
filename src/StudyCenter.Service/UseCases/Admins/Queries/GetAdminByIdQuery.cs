using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.Admins.Queries
{
    public class GetAdminByIdQuery : IRequest<Admin>
    {
        public int AdminId { get; set; }
    }
}
