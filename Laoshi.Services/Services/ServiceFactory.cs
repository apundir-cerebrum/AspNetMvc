using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laoshi.Domain.Interfaces;

namespace Laoshi.Services
{
    public class ServiceFactory:IServiceFactory
    {
        private readonly IConfiguration _config;
       
        private readonly IRepositoryFactory _repositoryFactory;
        public ServiceFactory(IRepositoryFactory repositoryFactory, IConfiguration config)
        {
            _repositoryFactory = repositoryFactory;
            _config = config;
        }

        private IUserService _userService;
        public IUserService GetUserService()
        {
            return _userService ?? (_userService = new UserService(_repositoryFactory, this));
        }
    }
}
