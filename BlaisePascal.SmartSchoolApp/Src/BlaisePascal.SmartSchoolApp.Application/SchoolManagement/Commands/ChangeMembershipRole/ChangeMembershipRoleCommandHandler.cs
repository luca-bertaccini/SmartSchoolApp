using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.SchoolManagement.Commands.ChangeMembershipRole
{
    public sealed class ChangeMembershipRoleCommandHandler : IRequestHandler<ChangeMembershipRoleCommand, Result<Guid>>
    {
        public ChangeMembershipRoleCommandHandler()
        {
        }

        public Task<Result<Guid>> Handle(ChangeMembershipRoleCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result<Guid>.Failure(Error.None)); 
        }
    }
}
