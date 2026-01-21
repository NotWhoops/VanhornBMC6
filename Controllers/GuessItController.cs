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
            public string GuessItServicesEasy(string easyGuess)
            {
                return _guessItServices.GuessIt("Easy", easyGuess);
            }
            [HttpGet]
            [Route("GuessItServicesMedium/{mediumGuess}")]
            public string GuessItServicesMedium(string mediumGuess)
            {
                return _guessItServices.GuessIt("Medium", mediumGuess);
            }
            [HttpGet]
            [Route("GuessItServicesHard/{hardGuess}")]
            public string GuessItServicesHard(string hardGuess)
            {
                return _guessItServices.GuessIt("Hard", hardGuess);
            }
    }
}