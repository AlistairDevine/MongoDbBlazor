using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Shared.Models
{
    public class EmployeeDbContext
    {
        private readonly IMongoDatabase _mongoDatabase; 
        public EmployeeDbContext() 
        { 
            var client = new MongoClient("mongodb://localhost:27017"); 
            _mongoDatabase = client.GetDatabase("EmployeeDB"); 
        }
        public IMongoCollection<Employee> EmployeeRecord 
        { 
            get { return _mongoDatabase.GetCollection<Employee>("EmployeeRecord"); } 
        }
        public IMongoCollection<Cities> CityRecord 
        { 
            get { return _mongoDatabase.GetCollection<Cities>("Cities"); } 
        }
    }
}
