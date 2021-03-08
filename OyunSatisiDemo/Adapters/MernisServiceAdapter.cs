using System;
using System.Collections.Generic;
using System.Text;
using OyunSatisiDemo.Abstract;
using OyunSatisiDemo.Entities;
using OyunSatisiDemo.Concrete;
using MernisServiceReference;


namespace OyunSatisiDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
         (new TCKimlikNoDogrulaRequest
         (new TCKimlikNoDogrulaRequestBody(customer.NationalityId,
         customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.BirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
