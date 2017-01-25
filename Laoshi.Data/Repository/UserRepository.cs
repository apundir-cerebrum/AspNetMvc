using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laoshi.Domain.Interfaces;
using Laoshi.Domain;
using Laoshi.Domain.Common;
using System.Data.SqlClient;
using System.Data;

namespace Laoshi.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        protected SqlConnection Conn;

        public UserRepository()
        {
            Conn = Connection.GetConnection;
        }
        public DataTable ValidateUserLoginDetails(UserLogin userLogin)
        {
            object[] myvalues = new object[2];
            myvalues[0] = userLogin.UserName;
            myvalues[1] = userLogin.Password;
            DataTable dtUserLogin = SqlHelper.ExecuteDataTable(Conn, DbConstants.USP_UserLoginValidate, myvalues);
            if (dtUserLogin != null && dtUserLogin.Rows.Count > 0)
                return dtUserLogin; 
            else
                return null;

        }

        public int SaveUserLoginDetails(UserLogin userLogin)
        {
            return 0;
        }
    }
}
