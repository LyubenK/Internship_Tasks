using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2_OOP
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }

        public ICollection<Person> People { get; set; }

        public void AddMember(Person memeber) => People.Add(memeber);

        public Person GetOldestMember()
        { 
            var person = People.OrderByDescending(a=> a.Age).Take(1).FirstOrDefault();

            if (person == null)
            {
                throw new Exception("The list is empty");
            }

            return person;
        }
    }
}
