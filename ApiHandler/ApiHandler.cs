namespace IssPosition.Api;

using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Diagnostics;
using System.Threading.Tasks;


public class ApiHandler
{
    private readonly HttpClient _httpClient;



    public ApiHandler()
    {
        //_httpClient = httpClient;

        HttpClientHandler httpHandler = new HttpClientHandler();
        httpHandler.UseDefaultCredentials = true;

        _httpClient = new HttpClient(httpHandler);
        _httpClient.Timeout = TimeSpan.FromSeconds(30);

    }

    public async Task<string?> SendRequestAsync(string url)
    {
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            Debug.WriteLine($"The response I want is " + response.StatusCode);

            string responseBody = await response.Content.ReadAsStringAsync();

            //responseBody = testSend;

            return responseBody;
        }
        catch (HttpRequestException)
        {
            Console.WriteLine("Test");

            return null;
        }

    }

    public async Task<JObject?> GetDataAsync(string url)
    {
        // Todo: Take the response from SendRequest and create a JObject of it if it's not null, otherwise return null

        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            Debug.WriteLine($"Getting the json response" + response.StatusCode);

            string responseBody = await response.Content.ReadAsStringAsync();

            JObject jsonResponse = JObject.Parse(responseBody);

            return jsonResponse;
        }
        catch (HttpRequestException)
        {
            Console.WriteLine("Test");

            return null;
        }

    }

}

