// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Advanced.Blazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/admin/Desktop/project/WEB/Advanced/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/admin/Desktop/project/WEB/Advanced/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/admin/Desktop/project/WEB/Advanced/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/admin/Desktop/project/WEB/Advanced/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/admin/Desktop/project/WEB/Advanced/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/admin/Desktop/project/WEB/Advanced/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/admin/Desktop/project/WEB/Advanced/_Imports.razor"
using Advanced.Models;

#line default
#line hidden
#nullable disable
    public partial class Events : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "/Users/admin/Desktop/project/WEB/Advanced/Blazor/Events.razor"
      

    public int ElementCounter { get; set; } = 4;
    public Dictionary<int, int> Counters { get; set; } = new Dictionary<int, int>();
    public int GetCounter(int index) =>
        Counters.ContainsKey(index) ? Counters[index] : 0;
    public bool EnableEventParams { get; set; } = false;

    public void IncrementCounter(int id)
    {
        Counters[id] = GetCounter(id)+1;
    }

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
