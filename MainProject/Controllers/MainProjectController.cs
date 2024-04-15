using Microsoft.AspNetCore.Mvc;
using MainProject;

namespace MainProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainProjectController : ControllerBase
    {
        [HttpGet("IsPalindrome/{number}")]
        public ActionResult<string> IsPalindrome(int number)
        {
            ProgramCode program = new ProgramCode();
            bool isPalindrome = program.CheckPalindrome(number);
            if (isPalindrome)
                return Ok("Number is Palindrome.");
            else
                return Ok("Number is not Palindrome.");
        }
    }
}
