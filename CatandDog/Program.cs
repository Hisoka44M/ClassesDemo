namespace CatandDog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Кошка
            Cat myCat = new Cat { Name = "Кузя", Age = 15, Breed = "Британец" };
            Console.WriteLine($"Кот: {myCat.Name}, Возраст: {myCat.Age}, Порода: {myCat.Breed}");

            myCat.Purr();
            myCat.Play();
            myCat.Feed();
            myCat.Play();
            myCat.Feed();

            Console.WriteLine();

            //Собака
            Dog myDog = new Dog { Name = "Рекс", Age = 5, Breed = "Овчарка" };
            Console.WriteLine($"Собака: {myDog.Name}, Возраст: {myDog.Age}, Порода: {myDog.Breed}");

            myDog.WagTail();
            myDog.Play();
            myDog.Walk();
            myDog.Play();
            myDog.Walk();

            Console.WriteLine("Тестирование завершено!");
        }



        internal class Cat
        {
            public string Name { get; set; } // Имя кота
            public int Age { get; set; } // Возраст кота
            public string Breed { get; set; } // Порода
            public bool IsHungry { get; private set; } = true; // Голоден ли кот
            public int EnergyLevel { get; private set; } = 100; // Уровень энергии

            // Метод кормления кота
            public void Feed()
            {
                if (IsHungry)
                {
                    IsHungry = false;
                    EnergyLevel += 20;
                    Console.WriteLine($"{Name} поел! Энергия: {EnergyLevel}");
                }
                else
                {
                    Console.WriteLine($"{Name} не голоден!");
                }
            }

            // Метод игры с котом
            public void Play()
            {
                if (EnergyLevel > 20)
                {
                    EnergyLevel -= 20;
                    IsHungry = true;
                    Console.WriteLine($"{Name} поиграл и устал. Энергия: {EnergyLevel}");
                }
                else
                {
                    Console.WriteLine($"{Name} слишком устал, ему нужен отдых!");
                }
            }

            // Метод мурчания
            public void Purr()
            {
                Console.WriteLine($"{Name} довольно мурлычет!");
            }
        }

        internal class Dog
        {
            public string Name { get; set; } // Имя собаки
            public int Age { get; set; } // Возраст собаки
            public string Breed { get; set; } // Порода
            public bool WantsToWalk { get; private set; } = true; // Хочет ли собака гулять
            public int EnergyLevel { get; private set; } = 100; // Уровень энергии

            // Метод выгула собаки
            public void Walk()
            {
                if (WantsToWalk)
                {
                    WantsToWalk = false;
                    EnergyLevel -= 20;
                    Console.WriteLine($"{Name} погулял и доволен! Энергия: {EnergyLevel}");
                }
                else
                {
                    Console.WriteLine($"{Name} не хочет гулять!");
                }
            }

            // Метод игры с собакой
            public void Play()
            {
                if (EnergyLevel > 30)
                {
                    EnergyLevel -= 30;
                    WantsToWalk = true;
                    Console.WriteLine($"{Name} поиграл и хочет гулять! Энергия: {EnergyLevel}");
                }
                else
                {
                    Console.WriteLine($"{Name} слишком устал, ему нужен отдых!");
                }
            }

            // Метод виляния хвостом
            public void WagTail()
            {
                Console.WriteLine($"{Name} радостно виляет хвостом!");
            }
        }
    }
}
