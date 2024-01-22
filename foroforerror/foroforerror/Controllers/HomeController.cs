using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    [Route("/onpremise/onpremiseconfig")]
    public IActionResult OnPremiseConfig()
    {
        return Ok("Hello World");
    }

    [HttpGet]
    [Route("/onpremise/managedcertificates")]
    public IActionResult ManagedCertificates()
    {
        return Ok("Hello Certificates");
    }
}
