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
        /// <summary>
        /// Translates a single morse character to normal character.
        /// </summary>
        /// <param name="morseCharacter">A single morse character, eg. ".-"</param>
        /// <returns>The translated morse code as a single roman letter</returns>
        public string Translate(string morseCharacter)
        {
            _morseDictionary.TryGetValue(morseCharacter, out string output);
            return string.IsNullOrWhiteSpace(output) ? "Couldn't find value." : output;
        }

        /// <summary>
        /// Translates a collection of morse characters into a readable word.
        /// </summary>
        /// <param name="morseCharacters">A Collection of morse characters</param>
        /// <returns>The translated morse code as roman letters</returns>
        public string Translate(IEnumerable<string> morseCharacters)
        {
            string output = "";
            foreach (var character in morseCharacters)
            {
                if(character.Contains('.') || character.Contains('-'))
                {
                    output += Translate(character);
                }
                else
                {
                    output += " InvalidMorseCharacter ";
                }
            }

            return output;
        }
    }
}
