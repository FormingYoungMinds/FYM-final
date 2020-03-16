using FYMApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FYMApp.Services.Interfaces
{
    public interface IDatabase
    {
        Task<int> SaveUserAsync(User user);

        Task SaveStudentDetailsAsync(int savedDetails);
    }
}
