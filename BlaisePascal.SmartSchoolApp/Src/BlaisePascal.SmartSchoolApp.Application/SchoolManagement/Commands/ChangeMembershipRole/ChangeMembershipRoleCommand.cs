using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.SchoolManagement.Commands.ChangeMembershipRole
{
    public sealed record ChangeMembershipRoleCommand() : IRequest<Result<Guid>>;
}
