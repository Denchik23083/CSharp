#pragma checksum "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Pages\TestModel23\GenreImagePages\CreateGenreImage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18b345d770be69959cb1c76d4bd13bba3c799206"
// <auto-generated/>
#pragma warning disable 1591
namespace TestBlazor.Web.Pages.TestModel23.GenreImagePages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/genres/create")]
    public partial class CreateGenreImage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\"><div class=\"col\"><h1 class=\"text-info\">Create Genre</h1></div></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-6");
            __builder.OpenComponent<TestBlazor.Web.PageComponents.TestModel23.FormForGenreImage>(5);
            __builder.AddAttribute(6, "Genre", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazor.Db.Entities.TestModel23.GenreImage>(
#nullable restore
#line 10 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Pages\TestModel23\GenreImagePages\CreateGenreImage.razor"
                                  _genre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnInvalidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 10 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Pages\TestModel23\GenreImagePages\CreateGenreImage.razor"
                                                           Create

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Pages\TestModel23\GenreImagePages\CreateGenreImage.razor"
       
    GenreImage _genre = new();

    void Create()
    {
        Console.WriteLine(_genre.Name);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
