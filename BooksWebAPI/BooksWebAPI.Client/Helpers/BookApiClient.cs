using BooksWebAPI.Client.Interfaces;
using BooksWebAPI.Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace BooksWebAPI.Client.Helpers
{
    public class BookApiClient : IBookApiClient
    {
        private HttpClient client;

        public BookApiClient()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:65428/");
        }

        public async Task<BookVm> GetBookById(string id)
        {
            BookVm apiResult = null;
            var response = await client.GetAsync("api/books/GetByBookId/" + id);

            if (response.IsSuccessStatusCode)
            {
                var stream = await response.Content.ReadAsStreamAsync();
                using (var reader = new StreamReader(stream))
                {
                    apiResult = JsonConvert.DeserializeObject<BookVm>(reader.ReadToEnd());
                }
            }
            return apiResult;
        }

        public async Task<List<BookVm>> GetBooksByTitle(string title)
        {
            List<BookVm> apiResult = new List<BookVm>();
            var response = await client.GetAsync("api/books/GetByBookTitle/" + title);

            if (response.IsSuccessStatusCode)
            {
                var stream = await response.Content.ReadAsStreamAsync();
                using (var reader = new StreamReader(stream))
                {
                    apiResult = JsonConvert.DeserializeObject<List<BookVm>>(reader.ReadToEnd());
                }
            }
            return apiResult;
        }
    }
}