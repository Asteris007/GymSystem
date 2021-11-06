using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2
{
    class UserTest2
    {
        public bool Login(String user, String pwd)
        {

            String userU = "admin";
            String pwdU = "admin";

            return (0 == String.Compare(user, userU) && 0 == String.Compare(pwd, pwdU));
        }
        }
}
