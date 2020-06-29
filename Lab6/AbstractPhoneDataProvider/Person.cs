using System.Runtime.Serialization;

namespace AbstractPhoneDataProvider
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Phone { get; set; }
       
    }
}