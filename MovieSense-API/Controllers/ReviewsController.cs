using Microsoft.AspNetCore.Mvc;

namespace MovieSense_API.Controllers
{
    [ApiController]
    [Route("[controller]/")]
    public class ReviewsController : ControllerBase
    {
        public ReviewsController() { }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> UploadReview()
        {
            return Ok();
        }
    }
}
