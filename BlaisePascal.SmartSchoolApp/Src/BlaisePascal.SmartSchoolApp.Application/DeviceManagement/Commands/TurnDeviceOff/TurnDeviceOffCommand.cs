using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.DeviceManagement.Commands.TurnDeviceOff
{
    public sealed record TurnDeviceOffCommand() : IRequest<Result<Guid>>;
}
