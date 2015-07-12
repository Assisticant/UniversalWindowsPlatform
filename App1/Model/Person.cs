using Assisticant.Fields;

namespace App1.Model
{
    class Person
    {
        private Observable<string> _firstName = new Observable<string>();
        private Observable<string> _lastName = new Observable<string>();

        public string FirstName
        {
            get { return _firstName.Value; }
            set { _firstName.Value = value; }
        }

        public string LastName
        {
            get { return _lastName.Value; }
            set { _lastName.Value = value; }
        }
    }
}