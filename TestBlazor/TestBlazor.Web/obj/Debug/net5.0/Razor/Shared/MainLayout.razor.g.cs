#pragma checksum "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce07006d32f3264adf3e789a8cd936a6bc836b71"
// <auto-generated/>
#pragma warning disable 1591
namespace TestBlazor.Web.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-fthhvms7vy");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-fthhvms7vy");
            __builder.OpenComponent<TestBlazor.Web.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-fthhvms7vy");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-fthhvms7vy><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-fthhvms7vy>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-fthhvms7vy");
            __Blazor.TestBlazor.Web.Shared.MainLayout.TypeInference.CreateCascadingValue_0(__builder, 15, 16, 
#nullable restore
#line 14 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Shared\MainLayout.razor"
                                   AppStyle

#line default
#line hidden
#nullable disable
            , 17, (__builder2) => {
#nullable restore
#line 15 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Shared\MainLayout.razor"
__builder2.AddContent(18, Body);

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.TestBlazor.Web.Shared.MainLayout
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
