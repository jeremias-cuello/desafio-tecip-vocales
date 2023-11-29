using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Vocales_Uppercaps
{
    static class Herramientas
    {
        static public int ContarVocales(this string texto)
        {
            // Jeremias Cuello - 14/4/2022
            //
            // Resumen:
            //      Devuelve el numero de coincidencias entre las vocales y la cadena texto.

            return Regex.Matches(texto, "(A|E|I|O|U)").Count;
        }

        static public string UppercapsVocales(this string texto)
        {
            // Jeremias Cuello - 14/4/2022
            //
            // Resumen: 
            //      Devuelve la cadena texto con sus vocales minuscula a mayuscula.

            const string vocales = "aeiou";

            foreach (char vocal in vocales)
            {
                texto = texto.Replace(vocal.ToString(), vocal.ToString().ToUpper());
            }
        
            return texto;
        }
    }
}
