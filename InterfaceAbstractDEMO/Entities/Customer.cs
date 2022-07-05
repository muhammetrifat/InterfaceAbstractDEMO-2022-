﻿using InterfaceAbstractDEMO.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDEMO
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
