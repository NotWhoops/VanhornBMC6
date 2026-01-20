using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VanhornBMC6.Services;

namespace VanhornBMC6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItServices;

            public GuessItController(GuessItServices guessItServices)
            {
                _guessItServices = guessItServices;
            }
            [HttpGet]
            [Route("GuessItServicesEasy/{easyGuess}")]
            public string GuessItServices(string easyGuess)
            {
                return _guessItServices.
                GuessIt("easy", easyGuess);
            }
            [HttpGet]
            [Route("GuessItServicesMedium/{mediumGuess}")]
            public string GuessItServices(string mediumGuess)
            {
                return _guessItServices.
                GuessIt("medium", mediumGuess);
            }
            // [HttpGet]
            [Route("GuessItServicesHard/{hardGuess}")]
            public string GuessItServices(string hardGuess)
            {
                return _guessItServices.
                GuessIt("hard", hardGuess);
            }
    }
}