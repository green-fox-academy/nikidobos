using Frontend_API;
using Frontend_API.Controllers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private HttpClient Client { get; set; }
        private TestServer Server { get; set; }

        public UnitTest1()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ShouldGetOKResponse()
        {
            var response = await Client.GetAsync("/doubling");
            var statusCode = response.StatusCode;
            Assert.Equal(HttpStatusCode.OK, statusCode);
        }

        [Fact]
        public async Task ShouldGetNotFound()
        {
            var response = await Client.GetAsync("/doubling2");
            var statusCode = response.StatusCode;
            Assert.Equal(HttpStatusCode.NotFound, statusCode);
        }

        [Fact]
        public async Task ShouldGetKutya()
        {
            var response = await Client.GetAsync("appenda/{appendable}");
            var codeMonk = JsonConvert.DeserializeObject<HomeController>(await response.Content.ReadAsStringAsync());
            Assert.NotEqual("kutya", "kuty");
        }

    }
}
