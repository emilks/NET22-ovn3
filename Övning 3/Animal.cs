using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.3.13) Om vi vill ha ett attribut för alla fåglar ska vi lägga det i Bird klassen
//3.3.14) Om vi vill ha ett attribut som gäller alla djur borde det vara i Animal klassen

namespace Övning_3
{
    public abstract class Animal
    {
        private string name;
        private double weight;
        private int age;

        public abstract string DoSound();
    }

    public class Horse: Animal
    {
        public double RunningSpeed;
        public override string DoSound()
        {
            return "neigh";
        }
    }

    public class Dog : Animal
    {
        public bool Tame;
        public override string DoSound()
        {
            return "bark";
        }
    }

    public class Hedgehog : Animal
    {
        public int NrOfSpikes;
        public override string DoSound()
        {
            return "squek";
        }
    }

    public class Worm : Animal
    {
        public bool IsPoisonous;
        public override string DoSound()
        {
            return "none";
        }
    }
    public class Bird : Animal
    {
        public double Wingspan;

        public override string DoSound()
        {
            return "tweet";
        }
    }
    public class Wolf : Animal
    {
        public int SizeOfPack;
        public override string DoSound()
        {
            return "howl";
        }
    }

    public class Pelican : Bird
    {
        public int BeakLength;
    }

    public class Flamingo : Bird
    {
        public string color;
    }

    public class Swan : Bird
    {
        public int NrOfChildren;
    }

    public class Wolfman : Animal, IPerson
    {
        public override string DoSound()
        {
            return "howl";
        }

        public string Talk()
        {
            return "I'm the big bad wolf";
        }
    }
}
