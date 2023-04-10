using Microsoft.AspNetCore.Mvc;
using MovieStoreMvc.Models.Domain;
using MovieStoreMvc.Repositories.Abstract;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieStoreMvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public RatingController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        // GET: api/<RatingController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // POST api/<RatingController>
        [HttpPost]
        public IActionResult Post([FromBody] RatingDto model)
        {
            var movie = _movieService.GetbyId(model.Id);
            if (!ModelState.IsValid)
                return BadRequest("Id and Stars count are required");

            movie.Rating = model.Rating;
            var result = _movieService.UpdateRating(movie);
            if (result)
            {
                return Ok("Added Successfully");
            }
            else
            {
                return BadRequest("Error on server side");
            }
        }
    }
}
