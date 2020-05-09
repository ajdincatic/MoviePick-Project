using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using MoviePick.Data;
using MoviePick.WindowsFormsUI.Properties;

namespace eProdaja.WinUI
{
    public class APIService
    {
        public static string username;
        public static string password;
        private string _resource;
        private string _extension;
        public int _value;
        public string endpoint = $"{Resources.ApiUrl}";

        public APIService(string resource)
        {
            _resource = resource;
        }

        public APIService(string resource, string extenstion, int val)
        {
            _resource = resource;
            _extension = extenstion;
            _value = val;
        }

        public async Task<T> GetAll<T>(object searchRequest = null)
        {
            var query = "";
            if (searchRequest != null)
            {
                query = await searchRequest?.ToQueryString();
            }

            if(_extension != null)
            {
                var list = await $"{endpoint}{_resource}/{_value}/{_extension}?{query}"
                    .WithBasicAuth(username, password)
                    .GetJsonAsync<T>();
                return list;
            }
            else
            {
                var list = await $"{endpoint}{_resource}?{query}"
                    .WithBasicAuth(username, password)
                    .GetJsonAsync<T>();
                return list;
            }

        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{endpoint}{_resource}/{id}";

            return await url
                .WithBasicAuth(username, password)
                .GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{endpoint}{_resource}";

            try
            {
                if (_extension != null)
                {
                    var list = await $"{endpoint}{_resource}/{_value}/{_extension}"
                        .WithBasicAuth(username, password)
                        .PostJsonAsync(request)
                        .ReceiveJson<T>();
                    return list;
                }

                return await url
                    .WithBasicAuth(username, password)
                    .PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }

        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{endpoint}{_resource}/{id}";

                return await url
                    .WithBasicAuth(username, password)
                    .PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }

        public async Task<T> Delete<T>(int id, object request = null)
        {
            try
            {
                if (request != null)
                {
                    var query = await request?.ToQueryString();
                    var list = await $"{endpoint}{_resource}/{_value}/{_extension}?{query}"
                        .WithBasicAuth(username, password)
                        .DeleteAsync()
                        .ReceiveJson<T>();
                    return list;
                }

                return await $"{endpoint}{_resource}/{id}"
                    .WithBasicAuth(username, password)
                    .DeleteAsync().ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }
    }
}
