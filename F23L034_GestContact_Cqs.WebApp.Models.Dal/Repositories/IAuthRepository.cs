using F23L034_GestContact_Cqs.WebApp.Models.Dal.Entities;

namespace F23L034_GestContact_Cqs.WebApp.Models.Dal.Repositories
{
    public interface IAuthRepository
    {
        void Register(Utilisateur utilisateur);
        Utilisateur? Login(string email, string passwd);
    }
}
