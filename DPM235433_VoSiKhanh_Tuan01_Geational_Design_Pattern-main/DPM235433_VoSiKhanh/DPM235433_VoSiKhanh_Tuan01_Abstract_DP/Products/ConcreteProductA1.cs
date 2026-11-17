using System;

namespace DPM235433_VoSiKhanh_Tuan01_Abstract_DP.Products
{
    // Concrete Products are created by corresponding Concrete Factories.
    class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A1.";
        }
    }
}
