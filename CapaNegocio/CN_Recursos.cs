using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace CapaNegocio
{
    public class CN_Recursos
    {
        public static string GetSHA256(string texto)
        {
            //SHA256 sha256 = SHA256Managed.Create();
            //ASCIIEncoding encoding = new ASCIIEncoding();
            //byte[] stream = null;
            //StringBuilder sb = new StringBuilder();
            //stream = sha256.ComputeHash(encoding.GetBytes(texto));
            //for (int i = 0; i < (stream.Length) - 4; i++) sb.AppendFormat("{0:x1}", stream[i]);
            //return sb.ToString();

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
    }
}
