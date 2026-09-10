using BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.RegisterUser;
using BlaisePascal.SmartSchoolApp.Domain.UserManagement.Repository;
using BlaisePascal.SmartSchoolApp.SharedKernel;
using Domain.UserManagement;
using Domain.ValueObject;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, Result<Guid>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher; 

        public RegisterUserCommandHandler(
            IUserRepository userRepository,
            IPasswordHasher passwordHasher) 
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
        }

        public Task<Result<Guid>> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var existingUserResult = _userRepository.GetByEmail(request.email);
            if (existingUserResult.IsSuccess)
            {
                return Task.FromResult(Result<Guid>.Failure(
                    Error.Conflict("User.DuplicateEmail", "L'email inserita è già registrata.")
                ));
            }

            var hashResult = _passwordHasher.Hash(request.plainPassword);
            if (hashResult.IsFailure)
            {
                return Task.FromResult(Result<Guid>.Failure(hashResult.Error));
            }

            var email = new Email(request.email);
            var zoneTime = new ZoneTime(request.timezone);
            var locale = new Locale(request.locale);
            var passwordHash = PasswordHash.Create(hashResult.Value);

            var user = new User(zoneTime, email, locale, passwordHash);

            var addResult = _userRepository.Add(user);
            if (addResult.IsFailure)
            {
                return Task.FromResult(Result<Guid>.Failure(addResult.Error));
            }

            return Task.FromResult(Result<Guid>.Success(user.UserId));
        }
    }
}