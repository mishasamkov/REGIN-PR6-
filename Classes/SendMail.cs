using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace REGIN.Classes
{
    public class SendMail
    {
        public static void SendMessage(string Message, string To)
        {
            var smtpClient = new SmtpClient("smtp.yandex.ru")
            {
                Port = 587,
                Credentials = new NetworkCredential("Lunch418@yandex.ru", "vvgcgwgofmbgwnhi"),
                EnableSsl = true,
            };
            smtpClient.Send("Lunch418@yandex.ru", To, "Проект RegIn", Message);
        }
    }
}
