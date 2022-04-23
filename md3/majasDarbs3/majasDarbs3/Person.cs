namespace majasDarbs3
{
    public class Person
    {
        public Person(string name, string surname, DateTime dateOfBirth, string gender)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;  
            Gender = gender;    
        }

        public string Name { get;}
        public string Surname { get; }
        public DateTime DateOfBirth { get;}
        public string Hobby { get; set; }
        public string Gender { get; }

       public void Greeting()
        {
            Console.WriteLine($"Sveicināti, {Name} {Surname}");
        }

        public void CalculateAge()
        {           
            int age = DateTime.Now.Year - DateOfBirth.Year;
            Console.WriteLine($"Jūsu vecums ir (vai šogad būs!) {age} gadi!");
        }
    }

}
