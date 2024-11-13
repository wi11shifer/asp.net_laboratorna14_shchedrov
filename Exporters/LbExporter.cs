using OpenTelemetry;
using OpenTelemetry.Trace;
using System.Diagnostics;

namespace asp.net_laboratorna14_shchedrov.Exporters
{
    public class LbExporter : BaseExporter<Activity>
    {
        public override ExportResult Export(in Batch<Activity> batch)
        {
            foreach (var activity in batch)
            {
                Console.WriteLine("Hello!");
                Console.WriteLine($"Exporting activity: {activity.DisplayName} with ID: {activity.TraceId}");
            }
            return ExportResult.Success;
        }
    }
}
