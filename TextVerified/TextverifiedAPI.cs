using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextVerified
{
    class TextverifiedAPI
    {
        public static string DoAuth(string requesturl, string tokenkey)
        {
            var client = new RestClient(requesturl);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Basic " + tokenkey);
            IRestResponse response = client.Execute(request);

            dynamic results = JsonConvert.DeserializeObject(response.Content);
            Console.WriteLine(results);
            return results.bearer_token;
        }

        public static dynamic DoPost(string requesturl, string bearertoken, string method)
        {
            var client = new RestClient(requesturl);
            var request = new RestRequest(Method.GET);
            if (method == "POST")
            {
                request = new RestRequest(Method.POST);
            }

            request.AddHeader("Authorization", "Bearer " + bearertoken);
            IRestResponse response = client.Execute(request);

            dynamic results = JsonConvert.DeserializeObject(response.Content);
            Console.WriteLine(results);
            return results;
        }
    }
}
