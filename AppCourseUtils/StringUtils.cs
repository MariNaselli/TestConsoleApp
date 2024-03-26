using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCourseUtils
{
    public class StringUtils
    {
        public static string Reverse(string s)
        {
            string newString = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                newString += s[i];
            }
            return newString;
        }

        public static bool IsPalindrome(string word)
        {
            bool isPalindrome = false;
            string reversedword = Reverse(word);
            if (word == reversedword)
            {
                isPalindrome = true;
            }
            return isPalindrome;
        }

        public static string ExtractVowels(string word)
        {
            StringBuilder vowels = new StringBuilder();

            // Convertimos la cadena a minúsculas para hacer la comparación más fácil
            word = word.ToLower();

            // Recorremos cada caracter de la cadena
            foreach (char character in word)
            {
                // Verificamos si el caracter es una vocal
                if (isVowel(character))
                {
                    vowels.Append(character);
                }
            }

            return vowels.ToString();
        }

        public static bool isVowel(char c)
        {
            // Definimos un arreglo de caracteres que representan las vocales
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            // Verificamos si el carácter está contenido en el arreglo de vocales
            foreach (char vowel in vowels)
            {
                if (c == vowel)
                {
                    return true;
                }
            }
            return false;
        }

        public static string ExtractConsonants(string word)
        {
            StringBuilder consonants = new StringBuilder();

            // Convertimos la cadena a minúsculas para hacer la comparación más fácil
            word = word.ToLower();

            // Recorremos cada caracter de la cadena
            foreach (char c in word)
            {
                // Verificamos si el caracter no es una vocal
                if (!isVowel(c))
                {
                    consonants.Append(c);
                }
            }

            return consonants.ToString();
        }

        public static (string, string) ExtractVowelsAndConsonants(string word)
        {
            StringBuilder vowels = new StringBuilder();
            StringBuilder consonants = new StringBuilder();

            // Convertimos la cadena a minúsculas para hacer la comparación más fácil
            word = word.ToLower();

            // Recorremos cada caracter de la cadena
            foreach (char c in word)
            {
                // Verificamos si el caracter es una vocal
                if (isVowel(c))
                {
                    vowels.Append(c);
                }
                else // Si no es una vocal, es una consonante
                {
                    consonants.Append(c);
                }
            }

            return (vowels.ToString(), consonants.ToString());
        }

    }
}
