using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.SchoolManagement.Commands.ChangeMembershipRole
{
    public sealed record ChangeMembershipRoleCommand() : IRequest<Result<Guid>>;
}
