using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.DeviceManagement.Commands.AddDevice
{
    public sealed record AddDeviceCommand() : IRequest<Result<Guid>>;
}
