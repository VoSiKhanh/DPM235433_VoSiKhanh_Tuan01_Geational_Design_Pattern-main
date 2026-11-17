using System;
using DPM235433_VoSiKhanh_Tuan01_Abstract_DP.Products;

namespace DPM235433_VoSiKhanh_Tuan01_Abstract_DP.Factories
{
    // Each Concrete Factory has a corresponding product variant.
    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
