using System;
using System.Linq;
using System.Text;

namespace OneTimePad.Lib
{
    public class OTP
    {
        private static Random random = new Random();
        public string Generate(int keyLengthInBytes)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            StringBuilder builder = new StringBuilder();
            int asciiCharacterStart = 65; // from which ascii character code the generation should start
            int asciiCharacterEnd = 122; // to which ascii character code the generation should end

            for (int i = 0; i < keyLengthInBytes; i++)
            {
                builder.Append((char)(random.Next(asciiCharacterStart, asciiCharacterEnd + 1) % 255));
            }
            return builder.ToString();
        }

        public string Encrypt(string key, string message)
        {
            StringBuilder ciphertext = new StringBuilder();
            for (int i = 0; i < message.Length - 1; i++)
            {

                string encryptedChar = (message[i] ^ key[i]).ToString();
                ciphertext.Append(encryptedChar);
            }
            return ciphertext.ToString();
        }

        public string Decrypt(string key, string cipherText)
        {
            return "Wonder what the original message was?";
        }
    }
}




