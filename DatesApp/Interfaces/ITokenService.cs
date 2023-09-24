using DatesApp.Entities;

namespace DatesApp.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
