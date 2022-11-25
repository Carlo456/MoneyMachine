using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace MoneyMachine
{

    internal class Program
    {
        static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            CardHolder user1 = new CardHolder("6250941006528599", 1235, "Carlo Gustavo", "Valenzuela Zepeda", 200);            
            Action<object> getCardsInfo = (object card) =>
            {   
                if (card == null) {
                    Console.WriteLine("Why this is null?");
                } else
                {
                    Console.WriteLine("This shuldnt work?" + card);
                }
                
                
            };
            var fetchInfoTask = new Task(getCardsInfo, user1);
            fetchInfoTask.Start();

            Console.ReadLine();

        }
        
        public static async Task<string> FetchCardInfo()
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:8000/atm");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                return responseBody;
            }
            catch (HttpRequestException e)
            {
                return $"\nException Caught!\nMessage :{e.Message}";
                
            }
        }

    }
    
}