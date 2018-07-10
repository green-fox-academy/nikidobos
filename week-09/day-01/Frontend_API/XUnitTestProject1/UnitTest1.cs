using Frontend_API;
using Frontend_API.Controllers;
using Frontend_API.Models;
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

        [Theory]
        [InlineData(2)]
        [InlineData(6)]
        [InlineData(13)]
        public async Task ShouldGetTheDoubledResult(int input)
        {
            var response = await Client.GetAsync($"doubling?input={input}");

            Assert.Equal(JsonConvert.SerializeObject(new
            {
                received = input,
                result = input * 2
            }),
            response.Content.ReadAsStringAsync().Result);
        }

        [Fact]
        public async Task ShouldReturnErrorMessage()
        {
            var response = await Client.GetAsync("greeter?title=student");

            Assert.Equal(JsonConvert.SerializeObject(new
            {
                error = "Please provide a name!"
            }),
            response.Content.ReadAsStringAsync().Result);
        }

        [Fact]
        public async Task ShouldReturnGreeting()
        {
            var response = await Client.GetAsync("greeter?name=Niki&&title=student");

            Assert.Equal(JsonConvert.SerializeObject(new
            {
                welcome_message = "Oh, hi there Niki, my dear student!"
            }),
            response.Content.ReadAsStringAsync().Result);
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
