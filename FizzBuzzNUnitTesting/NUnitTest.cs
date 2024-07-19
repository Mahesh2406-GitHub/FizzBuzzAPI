using FizzBuzzAPI.Controllers;
using FizzBuzzAPI.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzzNUnitTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("3", "Fizz")]
        [TestCase("5", "Buzz")]
        [TestCase("", "Invalid Item")]
        [TestCase("15", "FizzBuzz")]
        [TestCase("45", "FizzBuzz")]
        [TestCase("1", "1 Divided by 3 1 Divided by 5")]
        [TestCase("23", "23 Divided by 3 23 Divided by 5")]
        [TestCase("a", "Invalid Item")]
        public void N_Test(string empId, string name)
        {
            var serviceProvider = new ServiceCollection()
                .AddScoped<IFizzBuzzRepository, FizzBuzzRepository>()
            .AddLogging()
            .BuildServiceProvider();
            var fizzBuzzRepository = serviceProvider.GetService<IFizzBuzzRepository>();
            FizzBuzzController fizzBuzzController = new FizzBuzzController(fizzBuzzRepository);
            string result = fizzBuzzController.Get(empId);
            Assert.AreEqual(name, result);
        }
    }
}