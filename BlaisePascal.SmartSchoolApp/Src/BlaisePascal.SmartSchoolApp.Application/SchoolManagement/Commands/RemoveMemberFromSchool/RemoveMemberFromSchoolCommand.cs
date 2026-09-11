using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.SchoolManagement.Commands.RemoveMemberFromSchool
{
    public sealed record RemoveMemberFromSchoolCommand() : IRequest<Result<Guid>>;
}
