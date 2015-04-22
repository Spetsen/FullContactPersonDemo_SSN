using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FullContactApi
{
    public class FullContactApi : IFullContactApi
    {
        private readonly string mApiKey;

        public FullContactApi(string apiKey)
        {
            mApiKey = apiKey;
        }

        public async Task<FullContactPerson> LookupPersonByEmailAsync(string email)
        {
            //TODO: Check if valid result.
            var client = new HttpClient();
            string requestUri = "https://api.fullcontact.com/v2/person.json?email=" + email + "&apiKey=" + mApiKey;
            var res = await client.GetAsync(requestUri);
            var json = await res.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<FullContactPerson>(json);
        }
    }
}
