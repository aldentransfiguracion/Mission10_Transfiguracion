using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission10_API.Data;

namespace Mission10_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlingRepository _bowlerRepository;
        public BowlingController(IBowlingRepository bowlerRepository)
        {
            _bowlerRepository = bowlerRepository;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var BowlerData = _bowlerRepository.GetBowlersWithTeams().ToArray(); 
            return BowlerData;
        }

    }
}
