using IssPosition.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssPosition.Databasen
{
    
    public class IIssDbFacade
    {
        private readonly IssPositionDbContext _context;
        public IIssDbFacade(IssPositionDbContext context)
        {
            _context = context;
        }

        public async Task SavePositionAsync(JObject jsonData)
        {
            var jsonDataRecord = new CurrentPositionData { DataAsJObject = jsonData };
            _context.JsonDatas.Add(jsonDataRecord);
            await _context.SaveChangesAsync();
        }
    }
}
