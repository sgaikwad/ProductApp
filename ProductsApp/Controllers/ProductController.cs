using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductController : ApiController
    {
        public SearchRs Get()
        {
            string url = "http://api.cokecce.com/v1/product/search?query=%2AFANTA%2A&maxRows=20&language=EN&format=json&apiKey=uqjnugxp66c2qs6tburyy42b";

            SearchRs searchResponse = new SearchRs();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);

            // Add an Accept header for JSON format.

            // List data response.
            HttpResponseMessage response = client.GetAsync(url).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var products = response.Content.ReadAsAsync<Rootobject>().Result;
                searchResponse.Products = products;
                searchResponse.Status = true;
            }
            else
            {
                searchResponse.Status = false;
                //                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            return searchResponse;
        }


        public SearchRs GetByName(string name)
        {
            //string url = "http://api.cokecce.com/v1/product/search?query=%2AFANTA%2A&maxRows=20&language=EN&format=json&apiKey=uqjnugxp66c2qs6tburyy42b";

            string url = string.Format("{0}?query=*{1}*&maxRows={2}&language={3}&format={4}&apiKey={5}", "http://api.cokecce.com/v1/product/search", name, "20", "EN", "json", "uqjnugxp66c2qs6tburyy42b");

            SearchRs searchResponse = new SearchRs();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);

            // Add an Accept header for JSON format.

            // List data response.
            HttpResponseMessage response = client.GetAsync(url).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var products = response.Content.ReadAsAsync<Rootobject>().Result;
                searchResponse.Products = products;
                searchResponse.Status = true;
            }
            else
            {
                searchResponse.Status = false;
                //                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            return searchResponse;
        }
    }
}
