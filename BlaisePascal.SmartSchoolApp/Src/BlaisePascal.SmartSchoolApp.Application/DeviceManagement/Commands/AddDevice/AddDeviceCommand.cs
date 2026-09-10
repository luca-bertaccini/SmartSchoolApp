using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.DeviceManagement.Commands.AddDevice
{
    public sealed record AddDeviceCommand() : IRequest<Result<Guid>>;
}
