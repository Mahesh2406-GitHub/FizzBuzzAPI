namespace FizzBuzzAPI.Repository
{
    public class FizzBuzzRepository : IFizzBuzzRepository
    {
        private static readonly string[] Summaries = new[]
     {
          "Invalid Item", "Fizz", "Buzz"
        };
        public string Calculator(string value)
        {

            string summary = Summaries[0];
            var isNumeric = int.TryParse(value, out int number);

            if (!isNumeric || string.IsNullOrEmpty(value))
            {
                summary = Summaries[0];
            }
            else
            {
                if ((number % 3 == 0) && (number % 5 == 0))
                {
                    summary = Summaries[1] + Summaries[2];
                }
                else if (number % 3 == 0)
                {
                    summary = Summaries[1];
                }
                else if (number % 5 == 0)
                {
                    summary = Summaries[2];
                }
                else
                {
                    string modWithThree = number + " Divided by 3 ";
                    string modWithFive = number + " Divided by 5";
                    summary = Convert.ToString(modWithThree + modWithFive);
                }
            }
            return summary;
        }
    }
}
