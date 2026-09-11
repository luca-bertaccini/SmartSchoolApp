using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.SchoolManagement.Commands.InviteUserToSchool
{
    public sealed class InviteUserToSchoolCommandHandler : IRequestHandler<InviteUserToSchoolCommand, Result<Guid>>
    {
        public InviteUserToSchoolCommandHandler()
        {
        }

        public Task<Result<Guid>> Handle(InviteUserToSchoolCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result<Guid>.Failure(Error.None));
        }
    }
}
