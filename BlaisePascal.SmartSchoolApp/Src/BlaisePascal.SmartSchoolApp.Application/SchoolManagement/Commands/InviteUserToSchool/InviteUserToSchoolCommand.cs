using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.SchoolManagement.Commands.InviteUserToSchool
{
    public sealed record InviteUserToSchoolCommand() : IRequest<Result<Guid>>;
}
