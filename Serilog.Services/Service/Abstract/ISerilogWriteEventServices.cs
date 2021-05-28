using Serilog.Services.CustomSerilog;

namespace Serilog.Services.Service.Abstract
{
    public interface ISerilogWriteEventServices
    {
        void Information(SerilogDetail serilogDetail);
        void Verbose(SerilogDetail serilogDetail);
        void Debug(SerilogDetail serilogDetail);
        void Error(SerilogDetail serilogDetail);
        void Warning(SerilogDetail serilogDetail);
        void Fatal(SerilogDetail serilogDetail);
    }
}
