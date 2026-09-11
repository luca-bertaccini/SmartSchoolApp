using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.AuthenticateUser
{
    public sealed class AuthenticateUserCommandHandler : IRequestHandler<AuthenticateUserCommand, Result<Guid>>
    {
        public AuthenticateUserCommandHandler()
        {
        }

        public Task<Result<Guid>> Handle(AuthenticateUserCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result<Guid>.Failure(Error.None));
        }
    }
}
