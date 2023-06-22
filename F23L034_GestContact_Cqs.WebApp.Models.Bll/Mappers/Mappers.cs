using F23L034_GestContact_Cqs.WebApp.Models.Bll.Entities;
using DalUtilisateur = F23L034_GestContact_Cqs.WebApp.Models.Dal.Entities.Utilisateur;

namespace F23L034_GestContact_Cqs.WebApp.Models.Bll.Mappers
{
    internal static class Mappers
    {
        internal static DalUtilisateur ToDal(this Utilisateur utilisateur)
        {
            DalUtilisateur u = new DalUtilisateur()
            {
                Id = utilisateur.Id,
                Nom = utilisateur.Nom,
                Prenom = utilisateur.Prenom,
                Email = utilisateur.Email,
                Passwd = utilisateur.Passwd
            };
            utilisateur.Passwd = null;
            return u;
        }

        internal static Utilisateur ToBll(this DalUtilisateur utilisateur)
        {
            return new Utilisateur(utilisateur.Id, utilisateur.Nom, utilisateur.Prenom, utilisateur.Email);
        }
    }
}
