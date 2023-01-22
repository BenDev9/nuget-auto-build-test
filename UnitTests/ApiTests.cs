using ClassChartsApi.Api.Student;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace ClassChartsApiUnitTests
{
    static class Util
    {
        public static string GetConfigValue(string key)
        {
            var config = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json")
                        .Build();

            string? val = config[key];

            if(val == null) throw new ArgumentNullException($"{key} not found in app-config.json");
            else return val;
        }
    }

    [TestClass]
    public class BasicTests
    {
        [TestMethod]
        public void InstantiationTest()
        {
            // Create client
            StudentClient client = new StudentClient(Util.GetConfigValue("classcharts_code"), DateTime.Parse(Util.GetConfigValue("date_of_birth")));
            Assert.IsInstanceOfType(client, typeof(StudentClient));
        }

        [TestMethod]
        public void IdCheck()
        {
            // Create client
            StudentClient client = new StudentClient(Util.GetConfigValue("classcharts_code"), DateTime.Parse(Util.GetConfigValue("date_of_birth")));
            // Check null and details
            Assert.IsNotNull(client.Student);
            Assert.AreEqual(5045788, client.Student.Id);
        }
    }

    [TestClass]
    public class HomeworkTests
    {
        [TestMethod]
        public void DefualtHomeworkGet()
        {
            // Create client
            StudentClient client = new StudentClient(Util.GetConfigValue("classcharts_code"), DateTime.Parse(Util.GetConfigValue("date_of_birth")));
            Assert.IsNotNull(client.Student);

            // Get homeworks and check if it returned something
            var res = client.GetHomeworks().Result;
            Assert.IsNotNull(res);
            Assert.IsTrue(res.Count > 0);
        }

        [TestMethod]
        public void FromToHomeworkGet()
        {
            // Create client
            StudentClient client = new StudentClient(Util.GetConfigValue("classcharts_code"), DateTime.Parse(Util.GetConfigValue("date_of_birth")));
            Assert.IsNotNull(client.Student);

            //Set up from and to variables
            DateTime from = DateTime.Now.AddDays(-30);
            DateTime to = DateTime.Now.AddDays(7);

            // Get homeworks with args and check if it returned something
            var res = client.GetHomeworks(from, to).Result;
            Assert.IsNotNull(res);
            Assert.IsTrue(res.Count > 0);
        }
    }

    [TestClass]
    public class AnnouncementTests
    {
        [TestMethod]
        public void AnnouncementsGet() 
        {
            // Create client
            StudentClient client = new StudentClient(Util.GetConfigValue("classcharts_code"), DateTime.Parse(Util.GetConfigValue("date_of_birth")));
            Assert.IsNotNull(client.Student);

            // Get announcements and check if it returned something
            var res = client.GetAnnouncements().Result;
            Assert.IsNotNull(res);
            Assert.IsTrue(res.Count > 0);
        }
    }

    [TestClass]
    public class ActivityTests
    {
        [TestMethod]
        public void ActivityDefaultGet()
        {
            // Create client and check not null
            StudentClient client = new StudentClient(Util.GetConfigValue("classcharts_code"), DateTime.Parse(Util.GetConfigValue("date_of_birth")));
            Assert.IsNotNull(client.Student);

            // Get activity with the default timings
            var res = client.GetActivity().Result;
            Assert.IsNotNull(res);
            Assert.IsTrue(res.Count > 0);
        }

        [TestMethod]
        public void FromToActivityGet()
        {
            // Create client and check not null
            StudentClient client = new StudentClient(Util.GetConfigValue("classcharts_code"), DateTime.Parse(Util.GetConfigValue("date_of_birth")));
            Assert.IsNotNull(client.Student);

            //Set up from and to variables
            DateTime from = DateTime.Now.AddDays(-30);
            DateTime to = DateTime.Now.AddDays(7);

            // Get activity with the default timings
            var res = client.GetActivity(from, to).Result;
            Assert.IsNotNull(res);
            Assert.IsTrue(res.Count > 0);
        }
    }
}