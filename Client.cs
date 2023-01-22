using ClassChartsApi.Api.Dataclasses;
using ClassChartsApi.Dataclasses;
using ClassChartsApi.Errors;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassChartsApi.Api.Student
{
    public class StudentClient {

        public StudentData? Student { get; set; }

        private ClasschartsHTTPClient httpClient;

        public StudentClient(string _student_code, DateTime dob)
        {
            httpClient = new ClasschartsHTTPClient(_student_code, dob);
            var loginData = httpClient.Login();
            Student = loginData.Data;
        }

        /// <summary>
        /// Returns homeworks set in the recent past (1 month)
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ClassChartsAPIAuthenticationError"></exception>
        public async Task<List<Homework>> GetHomeworks()
        {
            //Set up from and to variables
            DateTime from = DateTime.Now.AddDays(-30);
            DateTime to = DateTime.Now.AddDays(7);

            // Check if we're logged in, raise error if not
            if (Student == null) throw new ClassChartsAPIAuthenticationError("User not logged in");

            // Construct url
            string url = $"/homeworks/{Student.Id}?display_date=due_date"
                        +$"&from={from.ToString("yyy-MM-dd")}" 
                        +$"&to={to.ToString("yyy-MM-dd")}";

            // Get the json from the http response
            string json = await (await httpClient.AuthorizedRequest(HttpMethod.Post, url)).Content.ReadAsStringAsync();

            var data = JsonSerializer.Deserialize<HomeworkReturn>(json);

            if (data == null || data.Data == null) throw new ClassChartsAPIParsingException("An error occurred whilst parsing Homework");

            return data.Data;
        }

        public async Task<List<Homework>> GetHomeworks(DateTime from, DateTime to)
        {
            // Check if we're logged in, raise error if not
            if (Student == null) throw new ClassChartsAPIAuthenticationError("User not logged in");

            // Construct url
            string url = $"/homeworks/{Student.Id}?display_date=due_date"
                        + $"&from={from.ToString("yyy-MM-dd")}"
                        + $"&to={to.ToString("yyy-MM-dd")}";

            // Get the json from the http response
            string json = await(await httpClient.AuthorizedRequest(HttpMethod.Post, url)).Content.ReadAsStringAsync();

            var data = JsonSerializer.Deserialize<HomeworkReturn>(json);

            if (data == null || data.Data == null) throw new ClassChartsAPIParsingException("An error occurred whilst parsing Homework");

            return data.Data;
        }

        public async Task<List<Announcement>> GetAnnouncements()
        {
            // Check if we're logged in, raise error if not
            if (Student == null) throw new ClassChartsAPIAuthenticationError("User not logged in");

            // Construct url
            string url = $"/announcements/{Student.Id}";

            // Get json from http response
            string json = await (await httpClient.AuthorizedRequest(HttpMethod.Get, url)).Content.ReadAsStringAsync();

            var data = JsonSerializer.Deserialize<AnnouncementsReturn>(json);

            if (data == null || data.Data == null) throw new ClassChartsAPIParsingException("An error occurred whilst parsing Announcements");

            return data.Data;
        }

        public async Task<List<ActivityPoint>> GetActivity()
        {
            // Check if we're logged in, raise error if not
            if (Student == null) throw new ClassChartsAPIAuthenticationError("User not logged in");

            //Set up from and to variables
            DateTime from = DateTime.Now.AddDays(-30);
            DateTime to = DateTime.Now.AddDays(7);

            // Construct url
            string url = $"/activity/{Student.Id}?" +
                         $"from={from.ToString("yyy-MM-dd")}&" +
                         $"to={to.ToString("yyy-MM-dd")}";

            // Get json from http response
            string json = await(await httpClient.AuthorizedRequest(HttpMethod.Get, url)).Content.ReadAsStringAsync();

            var data = JsonSerializer.Deserialize<ActivityReturn>(json);

            if (data == null || data.Data == null) throw new ClassChartsAPIParsingException("An error occurred whilst parsing Announcements");

            return data.Data;
        }

        public async Task<List<ActivityPoint>> GetActivity(DateTime from, DateTime to)
        {
            // Check if we're logged in, raise error if not
            if (Student == null) throw new ClassChartsAPIAuthenticationError("User not logged in");

            // Construct url
            string url = $"/activity/{Student.Id}?" +
                         $"from={from.ToString("yyy-MM-dd")}&" +
                         $"to={to.ToString("yyy-MM-dd")}";

            // Get json from http response
            string json = await(await httpClient.AuthorizedRequest(HttpMethod.Get, url)).Content.ReadAsStringAsync();

            var data = JsonSerializer.Deserialize<ActivityReturn>(json);

            if (data == null || data.Data == null) throw new ClassChartsAPIParsingException("An error occurred whilst parsing Announcements");

            return data.Data;
        }
    }
}
