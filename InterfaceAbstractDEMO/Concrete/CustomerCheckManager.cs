using InterfaceAbstractDEMO.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDEMO.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckMernis(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
