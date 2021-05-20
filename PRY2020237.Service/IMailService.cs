using PRY2020237.Entity.Settings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRY2020237.Service
{
    public interface IMailService
    {
        void SendEmailRecoveryPassword(MailParameter mail);
        void SendEmail(MailRequest mailRequest);
    }
}
