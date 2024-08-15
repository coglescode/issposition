namespace IssPosition;

using IssPosition.Api;
using IssPosition.Databasen;
using IssPosition.Models;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;


using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class CallApi
{

    public async Task<CurrentPositionData?> CallAsyncApi()
    {
        ApiHandler apiHandler = new ApiHandler();

        string url = $"https://api.wheretheiss.at/v1/satellites/25544";

        var request = await apiHandler.SendRequestAsync(url);

        JObject? positionDataResponse = await apiHandler.GetDataAsync(url);

        if (positionDataResponse == null)
        {
            return null;
        }

        string id = positionDataResponse["id"]?.ToString() ?? "";
        string name = positionDataResponse["name"]?.ToString() ?? "";
        string latitude = positionDataResponse["latitude"]?.ToString() ?? "";
        string longitude = positionDataResponse["longitude"]?.ToString() ?? "";
        string altitude = positionDataResponse["altitude"]?.ToString() ?? "";
        string velocity = positionDataResponse["velocity"]?.ToString() ?? "";   
        string visibility = positionDataResponse["visibility"]?.ToString() ?? "";
        string footprint = positionDataResponse["footprint"]?.ToString() ?? "";
        string timestamp = positionDataResponse["timestamp"]?.ToString() ?? "";

        CurrentPositionData currentPosition = new(id, name, latitude, longitude, altitude, velocity, visibility, footprint, timestamp); 

        PrintPositionData(currentPosition);

        return currentPosition;
    }

    private static void PrintPositionData(CurrentPositionData positionData)
    {
        // Todo: Skriv ut informationen om karaktären

        Console.WriteLine($"{positionData.ID}");
        Console.WriteLine($"{positionData.Name}");
        Console.WriteLine($"{positionData.Latitude}");
        Console.WriteLine($"{positionData.Longitude}");
        Console.WriteLine($"{positionData.Altitude}");
        Console.WriteLine($"{positionData.Velocity}");
        Console.WriteLine($"{positionData.Visibility}");
        Console.WriteLine($"{positionData.Footprint}");
        Console.WriteLine($"{positionData.Timestamp}");

    }

}

