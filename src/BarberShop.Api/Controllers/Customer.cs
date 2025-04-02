using BarberShop.Api.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarberShop.Api.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class Customer : MainController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDTO>>> Get()
        {
            return Ok();
        }
    }
}
