using DependecyInjection.Services.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInjection.Services.Documents
{
    internal class DocumentProcessor: IDocumentProcessor
    {
        private IPrinterService printerService;
        public DocumentProcessor(IPrinterService printerService)
        {
            this.printerService = printerService;
        }
        public string GenerateDocument(string customerName, string vin)
        {
            var document = $"Document for {customerName} with VIN: {vin}";
            printerService.Print(document);
            return document;
        }
    }
}
