using DependencyInjection.Servicelerim;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class Values2Controller : ControllerBase
    {
        private readonly BenimServisim benimServisim;

        public Values2Controller([FromKeyedServices("scopedservisim")]BenimServisim benimServisim)
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
