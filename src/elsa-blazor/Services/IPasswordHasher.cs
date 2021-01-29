using elsa_blazor.Models;

namespace elsa_blazor.Services
{
    public interface IPasswordHasher
    {
        HashedPassword HashPassword(string password);
        HashedPassword HashPassword(string password, byte[] salt);
    }
}
