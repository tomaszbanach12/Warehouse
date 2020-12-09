using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace WarehouseXUnitTestProject
{
    //1) arrange - prepare to the tests
    //2) act - testing application logic
    //3) assert - make sure that the application logic is what we expect
    public class HttpResponseTest
    {
        public async Task<string> GetHttpResponse(string userAgent, string userName, string repoName)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add(userAgent, repoName);
            string msg = string.Format("https://api.github.com/repos/{0}/{1}", userName, repoName);
            string jsonString = await httpClient.GetAsync(msg).Result.Content.ReadAsStringAsync();

            return jsonString;
        }

        [Fact]
        void Returns_Response()
        {
            string response = GetHttpResponse("user-agent", "tomislav21", "Warehouse").Result;
            Assert.NotEmpty(response);
        }

        [Fact]
        void ReturnsJson_Response()
        {
            string response = GetHttpResponse("user-agent", "tomislav21", "Warehouse").Result;
            var exception = Record.Exception(() => JObject.Parse(response));
            Assert.Null(exception);
        }
    }
}
