using App1.Model;
using Assisticant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class MainScreen : ViewModelLocatorBase
    {
        private readonly Main.AddressBookViewModel _addressBook;
        private readonly Func<Detail.PersonViewModel> _makePersonDetail;

        public MainScreen(
            Main.AddressBookViewModel addressBook,
            Func<Detail.PersonViewModel> makePersonDetail)
        {
            _addressBook = addressBook;
            _makePersonDetail = makePersonDetail;
        }

        public object AddressBook => ViewModel(() => _addressBook);
        public object PersonDetail => ViewModel(() => _makePersonDetail());
    }
}
