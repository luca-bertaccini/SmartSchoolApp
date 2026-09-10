using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.DeviceManagement.Commands.TurnDeviceOn
{
    public sealed record TurnDeviceOnCommand() : IRequest<Result<Guid>>;
}
