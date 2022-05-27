﻿using Application.Repositories;
using Application.Services;
using Application.UnitOfWork;

namespace Infrastructure.Services.Implementations;

public class StudentServiceService : CommonIdentityService<Domain.Models.StudentService>, IStudentService
{
    private readonly IUnitOfWork _unitOfWork;
    public StudentServiceService(ICommonIdentityRepository<Domain.Models.StudentService> repository, IUnitOfWork unitOfWork) : base(repository)
    {
        _unitOfWork = unitOfWork;
    }
}