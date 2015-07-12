using Assisticant.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Model
{
    class AddressBook
    {
        private ObservableList<Person> _people = new ObservableList<Person>();

        public IEnumerable<Person> People => _people;

        public Person NewPerson()
        {
            var person = new Person();
            _people.Add(person);
            return person;
        }

        public void DeletePerson(Person person)
        {
            _people.Remove(person);
        }
    }
}
