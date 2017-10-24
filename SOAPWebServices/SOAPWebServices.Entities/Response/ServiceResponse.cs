using System.Runtime.Serialization;

namespace SOAPWebServices.Entities.Response
{
    [DataContract]
    public class ServiceResponse
    {
        private string firebaseid { get; set; }
        private string status { get; set; }

        [DataMember]
        public string FirebaseID
        {
            get => firebaseid;
            set => firebaseid = value;
        }

        [DataMember]
        public string Status
        {
            get => status;
            set => status = value;
        }

    }
}
