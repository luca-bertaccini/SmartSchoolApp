using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.SchoolManagement.Commands.CreateSchool
{
    public sealed record CreateSchoolCommand() : IRequest<Result<Guid>>;
}
