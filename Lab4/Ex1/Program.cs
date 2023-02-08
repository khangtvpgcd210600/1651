namespace Ex1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Exercise1();
            Console.WriteLine();
            Exercise2();
            Console.WriteLine();
            Exercise3();
            Console.WriteLine();
            Exercise4();
            Console.WriteLine();
            Exercise5();

        }

        public static void Exercise1()
        {
            Dog dog = new Dog();
            dog.Bark();
            dog.Bark();
        }

        public static void Exercise2()
        {
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }

        public static void Exercise3()
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }

        public static void Exercise4()
        {
            RandomList randomlist = new RandomList
            {
                "Khang",
                "Khanh",
                "Khoa",
                "Long",
                "Nguyen"
            };
            Console.WriteLine(randomlist.RandomString());
        }

        public static void Exercise5()
        {
            StackOfStrings strings = new StackOfStrings();
            Console.WriteLine(strings.IsEmpty());
            strings.AddRange(6);
            Console.WriteLine(strings.IsEmpty());
        }
    }
}
