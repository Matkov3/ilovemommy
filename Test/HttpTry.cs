
using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class HttpTry
    {
        [Test]
        public async Task ChekHttp()
        {
            var client = new HttpClient();

            var response = await client.GetAsync("https://ilovemommy.com.ua/ua/pizhama-2-5-let-2944000.html");

            var pageHtml = await response.Content.ReadAsStringAsync();

            // assert
            pageHtml.Should().Contain("Трикотажний комплект для хлопчика!");
        }
    }
}
