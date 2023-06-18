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
            /*
                SMTP -> Servidor que vai enviar a mensagem.            
            */
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("coringa.zunning@gmail.com", "rwnbsaqejdamysbn");
            smtp.EnableSsl = true;

            string corpoMsg = string.Format("<h2> Contato - Loja Virtual</h2> " +
                "<b>Nome: </b>: {0} <br/>" +
                "<b>E-mail: </b>: {1} <br/>" +
                "<b>Texto: </b>: {2} <br/" +
                "<b>E-mail enviado automaticamente do site LojaVirtual! ", contato.Nome, contato.Email, contato.Texto);





            /*
                MailMessage -> Construir a mensagem
             */

            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("coringa.zunning@gmail.com");
            mensagem.To.Add("coringa.zunning@gmail.com");
            mensagem.Subject = "Contato - LojaVirtual - E-mail: " + contato.Email;
            mensagem.IsBodyHtml = true;
            mensagem.Body = corpoMsg;

            smtp.Send(mensagem);
        }

    }
}
