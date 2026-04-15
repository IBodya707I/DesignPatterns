using System;
using System.Collections.Generic;
using System.Text;

namespace LR3.BehavioralPatterns.IteratorWarehouse
{
    internal interface ICarIterator
    {
        Car CurrentItem();
        bool HasNext();
        Car Next();
    }
}
