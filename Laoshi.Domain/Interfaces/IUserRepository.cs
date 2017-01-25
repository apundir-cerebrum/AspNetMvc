using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laoshi.Domain;
using System.Data;

namespace Laoshi.Domain.Interfaces
{
    public interface IUserRepository
    {
         int SaveUserLoginDetails(UserLogin userLogin);
         DataTable ValidateUserLoginDetails(UserLogin userLogin);
    }
}
