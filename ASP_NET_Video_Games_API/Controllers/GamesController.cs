using ASP_NET_Video_Games_API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Video_Games_API.Controllers
{
    // api/games
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("publisher/")]
        public IActionResult GetPublishers()
        {
            var videoGamePublishers = _context.VideoGames.Select(vg => vg.Publisher).Distinct();

            return Ok(videoGamePublishers);
        }

        [HttpGet("pubname/{pubName}")]
        public IActionResult GetGamesByPublisher(string pubName)
        {
            // int? maxYear = _context.VideoGames.Select(vg => vg.Year).Max();
            // int? minYear = _context.VideoGames.Select(vg => vg.Year).Min();

            var videoGames = _context.VideoGames.Where(vg => vg.Publisher == pubName);
            return Ok(videoGames);
        }

        [HttpGet("id/{id}")]
        public IActionResult GetGamesById(int id)
        {
            
            var GamesById = _context.VideoGames.Where(vg => vg.Id == id);
            return Ok(GamesById);        
        }

        
        [HttpGet("allData/")]
        public IActionResult GetAllVideoGames()
        {
            var allVideoGames = _context.VideoGames;
            return Ok(allVideoGames);
        }

    }
}
