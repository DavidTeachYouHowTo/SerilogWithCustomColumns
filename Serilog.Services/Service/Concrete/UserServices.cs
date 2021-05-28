using Serilog.Events;
using Serilog.Services.Service.Abstract;
using System;

namespace Serilog.Services.Service.Concrete
{
    public class UserServices : IUserServices
    {
        private readonly ISerilogServices _serilogServices;
        public UserServices(ISerilogServices serilogServices)
        {
            _serilogServices = serilogServices;
        }
        public string GetUserMessage()
        {
            string message;
            try
            {
                message = "This implementation if for test the Serilog implementation. Make your own base on what you see in this project";
                _serilogServices.SetSerilogDetail(LogEventLevel.Information, "Testing Serilog implementation", "UserServices > GetUserMessage");
            }
            catch (Exception ex)
            {
                _serilogServices.SetSerilogDetail(LogEventLevel.Error, "Error while testing Serilog implementation", "UserServices > GetUserMessage", ex);
                throw;
            }

            return message;
        }
    }
}
