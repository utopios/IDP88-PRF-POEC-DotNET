using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CoursAdoNET.Class
{
    public class MyMD5
    {
        public static string GetMd5Hash(MD5 md5Hash, string password)
        {
            // Convertion de la chaine en tableau de Byte
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

            // Création d'un string builder pour collecter les byte issu du tableau
            StringBuilder sBuilder = new StringBuilder();


            // itération du tableau data et format de la chaine en héxadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Retour de la chaine au format hexadecimal
            return sBuilder.ToString();
        }
    }
}
