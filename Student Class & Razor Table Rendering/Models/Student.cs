namespace Student_Class___Razor_Table_Rendering.Models
{
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public class Student
    {
        private string _firstName;
        private string _lastName;

        public string FirstName => _firstName;
        public string LastName => _lastName;

        public string Title { get; set; }
        public string Course { get; set; }
        public string Section { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; private set; } = Gender.Unknown;

        public Student()
        {
            _firstName = "John";
            _lastName = "Doe";
            Title = "Mr.";
            Course = "BSIT";
            Section = "1A";
            Birthday = new DateTime(2000, 1, 1);
        }

        public Student(string firstName, string lastName)
        {
            SetFirstName(firstName);
            SetLastName(lastName);
        }

        public void SetFirstName(string firstName) => _firstName = firstName;
        public void SetLastName(string lastName) => _lastName = lastName;
        public void SetGender(Gender gender) => Gender = gender;

        public string FullName => $"{Title} {FirstName} {LastName}";

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                int age = today.Year - Birthday.Year;
                if (Birthday > today.AddYears(-age)) age--;
                return age;
            }
        }
    }
}