using Newtonsoft.Json.Linq;
using RestSharp;
using System;

namespace TestFramework.API
{
    public class RestAPI
    {
        public void GetApiMethod()  // Get value from a source
        {
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com");
            RestRequest requests = new RestRequest("/posts", Method.Get);
            // HttpBasicAuthenticator auth = new HttpBasicAuthenticator("jj", "dfd");
            RestResponse response = client.ExecuteGet(requests);
            string content = response.Content;
            JArray value = JArray.Parse(content);
            Console.WriteLine(value.ToString());
        }

        public void PostApiMethod()  // Create a resource
        {
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com");
            RestRequest requests = new RestRequest("/posts", Method.Post);
            JObject payload = new JObject();
            payload.Add("title", "Sample email");
            payload.Add("body", "test");
            payload.Add("userId", "10");
            payload.Add("it", "101");
            requests.AddJsonBody(payload.ToString());
            RestResponse response = client.ExecutePost(requests);
        }
    }
}