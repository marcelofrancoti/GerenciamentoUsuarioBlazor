// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\BlazorApp\Shared\MainLayout.razor"
       
    public bool LoggedIn 
    {
        get { return AccountService.User != null; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService AccountService { get; set; }
    }
}
#pragma warning restore 1591
