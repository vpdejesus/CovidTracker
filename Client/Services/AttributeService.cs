using System;
using System.Linq;
using System.Net.Http;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using Client.Models;
using Client.Helpers;

namespace Client.Services
{
    public class AttributeService
    {
        private readonly HttpClient _client;

        public AttributeService() 
        {
            _client = new HttpClient();
        }

        public async Task<List<Attributes>> GetAttributesAsync()
        {
            var attributes = new List<Attributes>();
            var uri = new Uri(string.Format(Constants.BaseApi, string.Empty));

            try
            {
                var response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    };

                    var content = await response.Content.ReadAsStringAsync();
                    var rootObject = JsonConvert.DeserializeObject<RootObject>(content, settings);
                    attributes = rootObject.Features.Select(f => f.Attributes).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return attributes;
        }
    }
}
