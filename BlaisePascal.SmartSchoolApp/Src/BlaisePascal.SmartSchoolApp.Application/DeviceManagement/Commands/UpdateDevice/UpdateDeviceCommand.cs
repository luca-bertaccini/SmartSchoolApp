using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.DeviceManagement.Commands.UpdateDevice
{
    public sealed record UpdateDeviceCommand() : IRequest<Result<Guid>>;
}
