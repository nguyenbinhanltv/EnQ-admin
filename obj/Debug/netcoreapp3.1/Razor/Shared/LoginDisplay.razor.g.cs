#pragma checksum "C:\Users\black\OneDrive\Máy tính\EnQ-admin\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e9de9c5e7b81969b29941a8939d9b393ebeefda"
// <auto-generated/>
#pragma warning disable 1591
namespace EnQ_Admin.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using EnQ_Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using EnQ_Admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using Blazorise.Sidebar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using EnQ_Admin.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using EnQ_Admin.API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\_Imports.razor"
using EnQ_Admin.API.Leaders;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "nav");
                __builder2.AddAttribute(4, "class", "navbar navbar-light bg-light");
                __builder2.AddMarkupContent(5, "\r\n            ");
                __builder2.AddMarkupContent(6, @"<a class=""navbar-brand d-flex flex-row justify-content-center align-items-center"" href=""home"">
                <img src=""_images/logo-noname.svg"" width=""50"" height=""50"" class=""d-inline-block align-top"" alt loading=""lazy"">
                English And Quiz
            </a>
            ");
                __builder2.OpenElement(7, "span");
                __builder2.AddAttribute(8, "class", "navbar-text");
                __builder2.AddMarkupContent(9, "\r\n                ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "style", "display: flex; justify-content: space-between; align-items: center; flex-direction: row;");
                __builder2.AddMarkupContent(12, "\r\n                    ");
                __builder2.OpenElement(13, "a");
                __builder2.AddAttribute(14, "href", "Identity/Account/Manage");
                __builder2.AddMarkupContent(15, "\r\n                        ");
                __builder2.OpenComponent<Blazorise.Icon>(16);
                __builder2.AddAttribute(17, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\Shared\LoginDisplay.razor"
                                    IconName.User

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                        ");
                __builder2.OpenElement(19, "span");
                __builder2.AddAttribute(20, "class", "badge badge-light");
                __builder2.AddContent(21, 
#nullable restore
#line 12 "C:\Users\black\OneDrive\Máy tính\EnQ-admin\Shared\LoginDisplay.razor"
                                                         context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.AddMarkupContent(24, @"<form method=""post"" action=""Identity/Account/LogOut"">
                        <button type=""submit"" class=""nav-link btn btn-link"">
                            <span class=""badge badge-light"">Log out</span>
                        </button>
                    </form>
                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n    ");
            }
            ));
            __builder.AddAttribute(28, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.AddMarkupContent(30, "<a href=\"Identity/Account/Register\">Register</a>\r\n        ");
                __builder2.AddMarkupContent(31, "<a href=\"Identity/Account/Login\">Log in</a>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
