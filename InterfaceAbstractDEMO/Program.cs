using InterfaceAbstractDEMO.Abstract;
using InterfaceAbstractDEMO.Concrete;
using System;

namespace InterfaceAbstractDEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();

            customerManager.Save(new Customer { 
                DateOfBirth = new DateTime(1997,9,20)
                , Id = 1
                , Name = "Muhammed"
                , LastName = "Türkmen"
                , NationalityId = "11111111111" 
            });
        }
    }
}
