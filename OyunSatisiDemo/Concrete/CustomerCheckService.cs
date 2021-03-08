using OyunSatisiDemo.Abstract;
using OyunSatisiDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace OyunSatisiDemo.Concrete
{
    public class CustomerCheckService : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //if (customer.FirstName=="Yusuf" && customer.LastName=="KOÇAK" && customer.BirthYear==1997 && customer.NationalityId==11111111111)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return true;
        }

     
    }
}
