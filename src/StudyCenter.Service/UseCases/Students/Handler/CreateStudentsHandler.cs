using MediatR;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.Abstraction.File;
using StudyCenter.Service.UseCases.Students.Command;

namespace StudyCenter.Service.UseCases.Students.Handler
{
    public class CreateStudentshandler : IRequestHandler<CreateStudentCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IFileService _fileService;

        public CreateStudentshandler(IApplicationDbContext context, IFileService fileService)
        {
            _context = context;
            _fileService = fileService;
        }

        public async Task<int> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var res = new Student()
            {
                FullName = request.FullName,
                StartDate = DateTime.UtcNow,
                ParentName= request.ParentName,
                Grade= request.Grade,
                Address= request.Address,   
                Email= request.Email,
                PhoneNumber= request.PhoneNumber,
                ImageUrl=await _fileService.UploadImageAsync(request.ImageUrl),

            };
            await _context.Students.AddAsync(res, cancellationToken);
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
