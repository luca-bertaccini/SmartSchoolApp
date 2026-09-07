using System;
using System.Collections.Generic;

namespace Domain.ValueObject
{
    public record Metrics(
        double TotalConsumption, 
        double AverageUsage, 
        double PeakUsage, 
        IReadOnlyDictionary<Guid, double> DeviceBreakdown
    );
}
