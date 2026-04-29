using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalDesignPatterns.FunctionalFactoryMethod.Models
{
    internal class ComfortSUV: ICar
    {
        public string Description()
        {
            return "Comfort SUV";
        }
    }
}
