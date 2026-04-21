using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FactoryPatttern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinalValuesController : ControllerBase
    {
        private readonly IFactoryResolverFinal _factoryResolverFinal;
        public FinalValuesController(IFactoryResolverFinal factoryResolverFinal)
        {
            _factoryResolverFinal = factoryResolverFinal;
        }

        [HttpGet]
        public ActionResult Get(string Type)
        {
            try
            {
                var response = _factoryResolverFinal.Book(Type);
                return Ok(response);
            }
            catch(Exception ex) { 

                return BadRequest(ex);
            }
        }
    }
}
