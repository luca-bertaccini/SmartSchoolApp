using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlaisePascal.SmartSchoolApp.Application.DeviceManagement.Commands.TurnDeviceOff
{
    public sealed class TurnDeviceOffCommandHandler : IRequestHandler<TurnDeviceOffCommand, Result<Guid>>
    {
        public TurnDeviceOffCommandHandler()
        {
        }

        public Task<Result<Guid>> Handle(TurnDeviceOffCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result<Guid>.Failure(Error.None)); // Scaffold implementation
        }
    }
}
