using ConsoleApp21;
using System;
using System.Text.Json;

namespace JsonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Nicat";
            person.Surname = "Cabbarov";

            // Serialize
            PersonToJSON(person);

            // Deserialize
            Person deserializedPerson = JSONToPerson();
            Console.WriteLine(deserializedPerson);
        }

        public static void PersonToJSON(Person person)
        {
            string path = "D:\\Users\\User\\Desktop\\data.json";

            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                JsonSerializer.Serialize(stream, person);
            }
        }

        public static Person JSONToPerson()
        {
            string path = "D:\\Users\\User\\Desktop\\data.json";

            using (Stream stream = new FileStream(path, FileMode.Open))
            {

                return JsonSerializer.Deserialize<Person>(stream);
            }
        }

    }
}
