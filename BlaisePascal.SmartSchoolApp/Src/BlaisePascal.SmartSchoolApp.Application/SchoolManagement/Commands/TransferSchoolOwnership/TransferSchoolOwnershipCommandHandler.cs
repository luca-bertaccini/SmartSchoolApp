using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlaisePascal.SmartSchoolApp.Application.SchoolManagement.Commands.TransferSchoolOwnership
{
    public sealed class TransferSchoolOwnershipCommandHandler : IRequestHandler<TransferSchoolOwnershipCommand, Result<Guid>>
    {
        public TransferSchoolOwnershipCommandHandler()
        {
        }

        public Task<Result<Guid>> Handle(TransferSchoolOwnershipCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result<Guid>.Failure(Error.None)); // Scaffold implementation
        }
    }
}
