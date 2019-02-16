using RentCar.Bl.Services.Interfaces;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Bl.Services.Implementantions
{
    public class EmailMessageSenderService : IEmailMessageSenderService
    {
        private readonly SmtpClient _smtpClient;
        private readonly MailMessage _mailMessage;

        public EmailMessageSenderService(SmtpClient smtpClient, 
                                        MailMessage mailMessage)    
        {
            _smtpClient = smtpClient; 
            _mailMessage = mailMessage;
        }

        public void Add(string to)
        {
            _mailMessage.To.Add(to);
        }

        public void Add(ICollection<string> to)
        {
            foreach (var address in to)
            {
                _mailMessage.To.Add(address);
            }
        }

        public void SetMailMessage(string subject, string message, params string[] to)    
        {
            var HtmlView = ReadTemplateFile();

            HtmlView = HtmlView.Replace("{{SUBJECT}}", subject);
            HtmlView = HtmlView.Replace("{{BODY}}", message);

            Add(to);
            _mailMessage.Subject = subject;
            _mailMessage.Body = HtmlView;
            _mailMessage.IsBodyHtml = true;
        }

        public async Task<bool> SendMessage()
        {
            try
            {
                _smtpClient.Timeout = 120;
                await _smtpClient.SendMailAsync(_mailMessage);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> SendMessage(string subject, string message, params string[] to)
        {
            SetMailMessage(subject, message, to);
            return await SendMessage();
        }

        private string ReadTemplateFile(string templatePath = null)
        {
            templatePath = templatePath ?? ConfigurationManager.AppSettings["templateEmailPath"];

            string rootDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format(@"..{0}..{0}", Path.DirectorySeparatorChar));
            string fileSystemPath = Path.Combine(rootDir, templatePath);
            if (File.Exists(fileSystemPath))
                return File.ReadAllText(fileSystemPath);

            return string.Empty;
        }

    }
}
