using FizzBuzzAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FizzBuzzAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzRepository _fizzBuzzRepository;

        public FizzBuzzController(IFizzBuzzRepository fizzBuzzRepository)
        {
            _fizzBuzzRepository = fizzBuzzRepository;

        }
        [HttpGet]
        [ActionName("GetFizzBuzz")]
        public IEnumerable<string> Get([FromQuery(Name = "value")]IEnumerable<string> value)
        {
            try
            {
                var values = new List<string>();
                if (value != null)
                {
                    foreach (var item in value)
                    {
                        values.Add(_fizzBuzzRepository.Calculator(item));
                    }
                }
                return values.ToArray();
            }
            catch (Exception ex)
            {
                return new string[] { ex.Message };
            }
        }
    }
}
