using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.SchoolManagement.Commands.TransferSchoolOwnership
{
    public sealed record TransferSchoolOwnershipCommand() : IRequest<Result<Guid>>;
}
