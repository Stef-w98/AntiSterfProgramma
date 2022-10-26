using AntiSterfProgramma.Model;
using Java.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AntiSterfProgramma.API
{
    public static class APIService
    {
        public static string LocalIp = "http://192.168.0.254:7175/api/";
        public static User testidc = new User();
        public static async Task<bool> GetUsers()
        {
            try
            {
                var HttpClient = new HttpClient();
                var Response = await HttpClient.GetStringAsync($"{LocalIp}User");
                var fuckthisshit = JsonConvert.DeserializeObject<User>(Response);
                testidc.Email = fuckthisshit.Email;
                return true;
            }
            catch(System.Exception e)
            {
                return false;
            }

        }

        public static async Task<Weight> GetWeight()
        {
            var HttpClient = new HttpClient();
            var Response = await HttpClient.GetStringAsync($"{LocalIp}Weight");
            var test = JsonConvert.DeserializeObject<Weight>(Response);
            return test;
        }

        public static async Task<HttpResponseMessage> PostUserLogin(User obj)
        {
            var HttpClient = new HttpClient();
            Task<HttpResponseMessage> responseMessage = HttpClient.PostAsJsonAsync($"{LocalIp}User", obj);
            return responseMessage.Result;
        }

        public static async Task<HttpResponseMessage> PostRegisterUser(User obj)
        {
            var HttpClient = new HttpClient();
            Task<HttpResponseMessage> responseMessage = HttpClient.PostAsJsonAsync($"{LocalIp}RegisterUser", obj);
            return responseMessage.Result;
        }


        //public async Task<User> GetUsers()
        //{
        //    var HttpClient = new HttpClient();
        //    var Response = await HttpClient.GetStringAsync("http://192.168.0.145:7175/api/User");

        //    return JsonConvert.DeserializeObject<User>(Response);
        //}
    }
}
