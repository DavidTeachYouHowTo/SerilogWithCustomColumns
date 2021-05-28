using Serilog.Events;
using Serilog.Services.CustomSerilog;
using Serilog.Services.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Serilog.Services.Service.Concrete
{
    public class SerilogServices : ISerilogServices
    {
        ISerilogWriteEventServices _serilogWriteEventServices;
        public SerilogServices(ISerilogWriteEventServices serilogWriteEventServices)
        {
            _serilogWriteEventServices = serilogWriteEventServices;
        }
        public void SetSerilogDetail(LogEventLevel logEventLevel, string message, string location, Exception ex = null)
        {
            var logInformation = new SerilogDetail()
            {
                LogEventLevel = logEventLevel,
                Timestamp = DateTime.Now,
                Message = message,
                UserId = "1",
                UserName = Environment.UserName, //Create your own logic to get the userId that is logged into the application
                Location = location,
                Hostname = Environment.MachineName, //Create your own logic to get the userName that is logged into the application
                Exception = ex,
            };

            var beginTime = DateTime.Now;
            logInformation.AdditionalInfo = new Dictionary<string, object>()
                {
                    { "Started", beginTime.ToString(CultureInfo.InvariantCulture)}
                };

            switch (logEventLevel)
            {
                case LogEventLevel.Information: { _serilogWriteEventServices.Information(logInformation); break; }
                case LogEventLevel.Debug: { _serilogWriteEventServices.Debug(logInformation); break; }
                case LogEventLevel.Warning: { _serilogWriteEventServices.Warning(logInformation); break; }
                case LogEventLevel.Verbose: { _serilogWriteEventServices.Verbose(logInformation); break; }
                case LogEventLevel.Error: { _serilogWriteEventServices.Error(logInformation); break; }
                case LogEventLevel.Fatal: { _serilogWriteEventServices.Fatal(logInformation); break; }                
                default:break;
            }            
        }
    }
}
