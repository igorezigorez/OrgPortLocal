using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrgPort.Model;

namespace OrgPort.Data
{
    public interface IUserRepository
    {
        UserInfo GetUser(int id);
        bool ValidateUser(string name, string password);
        UserInfo CreateUser(UserInfo userInfo);
    }
}
