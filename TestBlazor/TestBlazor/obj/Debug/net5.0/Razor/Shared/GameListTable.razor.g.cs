#pragma checksum "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\Shared\GameListTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d521542eeebe3b02b4220a2c57198bfd8e26519"
// <auto-generated/>
#pragma warning disable 1591
namespace TestBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\_Imports.razor"
using TestBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\_Imports.razor"
using TestBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\_Imports.razor"
using Blazor.Db.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\_Imports.razor"
using Blazor.Logic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\_Imports.razor"
using Blazor.WebDb;

#line default
#line hidden
#nullable disable
    public partial class GameListTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "table-responsive");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-striped");
            __builder.OpenElement(4, "thead");
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "<th>Name</th>\r\n            ");
            __builder.AddMarkupContent(7, "<th>Genre</th>\r\n            ");
            __builder.AddMarkupContent(8, "<th>Release Date</th>\r\n            ");
            __builder.OpenElement(9, "th");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "checkbox");
            __builder.AddAttribute(12, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\Shared\GameListTable.razor"
                                              IsDisplay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => IsDisplay = __value, IsDisplay));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "tbody");
#nullable restore
#line 12 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\Shared\GameListTable.razor"
             if (Games is null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "<tr>Loading...</tr>");
#nullable restore
#line 15 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\Shared\GameListTable.razor"
            }
            else if (Games.Count == 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<tr>No items in Array</tr>");
#nullable restore
#line 19 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\Shared\GameListTable.razor"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\Shared\GameListTable.razor"
                 foreach (var item in Games)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TestBlazor.Shared.IndividualGame>(18);
            __builder.AddAttribute(19, "Game", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazor.Db.Entities.Game>(
#nullable restore
#line 24 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\Shared\GameListTable.razor"
                                          item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "IsTable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\Shared\GameListTable.razor"
                                                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "IsDisplay", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\Shared\GameListTable.razor"
                                                                          IsDisplay

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 25 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\Shared\GameListTable.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\Shared\GameListTable.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\User\source\repos\CSharp\TestBlazor\TestBlazor\Shared\GameListTable.razor"
 
    [Parameter] 
    public List<Game> Games { get; set; }

    public bool IsDisplay = false;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
