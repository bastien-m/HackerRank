using System;
using System.Text;

namespace HackerRank
{
    class CaesarCipher
    {
        public String MessageToEncode { get; set; }
        public int ShiftingKey { get; set; }
        public String EncodedMessage { get; set; }
        private int numberOfCharacater = 26;

        public CaesarCipher(String readableString, int shift)
        {
            this.MessageToEncode = readableString;
            this.ShiftingKey = shift % 26;
        }


        public String Resolve()
        {
            StringBuilder EncodedMessageBuilder = new StringBuilder();
            foreach (char c in this.MessageToEncode)
            {
                if (Char.IsLetter(c))
                {
                    EncodedMessageBuilder.Append(this.ShiftChar(c));
                }
                else
                {
                    EncodedMessageBuilder.Append(c);
                }
            }
            this.EncodedMessage = EncodedMessageBuilder.ToString();
            return this.EncodedMessage;
        }

        private char ShiftChar(char elementToShift)
        {
            int maxLowerCase = 122, maxUpperCase = 90;
            int valueElementToShift = (int)elementToShift;
            int valueElementShifted = valueElementToShift + this.ShiftingKey;
            //We check if the shifted value is over Z or z (depend of case)
            if ((valueElementToShift <= maxUpperCase && valueElementShifted > maxUpperCase) || 
                (valueElementToShift > maxUpperCase && valueElementToShift <= maxLowerCase && valueElementShifted > maxLowerCase))
            {
                valueElementShifted-= this.numberOfCharacater;
            }
            return (char)(valueElementShifted);
        }
    }
}
