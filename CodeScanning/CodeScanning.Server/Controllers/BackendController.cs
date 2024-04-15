using CodeScanningService;
using Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeScanning.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BackendController : ControllerBase
    {

        private readonly ICodeScanningServiceLayer _serviceLayer;

        public BackendController(ICodeScanningServiceLayer serviceLayer)
        {
            _serviceLayer = serviceLayer;
        }

        [HttpPost("process-code")]
        public IActionResult ProcessCode(CodeModel code)
        {
            // Process the received code here
            // For demonstration, we'll simply return the code back
            
            // Call the code scanning service to process the code
            var results = _serviceLayer.scanCode(code);

            return Ok(results);
        }

        [HttpGet("get-code")]
        public string GetCode()
        {
            return "abc";
        }
    }
}
