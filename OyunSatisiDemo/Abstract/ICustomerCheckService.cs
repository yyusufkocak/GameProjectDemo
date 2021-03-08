using System;
using System.Collections.Generic;
using System.Text;
using OyunSatisiDemo.Concrete;
using OyunSatisiDemo.Entities;
using MernisServiceReference;

namespace OyunSatisiDemo.Abstract
{
   public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);  
    }
}
