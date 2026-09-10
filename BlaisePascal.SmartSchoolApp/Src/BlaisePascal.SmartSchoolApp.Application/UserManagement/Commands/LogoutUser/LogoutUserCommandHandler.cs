using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.LogoutUser
{
    public sealed class LogoutUserCommandHandler : IRequestHandler<LogoutUserCommand, Result<Guid>>
    {
        public LogoutUserCommandHandler()
        {
        }

        public Task<Result<Guid>> Handle(LogoutUserCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result<Guid>.Failure(Error.None)); // Scaffold implementation
        }
    }
}
