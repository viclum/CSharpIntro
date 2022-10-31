using System;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!"); 
            Student student1 = new Student();
            student1.FirstName = "John";
            student1.DisplayName();
        }
    }

    class Student
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }

        }

        

        public void DisplayName()
        {
            Console.WriteLine(firstName);
        }
    }
}
