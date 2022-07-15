using Advanced.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace Advanced.Blazor
{
    public partial class Splits
    {
        [Inject]
        public DataContext Context { get; set; }

        public IEnumerable<string> Names => Context.People.Select(p => p.Firstname);
    }
}