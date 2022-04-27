using Newtonsoft.Json;
using Proton.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Proton.Services
{
    internal class GenreService
    {
        public static async Task<GenreModel[]> AllGenresAsync()
        {
            string route = ConfigurationManager.AppSettings["SERVER"];
            var url = $"{route}/api/movie/genre";

            var client = new HttpClient();
            var res = await client.GetAsync(url);

            var data = await res.Content.ReadAsStringAsync();
            var genres = JsonConvert.DeserializeObject<GenreModel[]>(data);
            return genres;
        }
    }
}
