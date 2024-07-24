using FizzBuzzAPI.Controllers;
using FizzBuzzAPI.Repository;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace M_Test
{
    [TestClass]
    public class MockTest
    {
        [TestMethod]
        public void TestArray()
        {
            string[] inputs = new string[] { "", "3", "5","15","a","2" };
            string[] tests = new string[] { "Invalid Item", "Fizz", "Buzz", "FizzBuzz", "Invalid Item", "2 Divided by 3 2 Divided by 5" };;

            var serviceProvider = new ServiceCollection()
               .AddScoped<IFizzBuzzRepository, FizzBuzzRepository>()
           .AddLogging()
           .BuildServiceProvider();
            var fizzBuzzRepository = serviceProvider.GetService<IFizzBuzzRepository>();
            FizzBuzzController fizzBuzzController = new FizzBuzzController(fizzBuzzRepository);
            IEnumerable<string> result = fizzBuzzController.Get(inputs.ToList());

            Assert.IsNotNull(result);
            bool check = false;
            if (result != null)
            {
                check = AreArraysEqual(tests, result.ToArray());
            }
            Assert.AreEqual(true, check);
        }

        // Returns true if arr1[0..n-1] and
        // arr2[0..m-1] contain same elements.
        private bool AreArraysEqual(string[] arr1, string[] arr2)
        {
            // If lengths of array are not
            // equal means array are not equal
            if (arr1.Length == 0 || arr2.Length == 0 || arr1.Length != arr1.Length)
                return false;

            // Sort both arrays
            Array.Sort(arr1);
            Array.Sort(arr2);

            // Linearly compare elements
            for (int i = 0; i < arr1.Length; i++)
                if (arr1[i] != arr2[i])
                    return false;

            // If all elements were same.
            return true;
        }
    }
}