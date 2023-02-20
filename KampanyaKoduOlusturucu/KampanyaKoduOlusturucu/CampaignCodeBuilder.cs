using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampanyaKoduOlusturucu
{
    public class CampaignCodeBuilder
    {
        int codeLength = 8;
        string characters = "ACDEFGHKLMNPRTXYZ234579";
        
        /// <summary>
        /// Bu method 8 karakterli bir kampanya kodu üretir. 
        /// Kodu üretirken çift halinde üretir.
        /// ilk karakter karakter dizisinden rasgele olarak seçilir.
        /// İkinci karakter ise ilk karakterin karakter dizisindeki indisinin karesinin karakter uzunluğunun bölümünden kalanı olarak seçilir.
        /// </summary>
        /// <returns></returns>
        public string Generate()
        {
            string code = "";
            Random random = new Random();           
 
            for (int i = 0; i < codeLength; i += 2)
            {
                int firstCharacterIndex = random.Next(characters.Length);
                int secondCharacterIndex = firstCharacterIndex * firstCharacterIndex % characters.Length;
                char firstCharacter = characters[firstCharacterIndex];
                char secondCharacter = characters[secondCharacterIndex];
                code += firstCharacter ;
                code += secondCharacter;
            }
            return code;
        }

        public bool Validate(string code)
        {
            for (int i = 0; i < code.Length; i += 2)
            {
                int firstCharacterIndex = findIndex(code[i]);
                int secondCharacterIndex = findIndex(code[i+1]);
                int secondCharacterIndexControl = firstCharacterIndex * firstCharacterIndex % characters.Length;
                if (secondCharacterIndex != secondCharacterIndexControl)
                {
                    return false;
                }
            }

            return true;
        }

        private int findIndex(char character)
        {
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i].Equals(character))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
