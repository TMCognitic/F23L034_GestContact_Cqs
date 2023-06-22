using F23L034_GestContact_Cqs.WebApp.Models.Bll.Entities;

namespace F23L034_GestContact_Cqs.WebApp.Models.Bll.Repositories
{
    public interface IAuthRepository
    {
        void Register(Utilisateur utilisateur);
        Utilisateur? Login(string email, string passwd);
    }
}
