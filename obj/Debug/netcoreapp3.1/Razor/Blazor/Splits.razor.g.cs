#pragma checksum "/Users/admin/Desktop/project/WEB/Advanced/Blazor/Splits.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31755c9eda95a3004dc82207bb39a99baf93ba61"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class Splits : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "list-group");
            __builder.AddMarkupContent(2, "\n");
#nullable restore
#line 2 "/Users/admin/Desktop/project/WEB/Advanced/Blazor/Splits.razor"
     foreach (var name in Names)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "li");
            __builder.AddAttribute(5, "class", "list-group-item");
#nullable restore
#line 4 "/Users/admin/Desktop/project/WEB/Advanced/Blazor/Splits.razor"
__builder.AddContent(6, name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n");
#nullable restore
#line 5 "/Users/admin/Desktop/project/WEB/Advanced/Blazor/Splits.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
