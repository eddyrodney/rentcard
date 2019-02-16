using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Bl.Services.Interfaces
{
    public interface IEmailMessageSenderService
    {
        void Add(string to);
        void Add(ICollection<string> to);
        void SetMailMessage(string subject, string message, params string[] to);
        Task<bool> SendMessage(string subject, string message, params string[] to);
        Task<bool> SendMessage();
    }
}
