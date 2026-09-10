using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlaisePascal.SmartSchoolApp.Application.DeviceManagement.Commands.AddDevice
{
    public sealed class AddDeviceCommandHandler : IRequestHandler<AddDeviceCommand, Result<Guid>>
    {
        public AddDeviceCommandHandler()
        {
        }

        public Task<Result<Guid>> Handle(AddDeviceCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result<Guid>.Failure(Error.None)); // Scaffold implementation
        }
    }
}
