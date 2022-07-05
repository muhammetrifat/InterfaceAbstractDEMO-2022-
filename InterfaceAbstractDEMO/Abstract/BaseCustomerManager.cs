using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDEMO.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Veritabanına kaydedildi: " + customer.Name);
        }
    }
}
