using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laoshi.Domain;

namespace Laoshi.Domain.Interfaces
{
   public interface IUserService
    {
       int SaveUserLoginDetails(UserLogin userLogin);
       UserLogin ValidateUserLoginDetails(UserLogin userLogin);

        
    }
}
