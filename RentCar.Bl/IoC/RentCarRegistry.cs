using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using FluentValidation;
using RentCar.Bl.Services.Interfaces;
using RentCar.Bl.Services.Implementantions;
using System.Configuration;
using System.Net.Configuration;
using System.Net.Mail;
using System.Net;

namespace RentCar.Bl.IoC
{
    public class RentCarRegistry : Registry
    {
        public RentCarRegistry()
        {
            Scan(o =>
            {
                o.AssemblyContainingType<RentCarRegistry>();
                o.WithDefaultConventions();
            });

            AssemblyScanner.FindValidatorsInAssemblyContaining<Validators.VehicleValidator>()
            .ForEach(result =>
            {
                For(result.InterfaceType).Singleton().Use(result.ValidatorType);
            });


            AddSmsConfig();
            AddEmailConfig();
        }

        public void AddSmsConfig()
        {
            var Twilio_ACCOUNTSID = ConfigurationManager.AppSettings["Twilio_ACCOUNTSID"];
            var Twilio_AUTHTOKEN = ConfigurationManager.AppSettings["Twilio_AUTHTOKEN"];
            if (!string.IsNullOrEmpty(Twilio_ACCOUNTSID) && !string.IsNullOrEmpty(Twilio_AUTHTOKEN))
                For<ITwilioMessageSenderService>().Use<TwilioMessageSenderService>()
                                .Ctor<string>("accountSID").Is(Twilio_ACCOUNTSID)
                                .Ctor<string>("authToken").Is(Twilio_AUTHTOKEN);
        }

        public void AddEmailConfig()
        {
            SmtpSection section = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");

            if(section != null)
            {
                SmtpClient client = new SmtpClient(section.Network.Host, section.Network.Port)
                {
                    UseDefaultCredentials = section.Network.DefaultCredentials,
                    EnableSsl = section.Network.EnableSsl,
                    Credentials = new NetworkCredential(section.Network.UserName, section.Network.Password)
                };

                For<SmtpClient>().Use(client);
                ForConcreteType<MailMessage>().Configure.SelectConstructor(() => new MailMessage());
            }
        }
    }
}
