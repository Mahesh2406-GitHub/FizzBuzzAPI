using FizzBuzzAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzRepository _fizzBuzzRepository;

        public FizzBuzzController(IFizzBuzzRepository fizzBuzzRepository)
        {
            _fizzBuzzRepository = fizzBuzzRepository;

        }
        [HttpGet(Name = "GetFizzBuzz")]
        public string Get(string? value)
        {
            try
            {
                return _fizzBuzzRepository.Calculator(value);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
