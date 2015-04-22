using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FullContactApi
{
    public class FullContactApi : IFullContactApi
    {
        private readonly string mApiKey;
        private readonly TaskFactory mTaskFactory;

        public FullContactApi(string apiKey)
        {
            mApiKey = apiKey;
            mTaskFactory = new TaskFactory();
        }

        public async Task<FullContactPerson> LookupPersonByEmailAsync(string email)
        {
            //TODO: Check if valid result.
            var client = new HttpClient();
            string requestUri = "https://api.fullcontact.com/v2/person.json?email=" + email + "&apiKey=" + mApiKey;
            var res = await client.GetAsync(requestUri);
            var json = await res.Content.ReadAsStringAsync();
            var retValTask = mTaskFactory.StartNew(() => JsonConvert.DeserializeObject<FullContactPerson>(json));
            return await retValTask;
        }
    }
}
