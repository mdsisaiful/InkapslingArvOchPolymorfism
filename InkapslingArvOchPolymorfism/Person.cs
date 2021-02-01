using System;
using System.Collections.Generic;
using System.Text;

namespace InkapslingArvOchPolymorfism
{
    public class Person
    {
        /*
         * 1. kommer du direkt åt variablerna? --- Nej, jag åt dom genom dess properties.
         */

        // Privata fält
        private int age;
        private string fName;
        private string lName;
        private int height;
        private int weight;

        // Publika properties för age fält
        public int Age
        {
            get => this.age;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be less than 0 or null");
                }
                this.age = value;
            }
        }

        // Publika properties för fName fält
        public string FName
        {
            get => this.fName;
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("First name cannot be less than 2 or greater than 10");
                }
                else if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty");
                }
                this.fName = value;
            }
        }

        // Publika properties för lName fält
        public string LName
        {
            get => this.lName;
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Last name cannot be less than 3 or greater than 15");
                }
                else if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty");
                }
                this.lName = value;
            }
        }

        // Publika properties för Height och Weight fält
        public int Height { get; set; }
        public int Weight { get; set; }

        // Konstruktor

        public Person(int age, string firstName, string lastName, int height, int weight)
        {
            Age = age;
            FName = firstName;
            LName = lastName;
            Height = height;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Age: {Age}, FName: {FName}, LName: {LName}, Height: {Height}, Weight: {Weight}";
        }
    }
}
