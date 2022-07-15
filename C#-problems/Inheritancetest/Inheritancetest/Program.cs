using System;

namespace test
{
    class InheritanceTest
    {
        public class Person
        {
            private string name;
            private int age;

            public Person(int Age,string Name)
            {
                name = Name;
                age = Age;
            }

        }
        public class Child: Person
        {
            public Child(int Age,string Name)
                :base(Age,Name)
            {

            }
        }
        static void Main()
        {
            
        }
    }
}
