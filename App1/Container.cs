using App1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Container
    {
        private readonly MainScreen _mainScreen;

        public Container()
        {
            var addressBook = new AddressBook();
            var personSelection = new Main.PersonSelection();

            Func<Person, Main.PersonViewModel> makePersonViewModel = person => new Main.PersonViewModel(person);

            var addressBookViewModel = new Main.AddressBookViewModel(addressBook, personSelection, makePersonViewModel);

            Func<Detail.PersonViewModel> makePersonDetail = delegate
            {
                if (personSelection.SelectedPerson == null)
                    return null;
                return new Detail.PersonViewModel(personSelection.SelectedPerson);
            };

            _mainScreen = new MainScreen(addressBookViewModel, makePersonDetail);
        }

        public MainScreen MainScreen => _mainScreen;
    }
}
