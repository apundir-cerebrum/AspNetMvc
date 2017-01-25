using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laoshi.Domain.Interfaces;
using Laoshi.Domain;

namespace Laoshi.Data.Repository
{
    public class RepositoryFactory:IRepositoryFactory
    {
        private readonly IConfiguration _config;

        public RepositoryFactory(IConfiguration config)
        {
            _config = config;
        }
        private IUserRepository _userRepository;
        public IUserRepository GetUserRepository()
        {
            return _userRepository ?? (_userRepository = new UserRepository());
        }
    }
}
