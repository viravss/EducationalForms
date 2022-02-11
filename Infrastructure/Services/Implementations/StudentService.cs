using Application.Repositories;
using Application.Services;
using Application.UnitOfWork;
using Domain.Models;

namespace Infrastructure.Services.Implementations;

public class StudentService : GenericService<Student>, IStudentService
{
    private readonly IUnitOfWork _unitOfWork;
    public StudentService(IGenericRepository<Student> repository, IUnitOfWork unitOfWork) : base(repository)
    {
        _unitOfWork = unitOfWork;
    }
}