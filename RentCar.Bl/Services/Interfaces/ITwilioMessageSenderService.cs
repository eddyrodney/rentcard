using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Rest.Api.V2010.Account;

namespace RentCar.Bl.Services.Interfaces
{
    public interface ITwilioMessageSenderService
    {
        Task<MessageResource> SendMessageAsync(string to, string from, string body);
        void Init(string accountSID, string authToken);
    }
}
