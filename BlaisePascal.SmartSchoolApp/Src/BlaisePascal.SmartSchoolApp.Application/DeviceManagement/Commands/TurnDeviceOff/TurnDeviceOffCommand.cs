using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.DeviceManagement.Commands.TurnDeviceOff
{
    public sealed record TurnDeviceOffCommand() : IRequest<Result<Guid>>;
}
