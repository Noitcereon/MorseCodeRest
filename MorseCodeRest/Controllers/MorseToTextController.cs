using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MorseCodeRest.Managers;

namespace MorseCodeRest.Controllers
{
    [ApiController]
    [Route("api/translate")]
    public class MorseToTextController : ControllerBase
    {
        private readonly MorseToTextManager _manager = new MorseToTextManager();

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult TranslateCharacter([FromQuery]string morseCharacter)
        {
            if (morseCharacter.Length > 5)
            {
                return BadRequest("Input too long. Morse code takes up to 5 characters. Example input: --. (should return G)");
            }

            if (_manager.Translate(morseCharacter).Length > 1)
            {
                return NotFound("The morse code input doesn't translate to a character.");
            }
            return Ok(_manager.Translate(morseCharacter)); 
        }

        // TODO: Translate more than just a single morse code character at a time.
        // Unimplmented because it requires to convert a string into an Enumerable object to check each morseCharacter.
        // Probably something with a StringBuilder, which splits the string whenever there is a space or something...

        //[HttpGet("")]
        //public IActionResult Translate(IEnumerable<string> morseCharacters)
        //{
        //    return Ok(_manager.Translate(morseCharacters));
        //}
    }
}
