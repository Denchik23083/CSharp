#pragma checksum "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Shared\Test\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "953232724d3e152c29a9111fd6cc641977f6429f"
// <auto-generated/>
#pragma warning disable 1591
namespace TestBlazor.Web.Shared.Test
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
using TestBlazor.Web.Shared.Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using TestBlazor.Web.Shared.Books;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Blazor.Db.Entities.Books;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Blazor.Logic.BooksService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using TestBlazor.Web.Pages.Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Blazor.Db.Entities.Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using Blazor.Logic.TestService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\_Imports.razor"
using TestBlazor.Web.Utils;

#line default
#line hidden
#nullable disable
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col alert alert-secondary text-center");
            __builder.OpenElement(4, "h1");
            __builder.AddAttribute(5, "style", "color:" + " " + (
#nullable restore
#line 3 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Shared\Test\Counter.razor"
                           Styles.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Counter");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-6 text-left");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-primary p-3");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Shared\Test\Counter.razor"
                                                      IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Click me");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-6 text-right");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "font-size:" + " " + (
#nullable restore
#line 12 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Shared\Test\Counter.razor"
                                Styles.Size

#line default
#line hidden
#nullable disable
            ) + ";" + " color:" + " " + (
#nullable restore
#line 12 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Shared\Test\Counter.razor"
                                                     Styles.Color

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 12 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Shared\Test\Counter.razor"
__builder.AddContent(21, _currentCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col text-center");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "number");
            __builder.AddAttribute(29, "class", "form-control-lg");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Shared\Test\Counter.razor"
                                                            _currentCount

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _currentCount = __value, _currentCount, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "row mt-3");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col-4 text-center alert alert-primary");
            __builder.AddMarkupContent(37, "\r\n        Singleton count: ");
#nullable restore
#line 24 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Shared\Test\Counter.razor"
__builder.AddContent(38, Singleton.Value);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "col-4 text-center alert alert-danger");
            __builder.AddMarkupContent(42, "\r\n        Transient count: ");
#nullable restore
#line 27 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Shared\Test\Counter.razor"
__builder.AddContent(43, Transient.Value);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-4 text-center alert alert-secondary");
            __builder.AddMarkupContent(47, "\r\n        Scoped count: ");
#nullable restore
#line 30 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor.Web\Shared\Test\Counter.razor"
__builder.AddContent(48, Scoped.Value);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
