using IssPosition.Databasen;

namespace IssPosition;


internal class Program
{
    public static async Task Main(string[] args)
    {

        CallApi callApi = new CallApi();
        await callApi.CallAsyncApi();

    }

    //static void Main(string[] args)
    //{
    //    //Console.WriteLine("Hello, World!");

    //    //using (var db = new IssPositionDbContext())
    //    //{
    //    //    db.CurrentPositions.Add(new Models.CurrentPositionData { Name = "ISS", Latitude = "100", Longitude = "500", Altitude = "800", });
    //    //    db.SaveChanges();

    //    //}

        

    //}
}
