using System;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!"); 
            Student student1 = new Student("John", "Tan");
            //student1.FirstName = "John";
            // change LastName to some name
            student1.DisplayName();
            Console.WriteLine(student1);
        }
    }

    class Student
    {
        private string firstName;
        private string lastName;

        public Student(string fn, string ln)
        {
            FirstName = fn;
            lastName = ln;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }

        }

        // property for LastName

        public void DisplayName()
        {
            Console.WriteLine(firstName);
            // display lastName
        }

        public override string ToString()
        {
            return "FirstName:" + FirstName + " LastName:" + lastName;
        }

    }
}
