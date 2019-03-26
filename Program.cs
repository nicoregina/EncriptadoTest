using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncriptadoTest
{
    internal class Program
    {
        static void Main()
        {
            string contrasenia = "";
            string contraseniaEncriptada = "";
            Console.WriteLine("Ingrese una contraseña: ");
            contrasenia = Console.ReadLine();
            contraseniaEncriptada = Encriptar(contrasenia);
            Console.WriteLine("Esto es el mensaje encriptado: " + contraseniaEncriptada);
            Console.WriteLine("Pulse una tecla para desencriptar…\n");
            Console.ReadKey();
            contrasenia = Desencriptar(contraseniaEncriptada);
            Console.WriteLine("Esta es la contraseña desencriptada: " + contrasenia);
            Console.WriteLine("Oprima una tecla para finalizar");
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Encripta un mensaje
        /// </summary>
        /// <param name="contrasenia">
        /// Contraseña que va a ser encriptada
        /// </param>
        /// <param name="cadenaEncriptada">
        /// contraseña ya convertida mediante codigo ASCII 
        /// </param>
        /// <param name="cadena">
        /// variable char que va a ser encriptada letra x letra
        /// </param>
        /// <returns>
        /// Un string que representan el mensaje encriptado.
        /// </returns>
        private static string Encriptar(string contrasenia)
        {
            string cadenaEncriptada = "";
            char[] cadena = contrasenia.ToCharArray();
            //aqui toma letra por letra, la modifica mediante codigo ASCII
            for (int i = 0; i < contrasenia.Length; i++)
            {
                cadena[i] = (char)(cadena[i] + (char)10);
                cadenaEncriptada += cadena[i];
            }
            return cadenaEncriptada;
        }
        /// <summary>
        /// Desencripta un mensaje
        /// </summary>
        /// <param name="cadenaEncriptada">
        /// cadena de caracteres encriptados por codigo ASCII
        /// </param>
        /// <param name="cadenaDesencriptada">
        /// contraseña ya desencriptada
        /// </param>
        /// <param name="cadena">
        /// variable char que va a ser desencriptada letra x letra
        /// </param>
        /// <returns>
        /// Un string que representan el mensaje desencriptado.
        /// </returns>
        private static string Desencriptar(string cadenaEncriptada)
        {
            string cadenaDesencriptada = "";
            char[] cadena = cadenaEncriptada.ToCharArray();
            //aqui toma letra por letra, la modifica mediante codigo ASCII
            for (int i = 0; i < cadenaEncriptada.Length; i++)
            {
                cadena[i] = (char)(cadena[i] - (char)10);
                cadenaDesencriptada += cadena[i];
            }
            return cadenaDesencriptada;
        }
    }
}
