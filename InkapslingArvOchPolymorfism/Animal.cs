using System;
using System.Collections.Generic;
using System.Text;

namespace InkapslingArvOchPolymorfism
{
    /*
     * 13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i
              vilken klass bör vi lägga det? ---> in i Bird klassen

    * 14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
             ---> in i Animal klassen (som kallas basklassen)
    *
     */

    abstract class Animal   // Abstract klass
    {
        // Abstract fält
        private string name;
        private int weight;
        private int age;

        // Abstract properties
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }


        // Abstract method (har ingen kropp)
        public abstract string DoSound();


        // Abstract Konstruktor
        public Animal(string name, int weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public virtual string Stats()
        {
            return $"Name: {Name}, Weight: {Weight} and Age: {Age}";
        }

    }

    class Horse : Animal
    {
        private bool isMoving;

        public bool IsMoving { get; set; }

        public Horse(bool isMoving, string name, int weight, int age) : base(name, weight, age)
        {
            this.IsMoving = isMoving;
            this.Name = "Horse";
            this.Weight = 200;
            this.Age = 25;
        }
        public override string DoSound()
        {
            return $"The horse says: neigh neigh";
        }

        public override string Stats()
        {
            return $"Horse is moving: {isMoving}, Name: {Name}, Weight: {Weight} and Age: {Age}";
        }
    }

    class Dog : Animal
    {
        private bool isEating;

        public bool IsEating { get; set; }

        public Dog(bool isEating, string name, int weight, int age) : base(name, weight, age)
        {
            this.IsEating = isEating;
            this.Name = "Dog";
            this.Weight = 56;
            this.Age = 10;
        }

        public override string DoSound()
        {
            return $"The dog says: Woof woof";

        }

        public override string Stats()
        {
            return $"Dog is eating: {isEating}, Name: {Name}, Weight: {Weight} and Age: {Age}";
        }


    }

    class Hedgehog : Animal
    {
        bool isSleeping;

        public bool IsSleeping { get; set; }

        public Hedgehog(bool isSleeping, string name, int weight, int age) : base(name, weight, age)
        {
            this.IsSleeping = isSleeping;
            this.Name = "Hedgehog";
            this.Weight = 1;
            this.Age = 3;
        }

        public override string DoSound()
        {
            return $"Hedgehog says: puf puf";
        }

        public override string Stats()
        {
            return $"Hedgehog is sleeping: {isSleeping}, Name: {Name}, Weight: {Weight} and Age: {Age}";
        }


    }

    class Worm : Animal
    {
        bool isPoisonous;

        public bool IsPoisonous { get; set; }

        public Worm(bool isPoisonous, string name, int weight, int age) : base(name, weight, age)
        {
            this.IsPoisonous = isPoisonous;
            this.Name = "Worm";
            this.Weight = 56;
            this.Age = 10;
        }

        public override string DoSound()
        {
            return $"Worm says: tak tak";
        }

        public override string Stats()
        {
            return $"Worm is poisonous: {isPoisonous}, Name: {Name}, Weight: {Weight} and Age: {Age}";
        }


    }

    class Bird : Animal
    {
        bool isFlying;

        public bool IsFlying { get; set; }

        public Bird(bool isFlying, string name, int weight, int age) : base(name, weight, age)
        {
            this.IsFlying = isFlying;
            this.Name = "Bird";
            this.Weight = 1;
            this.Age = 5;
        }

        public override string DoSound()
        {
            return $"The bird says: tweet tweet";
        }

        public override string Stats()
        {
            return $"Bird is flying: {isFlying}, Name: {Name}, Weight: {Weight} and Age: {Age}";
        }

    }

    class Wolf : Animal
    {
        bool isDangerous;
        public bool IsDangerous { get; set; }

        public Wolf(bool isDangerous, string name, int weight, int age) : base(name, weight, age)
        {
            this.IsDangerous = isDangerous;
            this.Name = "Wolf";
            this.Weight = 30;
            this.Age = 9;
        }

        public override string DoSound()
        {
            return $"The wolf says: owooooo";
        }
        public override string Stats()
        {
            return $"Wolf is dangerous: {isDangerous}, Name: {Name}, Weight: {Weight} and Age: {Age}";
        }
    }


    class Pelican : Bird
    {
        bool isSwimming;

        public bool IsSwimming { get; set; }

        public Pelican(bool isSwimming, bool isFlying, string name, int weight, int age) : base(isFlying, name, weight, age)
        {
            this.IsSwimming = isSwimming;
            this.IsFlying = isFlying;
            this.Name = "Wolf";
            this.Weight = 7;
            this.Age = 20;
        }

        public override string DoSound()
        {
            return base.DoSound();
        }

        public override string Stats()
        {
            return $"Pelican can swim: {isSwimming}, Pelican can fly: {IsFlying} Name: {Name}, Weight: {Weight} and Age: {Age}";
        }
    }



    class Flamingo : Bird
    {
        bool isMale;

        public bool IsMale { get; set; }

        public Flamingo(bool IsMale, bool isFlying, string name, int weight, int age) : base(isFlying, name, weight, age)
        {
            this.IsMale = isMale;
            this.IsFlying = isFlying;
            this.Name = "Flamingo";
            this.Weight = 5;
            this.Age = 20;
        }

        public override string DoSound()
        {
            return base.DoSound();
        }

        public override string Stats()
        {
            return $"This is a male Flamingo: {isMale}, Flamingo can fly: {IsFlying} Name: {Name}, Weight: {Weight} and Age: {Age}";
        }

    }

    class Swan : Bird
    {
        bool isDancing;

        public bool IsDancing { get; set; }

        public Swan(bool isDancing, bool isFlying, string name, int weight, int age) : base(isFlying, name, weight, age)
        {
            this.IsDancing = isDancing;
            this.IsFlying = isFlying;
            this.Name = "Swan";
            this.Weight = 10;
            this.Age = 5;
        }

        public override string DoSound()
        {
            return base.DoSound();
        }

        public override string Stats()
        {
            return $"Swan can dance: {isDancing}, Swan can fly: {IsFlying} Name: {Name}, Weight: {Weight} and Age: {Age}";
        }
    }

    public interface IPerson
    {
        string Talk();
    }

    class Wolfman : Wolf, IPerson
    {
        bool isPeaceful;

        public bool IsPeaceful { get; set; }

        public Wolfman(bool isPeaceful, bool isDangerous, string name, int weight, int age) : base(isDangerous, name, weight, age)
        {
            this.IsPeaceful = isPeaceful;
            this.IsDangerous = isDangerous;
            this.Name = "WolfMan";
            this.Weight = 95;
            this.Age = 45;
        }

        public string Talk()
        {
            return $"I am a WolfMan and I can talk";
        }
    }
}
