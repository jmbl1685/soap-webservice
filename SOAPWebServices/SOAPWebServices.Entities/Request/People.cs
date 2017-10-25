using System;
using System.Runtime.Serialization;


namespace SOAPWebServices.Entities
{
    [DataContract]
    public class People
    {       
        private string name { get; set; }
        private string gender { get; set; }
        private string image { get; set; }

        [DataMember]
        public string Name
        {
            get => name;
            set => name = value;
        }

        [DataMember]
        public string Gender
        {
            get => gender;
            set => gender = value;
        }

        [DataMember]
        public string Image
        {
            get => image;
            set => image = value;
        }

    }

}
