using MediatR;
using System;
using BlaisePascal.SmartSchoolApp.SharedKernel;

namespace BlaisePascal.SmartSchoolApp.Application.DeviceManagement.Commands.RemoveDevice
{
    public sealed record RemoveDeviceCommand() : IRequest<Result<Guid>>;
}
