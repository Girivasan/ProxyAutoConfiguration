using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProxyAutoConfiguration.Controllers
{
  [Route("simple.pac")]
  [ApiController]
  public class PacController : ControllerBase
  {
    // GET: api/pac
    [HttpGet]
    public FileContentResult Get()
    {
      var pacFile = System.IO.File.ReadAllBytes("Resources/simple.pac");
      return new FileContentResult(pacFile, "application/x-ns-proxy-autoconfig");
    }
  }
}
