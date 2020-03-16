using FYMApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using IDatabase = FYMApp.Services.Interfaces.IDatabase;

namespace FYMApp.Services
{
    public class CareGiverDataBase : IDatabase
    {
        private readonly SQLiteAsyncConnection database;

        public CareGiverDataBase()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "products.db3");
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<User>().Wait();

        }

        public Task<List<CareGiverDetails>> GetCareGivers()
        {
            return database.Table<CareGiverDetails>().ToListAsync();
        }

        public Task<int> SaveUserAsync(User user)
        {
            return database.InsertAsync(user);
        }
    }
}
