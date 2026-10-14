using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationPartTwo
{
    internal class Person
    {

        // Instance variables
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        //Constructor for the person class
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.salary += this.salary * percentage/100;
            }
            else
            {
                this.salary += this.salary * percentage/200;
            }

        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} recieves {this.Salary} dollars.";
        }
    }
}
