using FYMApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FYMApp.Services
{
    class LoginService
    {
        readonly RestClient<User> _restClient = new RestClient<User>();
        public async Task<bool> CheckLoginIfExists(string email, string password)
        {
            var check = await _restClient.CheckLogin(email, password);
            return check;
        }
    }
}
