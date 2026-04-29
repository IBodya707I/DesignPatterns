using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalDesignPatterns.FunctionalFactoryMethod.Models
{
    internal class ComfortSedan: ICar
    {
        public string Description()
        {
            return "Comfort sedan";
        }
    }
}
