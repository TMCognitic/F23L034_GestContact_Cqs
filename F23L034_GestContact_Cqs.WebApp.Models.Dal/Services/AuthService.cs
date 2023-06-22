using F23L034_GestContact_Cqs.WebApp.Models.Dal.Entities;
using F23L034_GestContact_Cqs.WebApp.Models.Dal.Mappers;
using F23L034_GestContact_Cqs.WebApp.Models.Dal.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Ado;

namespace F23L034_GestContact_Cqs.WebApp.Models.Dal.Services
{
    public class AuthService : IAuthRepository
    {
        private readonly IDbConnection _dbConnection;

        public AuthService(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public Utilisateur? Login(string email, string passwd)
        {
            _dbConnection.Open();
            //Appeler la procédure CSP_Register
            Utilisateur? utilisateur = _dbConnection.ExecuteReader("CSP_Login", dr => dr.ToUtilisateur(), true, new { email, passwd }).SingleOrDefault();
            _dbConnection.Close();
            return utilisateur;
        }

        public void Register(Utilisateur utilisateur)
        {
            _dbConnection.Open();
            //Appeler la procédure CSP_Register
            _dbConnection.ExecuteNonQuery("CSP_Register", true, new { utilisateur.Nom, utilisateur.Prenom, utilisateur.Email, utilisateur.Passwd });
            _dbConnection.Close();
        }
    }
}
