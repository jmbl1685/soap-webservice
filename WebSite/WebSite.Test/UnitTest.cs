using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebSite.Service;

namespace WebSite.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public async Task SoapServiceTest()
        {
            SoapService soap = new SoapService();
            var request = String.Format(@"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:soap=""soap"" xmlns:soap1=""http://schemas.datacontract.org/2004/07/SOAPWebServices.Entities""><soapenv:Header/><soapenv:Body><soap:Post><soap:people><soap1:Gender>Male</soap1:Gender><soap1:Image>james.png</soap1:Image><soap1:Name>James Rodriguez</soap1:Name></soap:people></soap:Post></soapenv:Body></soapenv:Envelope>");
            var response = await soap.PostXmlRequest("http://localhost:8089/SOAPWebServices.Core/WebService.svc?wsdl", request);
            
        }
    }
}
