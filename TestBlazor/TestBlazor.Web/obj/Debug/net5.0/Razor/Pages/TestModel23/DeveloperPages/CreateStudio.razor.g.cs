#pragma checksum "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Pages\TestModel23\DeveloperPages\CreateStudio.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd546c7487aa6ab485e20f337c066b243b816d63"
// <auto-generated/>
#pragma warning disable 1591
namespace TestBlazor.Web.Pages.TestModel23.DeveloperPages
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
#nullable restore
#line 27 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using System.Linq.Expressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Markdig;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/studio/create")]
    public partial class CreateStudio : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\"><div class=\"col\"><h1 class=\"text-info\">Create Developer Studio</h1></div></div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-8");
            __builder.OpenComponent<TestBlazor.Web.PageComponents.TestModel23.DeveloperPageForm>(5);
            __builder.AddAttribute(6, "Developer", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazor.Db.Entities.TestModel23.GameDeveloper>(
#nullable restore
#line 11 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Pages\TestModel23\DeveloperPages\CreateStudio.razor"
                                      _developer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmitHandler", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 11 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Pages\TestModel23\DeveloperPages\CreateStudio.razor"
                                                                        Create

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    <div class=\"col\"></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Pages\TestModel23\DeveloperPages\CreateStudio.razor"
       
    GameDeveloper _developer = new();

    void Create()
    {
        //TODO: Creating studio logic
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
