using Serilog.Services.Constants;
using Serilog.Services.CustomSerilog;
using Serilog.Services.Service.Abstract;

namespace Serilog.Services.Service.Concrete
{
    public class SerilogWriteEventServices : ISerilogWriteEventServices
    {
        public void Debug(SerilogDetail serilogDetail)
        {
			Log.Debug(SerilogColumns.SERILOG_COLUMNS,
							serilogDetail.LogEventLevel,
							serilogDetail.Timestamp,
							serilogDetail.Message,
							serilogDetail.Location,
							serilogDetail.CustomException,
							serilogDetail.Exception?.ToString(),
							serilogDetail.Hostname,
							serilogDetail.UserId,
							serilogDetail.UserName,
							serilogDetail.AdditionalInfo);
		}

        public void Error(SerilogDetail serilogDetail)
        {
			Log.Error(SerilogColumns.SERILOG_COLUMNS,
							serilogDetail.LogEventLevel,
							serilogDetail.Timestamp,
							serilogDetail.Message,
							serilogDetail.Location,
							serilogDetail.CustomException,
							serilogDetail.Exception?.ToString(),
							serilogDetail.Hostname,
							serilogDetail.UserId,
							serilogDetail.UserName,
							serilogDetail.AdditionalInfo);
		}

        public void Fatal(SerilogDetail serilogDetail)
        {
			Log.Fatal(SerilogColumns.SERILOG_COLUMNS,
							serilogDetail.LogEventLevel,
							serilogDetail.Timestamp,
							serilogDetail.Message,
							serilogDetail.Location,
							serilogDetail.CustomException,
							serilogDetail.Exception?.ToString(),
							serilogDetail.Hostname,
							serilogDetail.UserId,
							serilogDetail.UserName,
							serilogDetail.AdditionalInfo);
		}

        public void Information(SerilogDetail serilogDetail)
        {
			Log.Information(SerilogColumns.SERILOG_COLUMNS,
							serilogDetail.LogEventLevel,
							serilogDetail.Timestamp,
							serilogDetail.Message,
							serilogDetail.Location,
							serilogDetail.CustomException,
							serilogDetail.Exception?.ToString(),
							serilogDetail.Hostname,
							serilogDetail.UserId,
							serilogDetail.UserName,
							serilogDetail.AdditionalInfo);
		}

        public void Verbose(SerilogDetail serilogDetail)
        {
			Log.Verbose(SerilogColumns.SERILOG_COLUMNS,
							serilogDetail.LogEventLevel,
							serilogDetail.Timestamp,
							serilogDetail.Message,
							serilogDetail.Location,
							serilogDetail.CustomException,
							serilogDetail.Exception?.ToString(),
							serilogDetail.Hostname,
							serilogDetail.UserId,
							serilogDetail.UserName,
							serilogDetail.AdditionalInfo);
		}

        public void Warning(SerilogDetail serilogDetail)
        {
			Log.Warning(SerilogColumns.SERILOG_COLUMNS,
							serilogDetail.LogEventLevel,
							serilogDetail.Timestamp,
							serilogDetail.Message,
							serilogDetail.Location,
							serilogDetail.CustomException,
							serilogDetail.Exception?.ToString(),
							serilogDetail.Hostname,
							serilogDetail.UserId,
							serilogDetail.UserName,
							serilogDetail.AdditionalInfo);
		}
    }
}
