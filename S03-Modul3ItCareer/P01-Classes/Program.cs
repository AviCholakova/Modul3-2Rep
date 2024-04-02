using System;

namespace P01_Classes
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Zad 1


            //Person person = new Person(); //Добавяме обект
            //person.Name = "Pesho"; //Добавяме име 
            //person.Age = 30; //Добавяме възраст
            //Console.WriteLine($"{person.Name} {person.Age}"); //Печатаме обекта 

            //Person personOne = new Person(); //Добавяме нов обект
            //personOne.Name = "Gosho";
            //personOne.Age = 20;

            //Person personTwo = new Person();
            //personTwo.Name = "Natali";
            //personTwo.Age = 21;

            //Console.WriteLine($"{personOne.Name} {personOne.Age}");
            //Console.WriteLine($"{personTwo.Name} {personTwo.Age}");


            // Zad 2


            int number = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < number; i++)  //Приема толкова души, колкото са въведени
            {
                var data = Console.ReadLine().Split(' ').ToList();
                string name = data[0];
                int age = int.Parse(data[1]);
                Person person = new Person();
                person.Name = name;
                person.Age = age;
                family.Persons.Add(person);
            }
            var list = family.Persons.OrderBy(x => x.Name).ToList();  // Сортитаме и добавяме в списък
            var listTwo = family.Persons.Where(x => x.Age > 30).ToList(); // Само тези, по - големи от 30 год. 

            foreach (Person person in listTwo.OrderBy(x => x.Name)) //Печатаме всички
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
            //Where - филтър изваща нещо от съществуващ списък, което отговаря по определен критерий
        }
    }
}