using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire.Web.Services
{
    public class EmailSender : IEmailSender
    {
        public Task Sender(string userId, string message)
        {
            throw new NotImplementedException();
        }
    }
}
