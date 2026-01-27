
using ProyectoGenOmint.Models;

namespace ProyectoGenOmint.Services.Interface
{
    public interface ILoginService
    {
        bool Login(LoginRequest request);
    }
}
