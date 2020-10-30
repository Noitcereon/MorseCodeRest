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
    [Route("api/translate/")]
    public class MorseToTextController
    {
        private MorseToTextManager _manager = new MorseToTextManager();

        [HttpGet("morse")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetNormalChar([FromQuery]string morseCharacter)
        {
            return Ok(_manager.GetNormalChar(morseCharacter));
        }
    }
}
