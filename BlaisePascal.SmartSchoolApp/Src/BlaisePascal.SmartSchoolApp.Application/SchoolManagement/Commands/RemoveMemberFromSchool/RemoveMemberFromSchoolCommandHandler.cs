using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.SchoolManagement.Commands.RemoveMemberFromSchool
{
    public sealed class RemoveMemberFromSchoolCommandHandler : IRequestHandler<RemoveMemberFromSchoolCommand, Result<Guid>>
    {
        public RemoveMemberFromSchoolCommandHandler()
        {
        }

        public Task<Result<Guid>> Handle(RemoveMemberFromSchoolCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result<Guid>.Failure(Error.None));
        }
    }
}
