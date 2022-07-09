using System;
namespace Advanced.Models
{
	public class Person
	{
        public long PersonId { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public long DepartamentId { get; set; }
        public long LocationId { get; set; }

        public Departament Departament { get; set; }
        public Location Location { get; set; }
    }
}

