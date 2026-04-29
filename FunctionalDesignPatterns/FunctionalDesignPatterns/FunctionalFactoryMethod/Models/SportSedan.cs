using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalDesignPatterns.FunctionalFactoryMethod.Models
{
    internal class SportSedan: ICar
    {
        public string Description()
        {
            return "Sport sedan";
        }
    }
}
