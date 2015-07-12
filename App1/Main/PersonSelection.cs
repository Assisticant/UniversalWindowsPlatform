using App1.Model;
using Assisticant.Fields;

namespace App1.Main
{
    class PersonSelection
    {
        private Observable<Person> _selectedPerson = new Observable<Person>();

        public Person SelectedPerson
        {
            get { return _selectedPerson.Value; }
            set { _selectedPerson.Value = value; }
        }
    }
}