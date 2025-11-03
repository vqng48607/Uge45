namespace Opgave26
{

    public class Person
    {
        private FirstName firstName;
        private LastName lastName;
        private Age age;
        private CprNumber cpr;

        public Person(FirstName firstName, LastName lastName, Age age, CprNumber cpr)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.cpr = cpr;
        }

        public string GetFirstName() => firstName.GetValue();
        public string GetLastName() => lastName.GetValue();
        public int GetAge() => age.GetValue();
        public string GetCprNumber() => cpr.GetValue();
    }
}