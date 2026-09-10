using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlaisePascal.SmartSchoolApp.Application.DeviceManagement.Commands.TurnDeviceOn
{
    public sealed class TurnDeviceOnCommandHandler : IRequestHandler<TurnDeviceOnCommand, Result<Guid>>
    {
        public TurnDeviceOnCommandHandler()
        {
        }

        public Task<Result<Guid>> Handle(TurnDeviceOnCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result<Guid>.Failure(Error.None)); // Scaffold implementation
        }
    }
}
