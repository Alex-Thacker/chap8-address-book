using System.Collections.Generic;

namespace trycatch {
    public class AddressBook{
        Dictionary <string, Contact> contactDictionary { get; set; } = new Dictionary <string, Contact> ();
        public void AddContact (Contact person) {
            contactDictionary.Add(person.Email, person);
        }
        public Contact GetByEmail (string email) {
            return contactDictionary[email]; 
        }
    }
}