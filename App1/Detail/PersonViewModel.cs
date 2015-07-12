using App1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Detail
{
    class PersonViewModel
    {
        private readonly Person _person;

        public PersonViewModel(Person person)
        {
            _person = person;
        }

        public string FirstName
        {
            get { return _person.FirstName; }
            set { _person.FirstName = value; }
        }

        public string LastName
        {
            get { return _person.LastName; }
            set { _person.LastName = value; }
        }
    }
}
