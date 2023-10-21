using DatesApp.Data;
using DatesApp.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatesApp.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly DataContext _context;

        public BuggyController(DataContext contetx)
        {
            _context = contetx;
        }

        [Authorize]
        [HttpGet("Auth")]
        public ActionResult<string> GetSecret()
        {
            return "Secreto de la API";
        }

        [Authorize]
        [HttpGet("NotFound")]
        public ActionResult<User> GetNotFound()
        {
            var thing = _context.Users.Find(-1);
            if (thing == null) return NotFound();
            return thing;
        }

        [Authorize]
        [HttpGet("ServerError")]
        public ActionResult<string> GetServerError()
        {
            try
            {
                var thing = _context.Users.Find(-1);
                var thingToReturn = thing.ToString();
                return thingToReturn;
            } catch
            {
                return StatusCode(500, "Algo salió mal");
            }
        }

        [Authorize]
        [HttpGet("BadRequest")]
        public ActionResult<string> GetBadRequest()
        {
            return BadRequest("Invalid request");
        }
    }
}
