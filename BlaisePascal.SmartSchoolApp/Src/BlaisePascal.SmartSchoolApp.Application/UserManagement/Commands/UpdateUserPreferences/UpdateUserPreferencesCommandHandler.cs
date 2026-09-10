using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlaisePascal.SmartSchoolApp.Application.UserManagement.Commands.UpdateUserPreferences
{
    public sealed class UpdateUserPreferencesCommandHandler : IRequestHandler<UpdateUserPreferencesCommand, Result<Guid>>
    {
        public UpdateUserPreferencesCommandHandler()
        {
        }

        public Task<Result<Guid>> Handle(UpdateUserPreferencesCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result<Guid>.Failure(Error.None)); // Scaffold implementation
        }
    }
}
