using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
        [Serializable]
        public class Person : ISerializable
        {
            private static int _id;
            public int Id { get; private set; }
            public string Name { get; set; }
            public string Surname { get; set; }

            public Person()
            {
                _id++;
                Id = _id;
            }
            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("Id", Id, typeof(Person));
                info.AddValue("Name", Name, typeof(Person));
                info.AddValue("Surnam", Surname, typeof(Person));
            }

            public override string? ToString()
            {
                return $"Id: {Id} Name: {Name} Surname: {Surname}";
            }
        }
    }

