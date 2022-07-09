using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace Advanced.Models
{
	public static class SeedData
	{
		public static void SeedDatabase(DataContext context)
        {
			context.Database.Migrate();
			if(context.People.Count() ==0 && context.Locations.Count() == 0 && context.Departaments.Count() == 0)
            {
				Departament d1 = new Departament { Name = "Sales" };
				Departament d2 = new Departament { Name = "Development" };
				Departament d3 = new Departament { Name = "Support" };
				Departament d4 = new Departament { Name = "Facilities" };

				context.Departaments.AddRange(d1, d2, d3, d4);
				context.SaveChanges();

				Location l1 = new Location { City = "Oakland", State = "CA" };
				Location l2 = new Location { City = "San Jose", State = "CA" };
				Location l3 = new Location { City = "New York", State = "NY" };
				context.Locations.AddRange(l1, l2, l3);

				context.People.AddRange
					(
					new Person { Firstname = "Francesca", Surname = "Jacobs", Departament = d2, Location = l1 },
					new Person { Firstname = "Charlies", Surname = "Fuentes", Departament = d2, Location = l3 },
					new Person { Firstname = "Brigit", Surname = "Becker", Departament = d4, Location = l1 },
					new Person { Firstname = "Murphy", Surname = "Lara", Departament = d1, Location = l3 },
					new Person { Firstname = "Beasley", Surname = "Hoffman", Departament = d4, Location = l3 },
					new Person { Firstname = "Marks", Surname = "Hays", Departament = d4, Location = l1 },
					new Person { Firstname = "Underwood", Surname = "Trujillo", Departament = d2, Location = l1 },
					new Person { Firstname = "Randall", Surname = "Lloyd", Departament = d3, Location = l2 },
					new Person { Firstname = "Guzman", Surname = "Case", Departament = d2, Location = l2 }
					);
				context.SaveChanges();
            }
        }
	}
}

