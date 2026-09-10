using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.DeviceManagement.Commands.RemoveDevice
{
    public sealed record RemoveDeviceCommand() : IRequest<Result<Guid>>;
}
