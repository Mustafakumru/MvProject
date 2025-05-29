using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Net.Http.Headers;
namespace Rapidapi.consum.Controllers
{
    public class BookingController : Controller
    {
        public async Task<IActionResult> Index()
        {
            
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?page_number=0&include_adjacency=true&children_ages=5%2C0&room_number=1&adults_number=2&children_number=2&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&checkout_date=2025-10-14&dest_id=-553173&units=metric&dest_type=city&checkin_date=2025-10-13&locale=en-gb&order_by=popularity&filter_by_currency=AED"),
                Headers =
    {
        { "x-rapidapi-key", "96215e6292msh9497db0443262d0p1bdb90jsn03dcb8c0410e" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                
                return View();
            }
        }
    }
}
