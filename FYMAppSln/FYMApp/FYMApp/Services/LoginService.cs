using FYMApp.Models;
using System.Threading.Tasks;

namespace FYMApp.Services
{
    class LoginService
    {
        readonly RestClient<User> _restClient = new RestClient<User>();
        public async Task<bool> CheckLoginIfExists(int cellnumber, string password)
        {
            var check = await _restClient.CheckLogin(cellnumber, password);
            return check;
        }
    }
}