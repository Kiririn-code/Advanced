using System.Collections.Generic;
namespace Advanced.Models
{
	public class Departament
	{
        public long Departamentid { get; set; }
        public string Name { get; set; }

        public IEnumerable<Person> People { get; set; }
    }
}