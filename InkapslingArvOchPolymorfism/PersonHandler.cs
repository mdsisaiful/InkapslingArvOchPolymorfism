using System;
using System.Collections.Generic;
using System.Text;

namespace InkapslingArvOchPolymorfism
{
    class PersonHandler
    {
        // PersonHandler -klassen skapa metoden enligt övning nedan

        // Inskickad personens Age property för att sätta personens age-attribut via SetAge-metoden
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        // Inskickad personens FName property för att sätta personens fName-attribut via SetFName-metoden
        public void SetFName(Person pers, string fName)
        {
            pers.FName = fName;
        }

        // Inskickad personens LName property för att sätta personens LName-attribut via SetLName-metoden
        public void SetLName(Person pers, string lName)
        {
            pers.LName = lName;
        }

        // Inskickad personens Height property för att sätta personens height-attribut via SetHeight-metoden
        public void SetHeight(Person pers, int height)
        {
            pers.Height = height;
        }

        // Inskickad personens Weight property för att sätta personens weight-attribut via SetWeight-metoden
        public void SetWeight(Person pers, int weight)
        {
            pers.Weight = weight;
        }



        private List<Person> personManage;

        public PersonHandler()
        {
            personManage = new List<Person>();
        }

        public Person[] GetPerson()
        {
            return personManage.ToArray();
        }



        //internal void AddPerson(int age, string fName, string lName, int height, int weight)
        //{
        //    personManage.Add(new Person(age, fName, lName, height, weight));
        //}



        // Skapar en person med angivna värden

        public Person CreatePerson(int age, string fName, string lName,
            int height, int weight)
        {
            Person person = new Person(age, fName, lName, height, weight);

            return person;
        }

        internal void AddPerson(Person person1)
        {
            personManage.Add(person1);

        }

    }
}
