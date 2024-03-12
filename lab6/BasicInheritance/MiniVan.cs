using System;
namespace BasicInheritance
{
    //MiniVan derives from the car
    class MiniVan : Car
    {
        public void TestMethod()
        {
            //can access to the public member of the base class
            Speed = 10;
            //cannot access to the private member of the base
            //currSpeed = 11;//Error
        }
    }
}
