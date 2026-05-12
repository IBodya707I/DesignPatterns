using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInjection.Services.Finance
{
    internal interface ICreditChecker
    {
        bool CheckCredit(string customerName);
    }
}
