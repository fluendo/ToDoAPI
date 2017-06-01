using Newtonsoft.Json;
using NSUtils.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ToDo.Core.ViewModels.Services.Interfaces;
using TodoApi.Models;

namespace ToDo.Core.ViewModels.Services
{
    public class Networking : INetworking
    {
        private const string URL = "http://localhost:8080/api/todo";

        public async Task<bool> Add(TodoItem item)
        {
            var body = JsonConvert.SerializeObject(item);
            var response = await new HttpCalls().PostAsync(URL, body);

            if(response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public async Task<IEnumerable<TodoItem>> All()
        {
            var response = await new HttpCalls().GetAsync(URL);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var jsonResponse = new StreamReader(response.ResponseStream).ReadToEnd();

                return JsonConvert.DeserializeObject<List<TodoItem>>(jsonResponse);
            }
            else
            {
                return new List<TodoItem>();
            }
        }

        public async Task<bool> Delete(TodoItem item)
        {
            var body = JsonConvert.SerializeObject(item);
            
            var response = await new HttpCalls().DeleteAsync(URL, Encoding.UTF8.GetBytes(body));

            if(response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        public async Task<bool> Update(TodoItem item)
        {
            var body = JsonConvert.SerializeObject(item);

            var response = await new HttpCalls().PutAsync(URL, Encoding.UTF8.GetBytes(body));

            if(response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
