using System;
using System.Collections.Generic;
using System.Text;
using OyunSatisiDemo.Concrete;
using OyunSatisiDemo.Entities;
using MernisServiceReference;

namespace OyunSatisiDemo.Abstract
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
    }
}
