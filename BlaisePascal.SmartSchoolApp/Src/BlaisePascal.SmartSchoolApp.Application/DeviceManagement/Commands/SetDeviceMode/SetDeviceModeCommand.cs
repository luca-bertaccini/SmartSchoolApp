using MediatR;
using System;

namespace BlaisePascal.SmartSchoolApp.Application.DeviceManagement.Commands.SetDeviceMode
{
    public sealed record SetDeviceModeCommand() : IRequest<Result<Guid>>;
}
