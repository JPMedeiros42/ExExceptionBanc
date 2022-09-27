using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExExceptionBanc.Entities.Exceptions
{
    class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message)
        {
        }
    }
}
