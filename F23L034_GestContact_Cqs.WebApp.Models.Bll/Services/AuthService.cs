using F23L034_GestContact_Cqs.WebApp.Models.Bll.Entities;
using F23L034_GestContact_Cqs.WebApp.Models.Bll.Mappers;
using F23L034_GestContact_Cqs.WebApp.Models.Bll.Repositories;
using IAuthDalRepository = F23L034_GestContact_Cqs.WebApp.Models.Dal.Repositories.IAuthRepository;

namespace F23L034_GestContact_Cqs.WebApp.Models.Bll.Services
{
    public class AuthService : IAuthRepository
    {
        private readonly IAuthDalRepository _dalRepository;

        public AuthService(IAuthDalRepository dalRepository)
        {
            _dalRepository = dalRepository;
        }

        public Utilisateur? Login(string email, string passwd)
        {
            return _dalRepository.Login(email, passwd)?.ToBll();
        }

        public void Register(Utilisateur utilisateur)
        {
            _dalRepository.Register(utilisateur.ToDal());
        }
    }
}
