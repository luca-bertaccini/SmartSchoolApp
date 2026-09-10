using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlaisePascal.SmartSchoolApp.Application.DeviceManagement.Commands.UpdateDevice
{
    public sealed class UpdateDeviceCommandHandler : IRequestHandler<UpdateDeviceCommand, Result<Guid>>
    {
        public UpdateDeviceCommandHandler()
        {
        }

        public Task<Result<Guid>> Handle(UpdateDeviceCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result<Guid>.Failure(Error.None)); // Scaffold implementation
        }
    }
}
