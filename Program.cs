namespace _95_Cesar
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Zadejte text k zašifrování: ");
            string plaintext = Console.ReadLine();

            Console.WriteLine("Zadejte posun: ");
            int shift = int.Parse(Console.ReadLine());

            string ciphertext = Encrypt(plaintext, shift);
            Console.WriteLine("Zašifrovaný text: " + ciphertext);

            string decryptedText = Decrypt(ciphertext, shift);
            Console.WriteLine("Dešifrovaný text: " + decryptedText);

            Console.ReadLine();
        }

        static string Encrypt(string plaintext, int shift)
        {
            char[] encryptedChars = new char[plaintext.Length];

            for (int i = 0; i < plaintext.Length; i++)
            {
                char currentChar = plaintext[i];
                if (char.IsLetter(currentChar))
                {
                    char encryptedChar = (char)(currentChar + shift);
                    if (!char.IsLetter(encryptedChar))
                    {
                        encryptedChar = (char)(encryptedChar - 26);
                    }
                    encryptedChars[i] = encryptedChar;
                }
                else
                {
                    encryptedChars[i] = currentChar;
                }
            }

            return new string(encryptedChars);
        }

        static string Decrypt(string ciphertext, int shift)
        {
            char[] decryptedChars = new char[ciphertext.Length];

            for (int i = 0; i < ciphertext.Length; i++)
            {
                char currentChar = ciphertext[i];
                if (char.IsLetter(currentChar))
                {
                    char decryptedChar = (char)(currentChar - shift);
                    if (!char.IsLetter(decryptedChar))
                    {
                        decryptedChar = (char)(decryptedChar + 26);
                    }
                    decryptedChars[i] = decryptedChar;
                }
                else
                {
                    decryptedChars[i] = currentChar;
                }
            }

            return new string(decryptedChars);
        }
    }

}