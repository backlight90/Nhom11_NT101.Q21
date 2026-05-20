using System;
using System.Collections.Generic;
using System.Text;

namespace Nhom11_NT101.Q21.Algorithms.Vigenere
{
    public class VigenereService
    {
        public char EncryptChar(char plainChar, char keyChar)
        {
            if (!char.IsLetter(plainChar))
                return plainChar;
            char offset = char.IsUpper(plainChar) ? 'A' : 'a';
            int keyOffset = char.ToUpper(keyChar) - 'A';
            return (char)(((plainChar - offset + keyOffset) % 26) + offset);
        }

        public char DecryptChar(char cipherChar, char keyChar)
        {
            if (!char.IsLetter(cipherChar))
                return cipherChar;
            char offset = char.IsUpper(cipherChar) ? 'A' : 'a';
            int keyOffset = char.ToUpper(keyChar) - 'A';
            return (char)(((cipherChar - offset - keyOffset + 26) % 26) + offset);
        }
    }
}
