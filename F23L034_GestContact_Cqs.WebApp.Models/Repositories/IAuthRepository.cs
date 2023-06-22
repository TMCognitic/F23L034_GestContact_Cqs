using F23L034_GestContact_Cqs.WebApp.Models.Commands;
using F23L034_GestContact_Cqs.WebApp.Models.Entities;
using F23L034_GestContact_Cqs.WebApp.Models.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;
using Tools.Cqs.Queries;

namespace F23L034_GestContact_Cqs.WebApp.Models.Repositories
{
    public interface IAuthRepository : 
        ICommandHandler<RegisterCommand>,
        IQueryHandler<LoginQuery, Utilisateur?>
    {
    }
}
