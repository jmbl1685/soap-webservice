using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebSite.Service;
using WebSite.Service.WebService.SOAP_Firebase;

namespace WebSite.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void SoapServiceTest()
        {
            SoapService webServicesCall = new SoapService();

            People people = new People()
            {
                Gender = "Male",
                Name = "Radamel Falcao",
                Image = "https://informe360.com/deportes/wp-content/uploads/2017/02/falcao-500x500_c.jpg"
            };

            var responseAddPeople = webServicesCall.AddPeople(people);
            string key = responseAddPeople.FirebaseID;

            var responseGetPeople = webServicesCall.GetPeople();
            var responseGetByIDPeople = webServicesCall.GetByIDPeople(key);
            var responseUpdatePeople = webServicesCall.UpdatePeople(key,people);
            var responseRemovePeople = webServicesCall.RemovePeople(key);

            Assert.IsNotNull(responseAddPeople);
            Assert.AreEqual("OK",responseAddPeople.Status);
            Assert.IsNotNull(responseGetPeople);
            Assert.IsNotNull(responseGetByIDPeople);
            Assert.IsNotNull(responseUpdatePeople);

            // TODO: Pending to check.
            Assert.AreEqual(null, responseRemovePeople);


        }
    }
}
