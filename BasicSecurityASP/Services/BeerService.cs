using BasicSecurityASP.Model;
using System.Text.Json;

namespace BasicSecurityASP.Services
{
    public class BeerService : IBeerService
    {
        string path = @"..\BasicSecurityASP\beers.json";
        
        public async Task<IEnumerable<Beer>> Get()
        {
            string content = await File.ReadAllTextAsync(path);

            var beers = JsonSerializer.Deserialize<List<Beer>>(content);

            return beers;

        }
    }
}
