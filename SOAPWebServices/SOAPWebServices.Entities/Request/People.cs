using System;
using System.Runtime.Serialization;


namespace SOAPWebServices.Entities
{
    [DataContract]
    public class People
    {
        private Guid uuid { get; set; }
        private string name { get; set; }
        private string gender { get; set; }
        private string image { get; set; }

        [DataMember]
        public Guid UUID
        {
            get => uuid;
            set => uuid = value;
        }

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
