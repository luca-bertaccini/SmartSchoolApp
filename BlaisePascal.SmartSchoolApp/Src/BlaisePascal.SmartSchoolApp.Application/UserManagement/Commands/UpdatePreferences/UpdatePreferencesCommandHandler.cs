using BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.VerifyPassword;
using BlaisePascal.SmartSchoolApp.Domain.UserManagement.Repository;
using Domain.ValueObject;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.UpdatePreferences
{
    public class UpdatePreferencesCommandHandler : IRequestHandler<UpdatePreferencesCommand, Result>
    {
        private readonly IUserRepository _userRepository;

        public UpdatePreferencesCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<Result> Handle(UpdatePreferencesCommand request, CancellationToken cancellationToken)
        {
            var userResult = _userRepository.GetById(request.userId);
            if (userResult.IsFailure)
            {
                return Task.FromResult(Result.Failure(userResult.Error));
            }

            var user = userResult.Value;

            var updateResult = user.UpdatePreferences(request.zoneTime, request.locale);
            if (updateResult.IsFailure)
            {
                return Task.FromResult(updateResult);
            }

            return Task.FromResult(Result.Success());
        }
    }
}
