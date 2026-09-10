using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.SchoolManagement.Commands.RemoveMemberFromSchool
{
    public sealed record RemoveMemberFromSchoolCommand() : IRequest<Result<Guid>>;
}
