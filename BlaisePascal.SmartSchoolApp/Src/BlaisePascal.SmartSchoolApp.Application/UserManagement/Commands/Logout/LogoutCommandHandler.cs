using BlaisePascal.SmartSchoolApp.Domain.UserManagement.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.Logout
{
    public class LogoutUserCommandHandler : IRequestHandler<LogoutUserCommand, Result>
    {
        private readonly IUserRepository _userRepository;

        public LogoutUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<Result> Handle(LogoutUserCommand request, CancellationToken cancellationToken)
        {
            var userResult = _userRepository.GetById(request.userId);
            if (userResult.IsFailure)
            {
                return Task.FromResult(Result.Failure(userResult.Error));
            }

            var user = userResult.Value;

            var logoutResult = user.Logout();
            if (logoutResult.IsFailure)
            {
                return Task.FromResult(logoutResult);
            }

            return Task.FromResult(Result.Success());
        }
    }
}
