using Serilog.Events;
using System;

namespace Serilog.Services.Service.Abstract
{
    public interface ISerilogServices
    {
        void SetSerilogDetail(LogEventLevel logEventLevel, string message, string location, Exception ex = null);
    }
}
