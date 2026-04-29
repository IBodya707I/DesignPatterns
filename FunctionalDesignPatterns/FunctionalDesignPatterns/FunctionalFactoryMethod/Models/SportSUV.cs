using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalDesignPatterns.FunctionalFactoryMethod.Models
{
    internal class SportSUV: ICar
    {
        public string Description()
        {
            return "Sport SUV";
        }
    }
}
