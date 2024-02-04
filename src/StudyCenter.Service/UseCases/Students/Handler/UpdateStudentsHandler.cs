using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.Abstraction.File;
using StudyCenter.Service.UseCases.Students.Command;

namespace StudyCenter.Service.UseCases.Students.Handler
{
    public class UpdateStudentsHandler : IRequestHandler<UpdateStudentsCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IFileService _fileService;

        public UpdateStudentsHandler(IApplicationDbContext context, IFileService fileService)
        {
            _context = context;
            _fileService = fileService;
        }

        public async Task<int> Handle(UpdateStudentsCommand request, CancellationToken cancellationToken)
        {
            Student? student=await _context.Students.FirstOrDefaultAsync(x => x.Id == request.Id,cancellationToken);
            if (student==null)
            {
                throw new Exception("Not Found");
          
            }

            student.FullName = request.FullName;
            student.PhoneNumber= request.PhoneNumber;
            student.Email= request.Email;   
            student.Address= request.Address;
            student.ParentName= request.ParentName;
            student.Grade= request.Grade;
            
            if(student.ImageUrl!=null)
            {
                await _fileService.DeleteImageAsync(student.ImageUrl);
                student.ImageUrl = await _fileService.UploadImageAsync(request.ImageUrl);
            }
            _context.Students.Update(student);
            return await _context.SaveChangesAsync(cancellationToken);

        }
    }
}
