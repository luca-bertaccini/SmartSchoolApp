using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.DeviceManagement.Commands.TurnDeviceOn
{
    public sealed record TurnDeviceOnCommand() : IRequest<Result<Guid>>;
}
