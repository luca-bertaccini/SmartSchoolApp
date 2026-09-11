using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.DeviceManagement.Commands.RemoveDevice
{
    public sealed class RemoveDeviceCommandHandler : IRequestHandler<RemoveDeviceCommand, Result<Guid>>
    {
        public RemoveDeviceCommandHandler()
        {
        }

        public Task<Result<Guid>> Handle(RemoveDeviceCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result<Guid>.Failure(Error.None)); 
        }
    }
}
