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
        public IActionResult GetNormalChar([FromQuery]string morseCharacter)
        {
            if (morseCharacter.Length > 5)
            {
                return BadRequest("Input too long. Morse code takes up to 5 characters. Example input: --. (should return G)");
            }

            if (_manager.GetNormalChar(morseCharacter).Length > 1)
            {
                return NotFound("Input doesn't translate to a character.");
            }
            return Ok(_manager.GetNormalChar(morseCharacter));
        }
    }
}
