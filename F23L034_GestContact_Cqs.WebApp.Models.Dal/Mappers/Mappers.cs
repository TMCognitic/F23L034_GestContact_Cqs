using F23L034_GestContact_Cqs.WebApp.Models.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F23L034_GestContact_Cqs.WebApp.Models.Dal.Mappers
{
    internal static class Mappers
    {
        internal static Utilisateur ToUtilisateur(this IDataRecord record)
        {
            return new Utilisateur()
            {
                Id = (int)record["Id"],
                Nom = (string)record["Nom"],
                Prenom = (string)record["Prenom"],
                Email = (string)record["Email"],
            };
        }
    }
}
