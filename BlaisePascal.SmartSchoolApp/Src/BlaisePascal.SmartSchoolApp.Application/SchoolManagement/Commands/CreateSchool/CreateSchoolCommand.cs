using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.SchoolManagement.Commands.CreateSchool
{
    public sealed record CreateSchoolCommand() : IRequest<Result<Guid>>;
}
