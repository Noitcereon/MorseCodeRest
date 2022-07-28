using MorseCodeRest.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeRestTest
{
    [TestClass]
    public class MorseToTextManagerTest
    {
        private static MorseToTextManager _manager;

        [TestInitialize]
        public void Init()
        {
            _manager = new MorseToTextManager();
        }

        [TestMethod]
        public void GivenValidMorseCodeString_WhenTranslatingSingleMorseCharacter_ThenASingleRomanCharacterIsProduced()
        {
            String morseCharacterInput = ".-";
            String expected = "A";

            String actual = _manager.Translate(morseCharacterInput);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenInvalidMorseCodeString_WhenTranslatingSingleMorseCharacter_ThenAMessageSayingItDidNotSucceedIsReturned()
        {
            String morseCharacterInput = "A";
            String expected = "Couldn't find value.";

            String actual = _manager.Translate(morseCharacterInput);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenValidMorseCodeStringSeperatedBySpaces_WhenTranslatingMorseCharacterWord_ThenASeriesOfRomanCharacterIsProduced()
        {
            String morseCharactersInput = "... --- ...";
            IEnumerable<String> morseCharacters = morseCharactersInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            String expected = "SOS";

            String actual = _manager.Translate(morseCharacters);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenPartiallyValidMorseCodeStringSeperatedBySpaces_WhenTranslatingMorseCharacterWord_ThenASeriesOfRomanCharacterIsProducedWithInvalidPartsReplaced()
        {
            String morseCharactersInput = "... --- ... this is invalid morsecode";
            IEnumerable<String> morseCharacters = morseCharactersInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            String expected = "SOS InvalidMorseCharacter  InvalidMorseCharacter  InvalidMorseCharacter  InvalidMorseCharacter ";

            String actual = _manager.Translate(morseCharacters);

            Assert.AreEqual(expected, actual);
        }
    }
}
