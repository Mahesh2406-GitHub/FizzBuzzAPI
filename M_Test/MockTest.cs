using FizzBuzzAPI.Controllers;
using FizzBuzzAPI.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace M_Test
{
    [TestClass]
    public class MockTest
    {
        [TestMethod]
        [DataRow("Fizz", "3")]
        [DataRow("Buzz", "5")]
        [DataRow("FizzBuzz", "45")]
        [DataRow("Invalid Item", "A")]
        [DataRow("Invalid Item", "")]
        [DataRow("1 Divided by 3 1 Divided by 5", "1")]
        [DataRow("23 Divided by 3 23 Divided by 5", "23")]
        [DataRow("FizzBuzz", "15")]
        public void Test_Fizz(string Number1, string number)
        {
            var serviceProvider = new ServiceCollection()
                 .AddScoped<IFizzBuzzRepository, FizzBuzzRepository>()
             .AddLogging()
             .BuildServiceProvider();
            var fizzBuzzRepository = serviceProvider.GetService<IFizzBuzzRepository>();
            FizzBuzzController fizzBuzzController = new FizzBuzzController(fizzBuzzRepository);
            string result = fizzBuzzController.Get(number);
            Assert.AreEqual(Number1, result);
        }
    }
}