using System;
using System.Collections.Generic;

namespace InkapslingArvOchPolymorfism
{
    /// <summary>
    /// Hantera Inkapsling, Arv och Polymorfism med olika klasser
    /// </summary>
    class Program
    {
        static PersonHandler personHandler = new PersonHandler();


        // Main metod
        static void Main(string[] args)
        {
            //DummyUserInput();
            DummyPersonInput();


            do
            {
                GetUserInput();
                UserAction();

            } while (true);

        }



        private static void DummyPersonInput()
        {
            try
            {
                var person1 = personHandler.CreatePerson(44, "Alicia", "Silverstone", 177, 52);
                //var person2 = personHandler.CreatePerson(57, "Brad", "Pitt", 181, 83);

                personHandler.SetAge(person1, 28);
                //Console.WriteLine(person1.Age);
                personHandler.AddPerson(person1);
                //personHandler.AddPerson(person2);
                Console.WriteLine();

            }

            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

        }

        private static void UserAction()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    AddPersonData();
                    break;
                case "2":
                    PrintPerson();
                    break;
                case "3":
                    PrintAnimal();
                    break;
                case "4":
                    PrintUserError();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input! Please try again...\n");
                    break;
            }
        }

        private static void PrintUserError()
        {
            List<UserError> userErrors = new List<UserError>();

            NumericInputError numericInputError = new NumericInputError();
            TextInputError textInputError = new TextInputError();
            BadRequestError badRequestError = new BadRequestError();

            userErrors.Add(numericInputError);
            userErrors.Add(textInputError);
            userErrors.Add(badRequestError);

            foreach (UserError userError in userErrors)
            {

                Console.WriteLine(userError.UEMessage());
            }
            Console.WriteLine();
        }

        // Input prompt från konsol
        private static void AddPersonData()
        {
            while (true)
            {
                int age, height, weight;
                string firstName, lastName;

                try
                {
                    Console.WriteLine("Please enter your age:");
                    string input = Console.ReadLine();
                    age = int.Parse(input);
                    if (age <= 0)
                    {
                        throw new ArgumentException("Age cannot be less than 0 or null");
                    }
                    if (input.Equals("Q")) break;
                    Console.WriteLine("Please enter your first name:");
                    firstName = Console.ReadLine();
                    if (firstName.Length < 2 || firstName.Length > 10)
                    {
                        throw new ArgumentException("First name cannot be less than 2 or greater than 10");
                    }

                    Console.WriteLine("Please enter your last name:");
                    lastName = Console.ReadLine();
                    if (lastName.Length < 3 || lastName.Length > 15)
                    {
                        throw new ArgumentException("Last name cannot be less than 3 or greater than 15");
                    }
                    Console.WriteLine("Please enter your height:");
                    string input1 = Console.ReadLine();
                    Console.WriteLine("Please enter your weight:");
                    string input2 = Console.ReadLine();
                    height = int.Parse(input1);
                    weight = int.Parse(input2);
                    //personHandler.AddPerson(age, firstName, lastName, height, weight);

                    Console.WriteLine("Hi there! Here is your personal data:");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine($"Age: {age}");
                    Console.WriteLine($"First name: {firstName}");
                    Console.WriteLine($"Last name: {lastName}");
                    Console.WriteLine($"Height: {height}");
                    Console.WriteLine($"Weight: {weight}");

                    Console.WriteLine();
                    Console.WriteLine("Please press Q to Quit or Continue");
                    string quit = Console.ReadLine();
                    if (quit == "Q")
                    {
                        break;
                    }

                    Console.WriteLine();

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        private static void PrintPerson()
        {
            Person[] persons = personHandler.GetPerson();
            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
        }

        private static void PrintAnimal()
        {
            //DummyAnimalINput();
            List<Animal> animals = new List<Animal>();
            animals.Add(new Horse(true, "Horse", 201, 26));
            animals.Add(new Dog(true, "Dog", 57, 11));
            animals.Add(new Wolfman(true, false, "WolfMan", 90, 50));

            foreach (Animal animal in animals)
            {
                //Console.WriteLine(animal);
                Console.WriteLine(animal.Stats());
                // Är instansen animal en IPerson?
                if (animal is IPerson)
                {
                    // Unsafe cast Exception
                    IPerson iPerson = (IPerson)animal;
                    Console.WriteLine(iPerson.Talk());
                }
                else if (animal is Animal)
                {
                    Console.WriteLine(animal.DoSound());
                }

            }
            Console.WriteLine();

            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog(true, "Dog", 56, 11));
            //dogs.Add(new Dog(false, "Dog", 57, 10));

            foreach (Animal dog in dogs)
            {
                Console.WriteLine(dog.DoSound());
            }
            Console.WriteLine();

            /*
             * 9. F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
             *          --> Det fungerar inte eftersom både hourse och hund ärvs från olika klasser.
             
             * 10. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
             *          --> Listan måste tillhör med Animal type (basklassen).
             
             * 16. Kommer du åt den metoden från Animals listan?
                        --> Nej

             * 17. F: Varför inte? 
                        --> Eftersom den här metoder gäller bara hundar klassen

            * 11. F: Varför är polymorfism viktigt att behärska?
                        --> Polymorfism är den tredje pelaren i objektorienterad programmering 
                            och det är viktigt att behärska för att kunna använda objekt på 
                            många sätt instället på ett sätt.

            * 12. F: Hur kan polymorfism förändra och förbättra kod via en bra struktur?
                        --> Genom att gå djupare in i polymorfismparadigmet och behärska 
                            konceptet med dess funktioner och hur man implementerar objekt 
                            i olika former.

            * 13. F: Vad är det för en skillnad på en Abstrakt klass och ett Interface?
                        -->En Interface kan inte innehålla en "konstruktör" men en abstrakt klass kan ha.
            * 
             */

        }

        //private static void PrintPerson()
        //{
        //    Person[] persons = personHandler.GetPerson();


        //    foreach (Person person in persons)
        //    {
        //        Console.WriteLine(person);
        //    }
        //}

        private static void GetUserInput()
        {
            Console.WriteLine("Welcome to the Person database!");
            Console.WriteLine("Please choose one of the following item, thank you.");
            Console.WriteLine("\n1) Add personal data manually");
            Console.WriteLine("2) Print personal data from the program");
            Console.WriteLine("3) Print animal data from the program");
            Console.WriteLine("4) Print user error");
            Console.WriteLine("5) Exit!\n");
        }


        //private static void DummyUserInput()
        //{
        //    personHandler.AddPerson(30, "Markus", "Johansson", 180, 72);
        //    personHandler.AddPerson(26, "Sana", "Svensson", 172, 52);
        //    personHandler.AddPerson(20, "Lovisa", "Eriksson", 168, 55);
        //    Console.WriteLine();
        //}


    }
}
