using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GoogleBooks
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var url = $"https://www.googleapis.com/books/v1/volumes?q=käse";

            var http = new HttpClient();
            var json = await http.GetStringAsync(url);

            Books books = JsonConvert.DeserializeObject<Books>(json);

            foreach (var book in books.items)
            {
                Console.WriteLine($"{ book.volumeInfo.title} {book.saleInfo.listPrice?.amount} {book.saleInfo.listPrice?.currencyCode}");
            }

            Console.ReadKey();

        }
    }
}
