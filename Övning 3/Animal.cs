using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    public abstract class Animal
    {
        internal string name { get; set; }
        internal double weight;
        internal int age;
        internal string type;

        public abstract string DoSound();

        public abstract string Stats();

        public Animal(string Name, double Weight, int Age) {
            name = Name;
            weight = Weight;
            age = Age;
        }
    }

    public class Horse: Animal
    {

        public double RunningSpeed;
        public override string DoSound()
        {
            return "neigh";
        }

        public override string Stats()
        {
            return $"Type: {type}, Name: {name}, Weight: {weight}, Age: {age}, RunningSpeed: {RunningSpeed}";
        }

        public Horse(string Name, double Weight, int Age) : base(Name, Weight, Age) { type = "horse";  RunningSpeed = 3.5; }
    }
    
    public class Dog : Animal
    {
        public bool Tame;
        public override string DoSound()
        {
            return "bark";
        }
        public override string Stats()
        {
            return $"Type: {type}, Name: {name}, Weight: {weight}, Age: {age}, Tame: {Tame}";
        }

        public string Runs()
        {
            return $"{name} runs very fast";
        }

        public Dog(string Name, double Weight, int Age) : base(Name, Weight, Age) { type = "dog"; Tame = true; }

    }
    
    public class Hedgehog : Animal
    {
        public int NrOfSpikes;
        public override string DoSound()
        {
            return "squeek";
        }
        public override string Stats()
        {
            return $"Type: {type}, Name: {name}, Weight: {weight}, Age: {age}, Number of spikes: {NrOfSpikes}";
        }

        public Hedgehog(string Name, double Weight, int Age) : base(Name, Weight, Age) { type = "hedgehog"; NrOfSpikes = 55; }

    }

    public class Worm : Animal
    {
        public bool IsPoisonous;
        public override string DoSound()
        {
            return "none";
        }
        public override string Stats()
        {
            return $"Type: {type}, Name: {name}, Weight: {weight}, Age: {age}, Poisonous: {IsPoisonous}";
        }

        public Worm(string Name, double Weight, int Age) : base(Name, Weight, Age) { type = "worm"; IsPoisonous = true; }

    }
    public class Bird : Animal
    {
        public double Wingspan;

        public override string DoSound()
        {
            return "tweet";
        }
        public override string Stats()
        {
            return $"Type: {type}, Name: {name}, Weight: {weight}, Age: {age}, Wingspan: {Wingspan}";
        }

        public Bird(string Name, double Weight, int Age) : base(Name, Weight, Age) { type = "bird"; Wingspan = 150; }

    }
    public class Wolf : Animal
    {
        public int SizeOfPack;
        public override string DoSound()
        {
            return "howl";
        }
        public override string Stats()
        {
            return $"Type: {type}, Name: {name}, Weight: {weight}, Age: {age}, Size of Pack: {SizeOfPack}";
        }

        public Wolf(string Name, double Weight, int Age) : base(Name, Weight, Age) { type = "wolf"; SizeOfPack = 9; }

    }

    public class Pelican : Bird
    {
        public int BeakLength;

        public override string Stats()
        {
            return $"Type: {type}, Name: {name}, Weight: {weight}, Age: {age}, Wingspan: {Wingspan}, Beak Length: {BeakLength}";
        }

        public Pelican(string Name, double Weight, int Age) : base(Name, Weight, Age) { type = "pelican"; Wingspan = 150;  BeakLength = 45; }

    }

    public class Flamingo : Bird
    {
        public string color;
        public override string Stats()
        {
            return $"Type: {type}, Name: {name}, Weight: {weight}, Age: {age}, Wingspan: {Wingspan}, Color: {color}";
        }

        public Flamingo(string Name, double Weight, int Age) : base(Name, Weight, Age) { type = "flamingo"; Wingspan = 150; color = "Pink"; }

    }

    public class Swan : Bird
    {
        public int nrOfChildren; 
        public override string Stats()
        {
            return $"Type: {type}, Name: {name}, Weight: {weight}, Age: {age}, Wingspan: {Wingspan}, Number of Children: {nrOfChildren}";
        }

        public Swan(string Name, double Weight, int Age) : base(Name, Weight, Age) { type = "swan"; Wingspan = 150; nrOfChildren = 2; }

    }
    public class Wolfman : Animal, IPerson
    {

        public override string DoSound()
        {
            return "howl";
        }
        public override string Stats()
        {
            return $"Type: {type}, Name: {name}, Weight: {weight}, Age: {age}";
        }

        public string Talk()
        {
            return "I'm the big bad wolf";
        }

        public Wolfman(string Name, double Weight, int Age) : base(Name, Weight, Age) { type = "wolfman"; }
    
    }
    
}
