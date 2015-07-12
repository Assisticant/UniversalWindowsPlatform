using App1.Model;

namespace App1.Main
{
    class PersonViewModel
    {
        private readonly Person _person;

        public PersonViewModel(Person person)
        {
            _person = person;
        }

        public Person Person => _person;

        public string Name => (string.IsNullOrWhiteSpace(_person.LastName) && string.IsNullOrWhiteSpace(_person.FirstName))
            ? "<person>"
            : $"{_person.LastName}, {_person.FirstName}";

        public override bool Equals(object obj)
        {
            PersonViewModel that = obj as PersonViewModel;
            if (that == this)
                return true;
            if (that == null)
                return false;

            return that._person == this._person;
        }

        public override int GetHashCode()
        {
            return _person.GetHashCode();
        }
    }
}