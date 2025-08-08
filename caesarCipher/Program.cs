
using System;
using System.Diagnostics;
using System.IO.Pipelines;
namespace caesarCipher;

  class Program
{
    static void Main(string[] args)
    {
        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        Console.WriteLine("Enter a message");
        string result = Console.ReadLine();
        result = result.ToLower();
        char[] secretMessage = result.ToCharArray();
        char[] encryptedMessage = new char[secretMessage.Length];
        for (int i = 0; i < secretMessage.Length; i++)
        {
            char ch = secretMessage[i];
            int position = Array.IndexOf(alphabet, ch);
            int newLetterPosition = (position + 3) % alphabet.Length;
            char encryptedLetter = alphabet[newLetterPosition];
            encryptedMessage[i] = encryptedLetter;
        }
        Console.WriteLine(String.Join("", encryptedMessage));
    }
}
