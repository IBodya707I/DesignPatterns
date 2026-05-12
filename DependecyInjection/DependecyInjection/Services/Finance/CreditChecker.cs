using DependecyInjection.Services.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInjection.Services.Finance
{
    internal class CreditChecker: ICreditChecker
    {
        private ILogger _logger;
        public CreditChecker(ILogger logger)
        {
            _logger = logger;
        }
        public bool CheckCredit(string customerName)
        {
            _logger.LogInfo($"Checking credit for customer: {customerName}");
            return true;
        }
    }
}
