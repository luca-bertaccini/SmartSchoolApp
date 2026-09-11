using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.DeviceManagement.Commands.SetDeviceMode
{
    public sealed record SetDeviceModeCommand() : IRequest<Result<Guid>>;
}
