using Serilog.Services.CustomSerilog.Helpers;
using System;
using System.Collections.Generic;
using Serilog.Events;

namespace Serilog.Services.CustomSerilog
{
    public class SerilogDetail
    {
        public DateTime Timestamp { get; set; }
        public string Message { get; set; }
        public string Location { get; set; }
        public string Hostname { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public LogEventLevel LogEventLevel { get; set; }
        public Exception Exception { get; set; }
        public CustomException CustomException { get; set; }
        public Dictionary<string, object> AdditionalInfo { get; set; }
    }
}
