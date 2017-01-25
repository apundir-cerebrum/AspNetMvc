using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laoshi.Domain.Interfaces;
using Laoshi.Domain;
using System.Data;
using Laoshi.Domain.Common;

namespace Laoshi.Services
{
    public class UserService : IUserService
    {

        private readonly IRepositoryFactory _repositoryFactory;
        private readonly IServiceFactory _servicesFactory;

        public UserService(IRepositoryFactory repositoryFactory, IServiceFactory servicesFactory)
        {
            _repositoryFactory = repositoryFactory;
            _servicesFactory = servicesFactory;
        }

        private IUserRepository _userRepository
        {
            get { return _repositoryFactory.GetUserRepository(); }
        }
        public UserLogin ValidateUserLoginDetails(UserLogin userLogin)
        {
            DataTable dtUserLogin = _userRepository.ValidateUserLoginDetails(userLogin);
            if (dtUserLogin != null && dtUserLogin.Rows.Count > 0)
                return CollectionHelper.ConvertTo<UserLogin>(dtUserLogin).FirstOrDefault();
            else
                return null;
        }
        public int SaveUserLoginDetails(UserLogin userLogin)
        {
            return 0;
        }
    }
}
