using System.Security.Cryptography;
using System.Text;

namespace Practica5.Helpers
{
    public class Cifrado
    {
        public static bool CompareArrays(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;
            for (int i = 0; i < a.Length; i++)

                if (!a[i].Equals(b[i]))
                    return false;
            return true;
        }

        public static string GenerateSalt()
        {
            //TENDREMOS UN SALT DE 50
            Random random = new Random();
            string salt = "";
            for (int i = 1; i <= 50; i++)
            {
                int aleat = random.Next(0, 255);
                char letra = Convert.ToChar(aleat);
                salt += letra;
            }
            return salt;
        }


        //TENDREMOS UN METODO PARA CIFRAR NUESTRO PASSWORD
        public static byte[] EncryptPassword(string password, string salt)
        {
            string contenido = password + salt;
            SHA512 sHA = SHA512.Create();
            //CONVERTIMOS NUESTRO CONTENIDO A BYTES
            byte[] salida = Encoding.UTF8.GetBytes(contenido);
            //ITERACIONES PARA NUESTRO PASSWORD
            for (int i = 1; i <= 107; i++)
            {
                salida = sHA.ComputeHash(salida);
            }
            sHA.Clear();
            return salida;
        }
    }

}