using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorseCodeRest.Managers
{
    public class MorseToTextManager
    {
        private readonly Dictionary<string, string> _morseDictionary = new Dictionary<string, string>
        {
            { ".-", "A" }, { "-...", "B" }, { "-.-.", "C" }, { "-..", "D" },
            { ".", "E" }, { "..-.", "F" }, { "--.", "G" }, { "....", "H" },
            { "..", "I" }, { ".---", "J" }, { "-.-", "K" }, { ".-..", "L" },
            { "--", "M" }, { "-.", "N" }, { "---", "O" }, { ".--.", "P" },
            { "--.-", "Q" }, { ".-.", "R" }, { "...", "S" }, { "-", "T" },
            { "..-", "U" }, { "...-", "V" }, { ".--", "W" }, {"-..-", "X"},
            { "-.--", "Y" }, {"--..", "Z" }, { ".----", "1" }, { "..---", "2" },
            { "...--", "3" }, { "....-", "4" }, { ".....", "5" }, { "-....", "6" },
            { "--...", "7" }, { "---..", "8" }, { "----.", "9" }, { "-----", "0" }

        };
        public string GetNormalChar(string morseCharacter)
        {
            _morseDictionary.TryGetValue(morseCharacter, out string output);
            return string.IsNullOrWhiteSpace(output) ? "Couldn't find value." : output;
        }
    }
}
