using DependencyInjection.Servicelerim;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ValuesController : ControllerBase
    {
        private readonly BenimServisim benimServisim;

        public ValuesController(BenimServisim benimServisim)
        {
            this.benimServisim = benimServisim;
        }

        [HttpGet]
        public IActionResult Get()
        {
            string temp = benimServisim.Print();
            temp += benimServisim.Print();
            temp += benimServisim.Print();
            return Ok(temp);
        }
    }
}
