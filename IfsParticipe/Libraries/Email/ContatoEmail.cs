using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Email
{
    public class ContatoEmail
    {

        public static void EnviarContatoPorEmail(Contato contato)
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("uendel.batista@gmail.com","");
            smtp.EnableSsl = true;

            string corpoMsg = string.Format("<h2>Contato - LojaVirtual </h2>" +
                "<b>Nome:</b> {0} <br/>"+
                "<b>Email:</b> {1} <br/>" +
                "<b>Mensagem:</b> {2} <br/>"+
                "<br/> Email enviado automaticamente do site LojaVirtual.",
                contato.Nome,
                contato.Email,
                contato.Texto);

            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("uendel.batista@gmail.com");
            mensagem.To.Add("uendel.batista@gmail.com");
            mensagem.Subject = "Contato - Loja Virtual - E-mail: " + contato.Email;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;

            //smtp.Send(mensagem);

        }

    }
}
