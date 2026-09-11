using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.SchoolManagement.Commands.InviteUserToSchool
{
    public sealed record InviteUserToSchoolCommand() : IRequest<Result<Guid>>;
}
