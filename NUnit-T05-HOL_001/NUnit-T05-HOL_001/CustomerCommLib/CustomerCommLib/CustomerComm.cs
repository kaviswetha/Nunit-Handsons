using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCommLib
{
    //Component class
    public class CustomerComm
    {
        IMailSender _mailSender;
        //Dependency injection to inject the interface under Component class
        public CustomerComm(IMailSender mailSender)
        {
            this._mailSender = mailSender;
        }

        public bool SendMailToCustomer()
        {
            _mailSender.SendMail("abcd@gmal.com", "Hallo User");
            return true;
        }
    }
}
