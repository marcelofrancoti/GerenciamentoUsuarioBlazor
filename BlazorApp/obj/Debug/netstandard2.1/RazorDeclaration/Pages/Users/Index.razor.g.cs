// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages.Users
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
#nullable restore
#line 2 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\BlazorApp\Pages\Users\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Layout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/users")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\BlazorApp\Pages\Users\Index.razor"
       
    private bool loading;
    private IList<User> users;

    protected override async Task OnInitializedAsync()
    {
        loading = true;
        users = await AccountService.GetAll();
        loading = false;
    }

    private async void DeleteUser(string id) 
    {
        var user = users.First(x => x.Id == id);
        user.IsDeleting = true;
        await AccountService.Delete(id);
        users.Remove(user);
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService AccountService { get; set; }
    }
}
#pragma warning restore 1591
