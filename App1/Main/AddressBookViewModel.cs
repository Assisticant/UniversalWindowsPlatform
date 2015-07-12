using App1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Main
{
    class AddressBookViewModel
    {
        private readonly AddressBook _addressBook;
        private readonly PersonSelection _personSelection;
        private readonly Func<Person, PersonViewModel> _makePersonViewModel;

        public AddressBookViewModel(
            AddressBook addressBook,
            PersonSelection personSelection,
            Func<Person, PersonViewModel> makePersonViewModel)
        {
            _addressBook = addressBook;
            _personSelection = personSelection;
            _makePersonViewModel = makePersonViewModel;
        }

        public IEnumerable<PersonViewModel> People =>
            from person in _addressBook.People
            orderby person.LastName, person.FirstName
            select _makePersonViewModel(person);

        public PersonViewModel SelectedPerson
        {
            get
            {
                if (_personSelection.SelectedPerson == null)
                    return null;
                return _makePersonViewModel(_personSelection.SelectedPerson);
            }
            set
            {
                _personSelection.SelectedPerson = value?.Person;
            }
        }

        public void AddPerson()
        {
            var person = _addressBook.NewPerson();
            _personSelection.SelectedPerson = person;
        }

        public bool CanDeletePerson => _personSelection.SelectedPerson != null;

        public void DeletePerson()
        {
            _addressBook.DeletePerson(_personSelection.SelectedPerson);
            _personSelection.SelectedPerson = null;
        }
    }
}
