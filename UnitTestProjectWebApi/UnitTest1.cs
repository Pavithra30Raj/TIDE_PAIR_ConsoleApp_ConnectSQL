using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TideWebAPI.Controllers;

namespace UnitTestProjectWebApi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestController()
        {
            ILoggerFactory factory = new LoggerFactory();
            ILogger<WeatherForecastController> log = new Logger<WeatherForecastController>(factory);
            WeatherForecastController test = new WeatherForecastController(log);

            string s = test.Get();
            Assert.AreEqual(s, "Hello World!");

        }
    }
}