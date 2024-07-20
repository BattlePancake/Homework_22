namespace Homework_22.Models
{
    internal class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string CurrentAddress { get; set; }
        public string PermanentAddress { get; set; }

        public Person(string name, string email, string currentAddress, string permanentAddress)
        {
            Name = name;
            Email = email;
            CurrentAddress = currentAddress;
            PermanentAddress = permanentAddress;
        }
    }
}
