#pragma checksum "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\PageComponents\TestModel1\GenericList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7644a1a97ea563c4c27a1476114987f4fec18e06"
// <auto-generated/>
#pragma warning disable 1591
namespace TestBlazor.Web.PageComponents.TestModel1
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using TestBlazor.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using TestBlazor.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Blazor.Db.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Blazor.Logic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Blazor.WebDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Blazor.Db.Entities.Books;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Blazor.Logic.BooksService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using TestBlazor.Web.Pages.TestModel1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Blazor.Logic.TestService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using TestBlazor.Web.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using TestBlazor.Web.PageComponents.Books;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using TestBlazor.Web.PageComponents.TestModel1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using TestBlazor.Web.PageComponents.TestModel23;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Blazor.Db.Entities.TestModel23;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Blazor.Db.Entities.TestModel1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Tewr.Blazor.FileReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class GenericList<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\PageComponents\TestModel1\GenericList.razor"
 if (ListOfItems is null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\PageComponents\TestModel1\GenericList.razor"
     if (NullList != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\PageComponents\TestModel1\GenericList.razor"
__builder.AddContent(0, NullList);

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\PageComponents\TestModel1\GenericList.razor"
                 
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<img src=\"https://miro.medium.com/max/1400/1*CsJ05WEGfunYMLGfsT2sXA.gif\" height=\"150\">");
#nullable restore
#line 12 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\PageComponents\TestModel1\GenericList.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\PageComponents\TestModel1\GenericList.razor"
     
}
else if (ListOfItems.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\PageComponents\TestModel1\GenericList.razor"
     if (EmptyList != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\PageComponents\TestModel1\GenericList.razor"
__builder.AddContent(2, NullList);

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\PageComponents\TestModel1\GenericList.razor"
                 
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<img src=\"https://cdn.akamai.steamstatic.com/steam/apps/1534200/header.jpg?t=1616065824\" height=\"150\">");
#nullable restore
#line 23 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\PageComponents\TestModel1\GenericList.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\PageComponents\TestModel1\GenericList.razor"
     
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\PageComponents\TestModel1\GenericList.razor"
     foreach (var item in ListOfItems)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\PageComponents\TestModel1\GenericList.razor"
__builder.AddContent(4, ItemTemplate(item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\PageComponents\TestModel1\GenericList.razor"
                           
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\PageComponents\TestModel1\GenericList.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\PageComponents\TestModel1\GenericList.razor"
       
    [Parameter] public RenderFragment NullList { get; set; }
    [Parameter] public RenderFragment EmptyList { get; set; }

    [Parameter] public RenderFragment<TItem> ItemTemplate { get; set; }

    [Parameter] public List<TItem> ListOfItems { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591