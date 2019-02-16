using RentCar.Bl.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace RentCar.Bl.Services.Implementantions
{
    public class TwilioMessageSenderService : ITwilioMessageSenderService
    {
        public TwilioMessageSenderService()
        {
        }

        public TwilioMessageSenderService(string accountSID, string authToken)
        {
            TwilioClient.Init(accountSID, authToken);
        }

        public void Init(string accountSID, string authToken)
        {
            TwilioClient.Init(accountSID, authToken);
        }

        public async Task<MessageResource> SendMessageAsync(string to, string from, string body)
        {
           return await MessageResource.CreateAsync(
                                              to: new PhoneNumber(to),
                                              from: new PhoneNumber(from),
                                              body: body);
        }
    }
}
