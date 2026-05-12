using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInjection.Services.Documents
{
    internal interface IDocumentProcessor
    {
        string GenerateDocument(string customerName, string vin);
    }
}
