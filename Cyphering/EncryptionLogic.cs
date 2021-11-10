using System;
using Helpers;

namespace Encryption
{
    public class EncryptionLogic
    {
        public string EncryptString(string text, string key)
        {
            char[] keyChar= key.ToCharArray();
            char[] textChar = text.ToCharArray();
            char[] resultChar = new char[keyChar.Length];
            for (int i = 0; i < keyChar.Length; i++)
            {
               resultChar[i] = CypherHelper.MoveLetterForward(textChar[i],int.Parse(keyChar[i].ToString()));
            }
            return new string(resultChar);
        }
        public string DecipherString(string text, string key)
        {
            char[] keyChar = key.ToCharArray();
            char[] textChar = text.ToCharArray();
            char[] resultChar = new char[keyChar.Length];
            for (int i = 0; i < keyChar.Length; i++)
            {
                resultChar[i] = CypherHelper.MoveLetterBackward(textChar[i], int.Parse(keyChar[i].ToString()));
            }
            return new string(resultChar);
        }
    }
}
