using BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.RegisterUser;
using BlaisePascal.SmartSchoolApp.Domain.UserManagement;
using BlaisePascal.SmartSchoolApp.Domain.UserManagement.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.VerifyPassword
{
    public class VerifyPasswordCommandHandler : IRequestHandler<VerifyPasswordCommand, Result>
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;

        public VerifyPasswordCommandHandler(
            IUserRepository userRepository,
            IPasswordHasher passwordHasher)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
        }

        public Task<Result> Handle(VerifyPasswordCommand request, CancellationToken cancellationToken)
        {
            var userResult = _userRepository.GetById(request.userId);
            if (userResult.IsFailure)
            {
                return Task.FromResult(Result.Failure(userResult.Error));
            }

            var user = userResult.Value;

            var verifyResult = user.VerifyPassword(request.password, _passwordHasher);
            if (verifyResult.IsFailure)
            {
                return Task.FromResult(verifyResult);
            }

            return Task.FromResult(Result.Success());
        }
    }
}

