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
    [HttpGet]
    [Route("/v2/intersection")]
    public IActionResult Intesection()
    {
        return Ok("Hello V2 Intersection");
    }
    [HttpGet]
    [Route("/v2/intesectionwithHtml")]
    public IActionResult IntersectionHTML()
    {
        return Ok("Hello Intersection with html");
    }
}
