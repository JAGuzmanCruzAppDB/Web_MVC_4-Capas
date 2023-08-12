using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

using System.Net.Mail;
using System.Net;
using System.IO;

namespace CapaNegocio
{
    public class CN_Recursos
    {
        public static string GenerarClave()
        {
            string clave = Guid.NewGuid().ToString("N").Substring(0, 6);
            return clave;
        }
        public static string ConvertirSha256(string texto)
        {
            StringBuilder sb = new StringBuilder();
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(texto));
                foreach (byte b in result)
                    sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
        public static bool EnviarCorreo(string correo, string asunto,string mensaje)
        {
            bool resultado = false;
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(correo);
                mail.From = new MailAddress("bfjose26pruebas@gmail.com");
                mail.Subject = asunto;
                mail.Body = mensaje;
                mail.IsBodyHtml = true;

                var smtp = new SmtpClient()
                {
                    Credentials = new NetworkCredential("bfjose26pruebas@gmail.com", "hgtskicriyndceam"),
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true
                };

                smtp.Send(mail);
                resultado = true;

            }
            catch(Exception ex){

                resultado = false;
            }
            return resultado;

            //SHA256 sha256 = SHA256Managed.Create();
            //ASCIIEncoding encoding = new ASCIIEncoding();
            //byte[] stream = null;
            //StringBuilder sb = new StringBuilder();
            //stream = sha256.ComputeHash(encoding.GetBytes(texto));
            //for (int i = 0; i < (stream.Length) - 4; i++) sb.AppendFormat("{0:x1}", stream[i]);
            //return sb.ToString();
        }
    }
}
