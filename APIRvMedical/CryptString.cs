using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace APIRvMedical
{
    public static class CryptString
    {

        public static string GetMd5Hash(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                // Convertit le string en tableau de bytes et calcule le hash
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Crée un StringBuilder pour collecter les bytes
                StringBuilder sBuilder = new StringBuilder();

                // Formate chaque byte en hexadécimal
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                return sBuilder.ToString();
            }
        }

        /// <summary>
        /// Méthode pour vérifier un hash
        /// </summary>
        /// <param name="input"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        public static bool VerifyMd5Hash(string input, string hash)
        {
            string hashOfInput = GetMd5Hash(input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            return comparer.Compare(hashOfInput, hash) == 0;
        }
    }

}
