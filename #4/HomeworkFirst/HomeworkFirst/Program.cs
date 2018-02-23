using System;

namespace HomeworkFirst
{
        interface IPerson
    {
        string GetFullName();
        int GetAge();
        
    }

    public class Student : IPerson
    {
        int dateOfBirth;
        int currentYear;
        int age;
        public int GetAge()
        {
            age = currentYear - dateOfBirth;
            return age;
        }

        string firstName;
        string lastName;
        string fullName;
     
        public string GetFullName()
        {
            fullName = firstName + lastName;
            return fullName;
        }
    }

    class Professor : IPerson
    {
        int age;
        public int GetAge()
        {
            Console.WriteLine("Professor's age is "+age);
            return age;
        }

        string fullName;
        public string GetFullName()
        {
            string professorName = "Prof. " + fullName;
            return professorName;
        }
    }

    class A
    {
        private readonly IPerson _person;

        public A (IPerson person)
        {
            _person = person;
        }
        public void Call ()
        {
           _person.GetAge();
           _person.GetFullName();
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {

            var myPerson = new A(new Student());
            myPerson.Call();
            // First:
            // 1) Create an Interface with multiple method templates. 
              // 2) Create two or more implementations (classes) for that interface.
            // 3) Create a class (A) that accept these interfaces as an array into constructor.
            // 4) Pass in two or more interfaces into class (A).
            // 5) Call a method of class (A) which calls all passed in interfaces methods.
                // I.E. Interface has method print(), when you call class (A) method print 
                // it will call print method on all interfaces passed in the constructor.
            
            // Second:
            // Do the same thing only using delegates (Func, Action);

            // Note: this time we have manual testing by you :)
        }
    }
}
