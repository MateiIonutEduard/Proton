using System;
using System.IO;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Proton.Data;
using System.Resources;
using System.Drawing;

namespace Proton.Services
{
    internal class MovieService
    {
        public static async Task<Movie[]> PopularMoviesAsync()
        {
            string route = ConfigurationManager.AppSettings["SERVER"];
            var url = $"{route}/api/movie/";

            var client = new HttpClient();
            var res = await client.GetAsync(url);

            var data = await res.Content.ReadAsStringAsync();
            var movies = JsonConvert.DeserializeObject<Movie[]>(data);
            return movies;
        }

        public static async Task<Movie> GetMovieAsync(string id)
        {
            string route = ConfigurationManager.AppSettings["SERVER"];
            var url = $"{route}/api/movie/{id}";

            var client = new HttpClient();
            var res = await client.GetAsync(url);

            var data = await res.Content.ReadAsStringAsync();
            var movie = JsonConvert.DeserializeObject<Movie>(data);
            return movie;
        }

        public static async Task<MovieModel> FindMoviesAsync(SearchModel model)
        {
            string route = ConfigurationManager.AppSettings["SERVER"];
            string url = $"{route}/api/movie/";
            var client = new HttpClient();

            var data = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("title", model.title)
            };

            foreach (var genre in model.genres)
                data.Add(new KeyValuePair<string, string>("genres", genre));

            var formData = new FormUrlEncodedContent(data);
            var res = await client.PostAsync(url, formData);
            var json = await res.Content.ReadAsStringAsync();

            var models = JsonConvert.DeserializeObject<MovieModel>(json);
            return models;
        }

        public static async Task<MovieModel> FindMoviesByPageAsync(int page, SearchModel model)
        {
            string route = ConfigurationManager.AppSettings["SERVER"];
            string url = $"{route}/api/movie/?page={page}";
            var client = new HttpClient();

            var data = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("title", model.title)
            };

            foreach (var genre in model.genres)
                data.Add(new KeyValuePair<string, string>("genres", genre));

            var formData = new FormUrlEncodedContent(data);
            var res = await client.PostAsync(url, formData);
            var json = await res.Content.ReadAsStringAsync();

            var models = JsonConvert.DeserializeObject<MovieModel>(json);
            return models;
        }

        public static async Task<Bitmap> GetCaptureAsync(string url, bool first = true)
        {
            if (!string.IsNullOrEmpty(url))
            {
                var client = new HttpClient();
                var res = await client.GetAsync(url);

                if (res.IsSuccessStatusCode)
                {
                    var buffer = await res.Content.ReadAsStreamAsync();
                    var bmp = new Bitmap(buffer);
                    return bmp;
                }
            }

            var resx = new ResourceManager("Proton.Resources", typeof(Proton.Resources).Assembly);

            if (first)
            {
                var capture = (Bitmap)resx.GetObject("cinema");
                return capture;
            }

            var logo = (Bitmap)resx.GetObject("logo");
            return logo;
        }
    }
}
