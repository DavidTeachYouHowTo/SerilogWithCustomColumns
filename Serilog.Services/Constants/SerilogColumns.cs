using System;
using System.Collections.Generic;
using System.Text;

namespace Serilog.Services.Constants
{
    public static class SerilogColumns
    {
        public const string SERILOG_COLUMNS = "{LogEventLevel}{Timestamp}{Message}{Location}{CustomException}{Exception}{Hostname}{UserId}{UserName}{AdditionalInfo}";
    }
}
