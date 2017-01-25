using Laoshi.Domain.Common;
using Laoshi.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Laoshi.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    [NinjectBehaviorAttribute]
    public class UserService : IUserService
    {
        private readonly IRepositoryFactory _repositoryFactory;

        public UserService(IRepositoryFactory repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;

        }


        private IUserRepository _userService
        {
            get { return _repositoryFactory.GetUserRepository(); }
        }
        public response<UserLogin> ValidateUserLogin(string username, string password)
        {
            List<UserLogin> oUserLogin = new List<UserLogin>();
            DataTable dtUserLogin = _userService.ValidateUserLoginDetails(new Domain.UserLogin() { UserName = username, Password = password });
            response<UserLogin> objResponse = new response<UserLogin>();
            if (dtUserLogin != null && dtUserLogin.Rows.Count > 0)
            {
                objResponse.code = Convert.ToInt16(ResponseStatus.Success);
                objResponse.status = ResponseStatus.Success.ToString();
                objResponse.result = CollectionHelper.ConvertTo<UserLogin>(dtUserLogin);
                return objResponse;

            }
            else
                return null;
            
        }
    }
}
