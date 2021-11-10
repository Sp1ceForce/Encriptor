using System;
using System.Collections.Generic;

namespace Helpers
{
    public class CypherHelper
    {
        static char[] alpabet = new char[] {' ','А','Б', 'В', 'Г', 'Д','Е', 'Ё', 'Ж', 'З', 'И', 'К', 'Л', 'М', 'Н',
            'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
        public static char MoveLetterForward(char originalChar, int moveIndex)

        {
            
            int desiredIndex=0;
            int charIndex = FindLetterIndex(originalChar);
            if (moveIndex+charIndex > alpabet.Length)
            {
                desiredIndex = (charIndex + moveIndex) - alpabet.Length;
            }
            else
            {
                desiredIndex = charIndex + moveIndex;
            }
                return alpabet[desiredIndex];
        }
        public static char MoveLetterBackward(char originalChar, int moveIndex)
        {
            int desiredIndex = 0;
            int charIndex = FindLetterIndex(originalChar);
            if ((charIndex- moveIndex) < 0)
            {
                desiredIndex = (charIndex - moveIndex) + alpabet.Length;
            }
            else
            {
                desiredIndex = charIndex - moveIndex;
            }
            return alpabet[desiredIndex];
        }

        static int FindLetterIndex(char orChar)
        {
            for (int i = 0; i < alpabet.Length; i++) { 
                if (orChar == alpabet[i])
                {
                    return i;
                }
                else
                {
                }
            }
           
            return 0;
        }
                  
    }
}
    

