#pragma checksum "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\Pages\Account\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9bad77097a88c4cc9965c39b6ae313260791651"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Layout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/account/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h4 class=\"card-header\">Register</h4>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\Pages\Account\Register.razor"
                          model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\Pages\Account\Register.razor"
                                                OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.AddMarkupContent(17, "<label>Primeiro Nome</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\Pages\Account\Register.razor"
                                        model.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.FirstName = __value, model.FirstName))));
                __builder2.AddAttribute(22, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n                ");
                __Blazor.BlazorApp.Pages.Account.Register.TypeInference.CreateValidationMessage_0(__builder2, 24, 25, 
#nullable restore
#line 14 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\Pages\Account\Register.razor"
                                          () => model.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.AddMarkupContent(31, "<label>Ultimo Nome</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\Pages\Account\Register.razor"
                                        model.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.LastName = __value, model.LastName))));
                __builder2.AddAttribute(36, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n                ");
                __Blazor.BlazorApp.Pages.Account.Register.TypeInference.CreateValidationMessage_1(__builder2, 38, 39, 
#nullable restore
#line 19 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\Pages\Account\Register.razor"
                                          () => model.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddMarkupContent(44, "\r\n                ");
                __builder2.AddMarkupContent(45, "<label>Usuario</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\Pages\Account\Register.razor"
                                        model.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Username = __value, model.Username))));
                __builder2.AddAttribute(50, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n                ");
                __Blazor.BlazorApp.Pages.Account.Register.TypeInference.CreateValidationMessage_2(__builder2, 52, 53, 
#nullable restore
#line 24 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\Pages\Account\Register.razor"
                                          () => model.Username

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddMarkupContent(58, "\r\n                ");
                __builder2.AddMarkupContent(59, "<label>senha</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(60);
                __builder2.AddAttribute(61, "type", "password");
                __builder2.AddAttribute(62, "class", "form-control");
                __builder2.AddAttribute(63, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\Pages\Account\Register.razor"
                                        model.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Password = __value, model.Password))));
                __builder2.AddAttribute(65, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n                ");
                __Blazor.BlazorApp.Pages.Account.Register.TypeInference.CreateValidationMessage_3(__builder2, 67, 68, 
#nullable restore
#line 29 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\Pages\Account\Register.razor"
                                          () => model.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(69, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n            ");
                __builder2.OpenElement(71, "button");
                __builder2.AddAttribute(72, "disabled", 
#nullable restore
#line 31 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\Pages\Account\Register.razor"
                               loading

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(73, "class", "btn btn-primary");
                __builder2.AddMarkupContent(74, "\r\n");
#nullable restore
#line 32 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\Pages\Account\Register.razor"
                 if (loading) 
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(75, "                    <span class=\"spinner-border spinner-border-sm mr-1\"></span>\r\n");
#nullable restore
#line 35 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\Pages\Account\Register.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(76, "                Register\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(78);
                __builder2.AddAttribute(79, "href", "account/login");
                __builder2.AddAttribute(80, "class", "btn btn-link");
                __builder2.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(82, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(84, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\redbu\source\repos\BlazorApp\BlazorApp\Pages\Account\Register.razor"
       
    private AddUser model = new AddUser();
    private bool loading;

    private async void OnValidSubmit()
    {
        // reset alerts on submit
        AlertService.Clear();
        
        loading = true;
        try
        {
            await AccountService.Register(model);
            AlertService.Success("Registration successful", keepAfterRouteChange: true);
            NavigationManager.NavigateTo("account/login");
        }
        catch (Exception ex)
        {
            AlertService.Error(ex.Message);
            loading = false;
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAlertService AlertService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService AccountService { get; set; }
    }
}
namespace __Blazor.BlazorApp.Pages.Account.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
