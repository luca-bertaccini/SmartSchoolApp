using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.DeviceManagement.Commands.UpdateDevice
{
    public sealed record UpdateDeviceCommand() : IRequest<Result<Guid>>;
}
