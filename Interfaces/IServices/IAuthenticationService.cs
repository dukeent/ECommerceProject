using ECommerceProject.Models;

namespace ECommerceProject.Interfaces
{
    public interface IAuthenticationService
    {
        String Authenticate(string username, int roleID);

    }
}
