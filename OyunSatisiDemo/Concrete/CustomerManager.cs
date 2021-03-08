using System;
using System.Collections.Generic;
using System.Text;
using OyunSatisiDemo.Abstract;
using OyunSatisiDemo.Entities;
using MernisServiceReference;
using OyunSatisiDemo.Adapters;

namespace OyunSatisiDemo.Concrete
{
    public class CustomerManager : ICustomerService
    {
        //ICustomerCheckService _customerCheckService;

        //public CustomerManager(ICustomerCheckService customerCheckService)
        //{
        //    _customerCheckService = customerCheckService;
        //}

        //public void Add(Customer customer)
        //{
        //    if (_customerCheckService.CheckIfRealPerson(customer)==true)
        //    {
        //        Console.WriteLine("Kayıt olma işlemi tamamlandı");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Eksik veya hatalı işlem yaptınız");
        //    }

        //}

        MernisServiceAdapter _mernisServiceAdapter;
        public CustomerManager(MernisServiceAdapter mernisServiceAdapter)
        {
            _mernisServiceAdapter = mernisServiceAdapter;
        }

        public void Add(Customer customer)
        {
            if (_mernisServiceAdapter.CheckIfRealPerson(customer) == true)
            {
                Console.WriteLine("Kayıt olma işlemi tamamlandı");
            }
            else
            {
                Console.WriteLine("Eksik veya hatalı işlem yaptınız");
            }
        }

            public void Delete(Customer customer)
        {
            Console.WriteLine("Silme işlemi tamamlandı");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Güncelleme işlemi tamamlandı");
        }
    }
}
