using System;

namespace PetProject
{
    class Program
    {
        class Chameleon
        {
            string name;
            int age;
            double weight;
            double lifespan;

            public Chameleon(string _name)
            {
                name = _name;
                age = 0;
                weight = 1;
                lifespan = 0;
            }

            public string Name
            {
                get { return name; }
            }

            public int Age
            {
                get { return age; }
            }

            public double Weight
            {
                get { return weight; }
            }

            public double Lifespan
            {
                get { return lifespan; }
            }

            public void ChameleonData()
            {
                Console.WriteLine($"The pets name is {name}, age {age}, weight {weight} and lifespan {lifespan}.");
            }

            public void Consume()
            {
                weight += 0.2;
            }

            public void Exercise()
            {
                weight -= 0.1;
            }
            
            public void Death()
            {
                Console.WriteLine("The chameleon is dead.");
            }
        }
        static void Main(string[] args)
        {
            Chameleon newPet = new Chameleon("Rudy");
            for (int i = 0; i < 10; i++)
            {
                if(newPet.Weight == 0.7)
                {
                    newPet.Exercise();
                }else
                {
                    newPet.Consume();
                }
            }

            newPet.ChameleonData();
            newPet.Death();
        }
    }
}
