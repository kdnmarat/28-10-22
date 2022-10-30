using System.Collections.Generic;

namespace WindowsFormsApp2
{
    public class ContactDetails
    {
        public static List<ContactDetails> AllRecords { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
        public ContactDetails(string name, string street, string city, string state, string zip)
        {
            this.Name = name;
            this.Street = street;
            this.City = city;
            this.State = state;
            this.ZIP = zip;
        }
    }
}
