using Serilog.Sinks.MSSqlServer;
using System;
using System.Collections.Generic;
using System.Data;

namespace Serilog.Services.CustomSerilog
{
    public class SerilogColumnOptions
    {
		public static ColumnOptions GetColumnOptions()
		{
			ColumnOptions columnOption = new ColumnOptions();

			// Remove all the StandardColumn
			columnOption.Store.Remove(StandardColumn.Properties);
			columnOption.Store.Remove(StandardColumn.MessageTemplate);
			columnOption.Store.Remove(StandardColumn.Message);
			columnOption.Store.Remove(StandardColumn.Exception);
			columnOption.Store.Remove(StandardColumn.TimeStamp);
			columnOption.Store.Remove(StandardColumn.Level);

			columnOption.Id.ColumnName = "LogId";

			columnOption.AdditionalDataColumns = new List<DataColumn>
			{
				new DataColumn {DataType = typeof(DateTime), ColumnName = "Timestamp"},
				new DataColumn {DataType = typeof(string), ColumnName = "Message"},
				new DataColumn {DataType = typeof(string), ColumnName = "Location"},
				new DataColumn {DataType = typeof(string), ColumnName = "CustomException"},
				new DataColumn {DataType = typeof(string), ColumnName = "Exception"},
				new DataColumn {DataType = typeof(string), ColumnName = "Hostname"},
				new DataColumn {DataType = typeof(string), ColumnName = "UserId"},
				new DataColumn {DataType = typeof(string), ColumnName = "UserName"},
				new DataColumn {DataType = typeof(string), ColumnName = "AdditionalInfo"},

			};

			return columnOption;
		}
	}
}
