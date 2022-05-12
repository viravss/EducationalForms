using Application.Repositories;
using Application.Services;
using Application.UnitOfWork;
using Domain.Models;

namespace Infrastructure.Services.Implementations;

public class StudentService : CommonService<Student>, IStudentService
{
    private readonly IUnitOfWork _unitOfWork;
    public StudentService(ICommonRepository<Student> repository, IUnitOfWork unitOfWork) : base(repository)
    {
        _unitOfWork = unitOfWork;
    }
}