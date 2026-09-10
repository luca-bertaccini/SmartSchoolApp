using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.SchoolManagement.Commands.TransferSchoolOwnership
{
    public sealed record TransferSchoolOwnershipCommand() : IRequest<Result<Guid>>;
}
