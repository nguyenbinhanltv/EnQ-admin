#pragma checksum "C:\Users\Lan\Desktop\EnQ-admin\Components\TopLeaders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea96c7bbf68c997f1cfb5b34c3ad16fab7a426ed"
// <auto-generated/>
#pragma warning disable 1591
namespace EnQ_Admin.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lan\Desktop\EnQ-admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lan\Desktop\EnQ-admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lan\Desktop\EnQ-admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lan\Desktop\EnQ-admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lan\Desktop\EnQ-admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lan\Desktop\EnQ-admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lan\Desktop\EnQ-admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lan\Desktop\EnQ-admin\_Imports.razor"
using EnQ_Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lan\Desktop\EnQ-admin\_Imports.razor"
using EnQ_Admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lan\Desktop\EnQ-admin\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lan\Desktop\EnQ-admin\_Imports.razor"
using Blazorise.Sidebar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lan\Desktop\EnQ-admin\_Imports.razor"
using EnQ_Admin.Components;

#line default
#line hidden
#nullable disable
    public partial class TopLeaders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", true);
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<Blazorise.Tabs>(3);
            __builder.AddAttribute(4, "SelectedTab", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 2 "C:\Users\Lan\Desktop\EnQ-admin\Components\TopLeaders.razor"
                        selectedTab

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "SelectedTabChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 2 "C:\Users\Lan\Desktop\EnQ-admin\Components\TopLeaders.razor"
                                                          OnSelectedTabChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "Items", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n            ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "w-100 d-flex justify-content-around align-items-center flex-row");
                __builder2.AddMarkupContent(10, "\r\n                ");
                __builder2.OpenComponent<Blazorise.BarLink>(11);
                __builder2.AddAttribute(12, "To", "home");
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(14, "\r\n                    Back to Home\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.AddMarkupContent(16, "<h3>Top Public Contributors</h3>\r\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "d-flex justify-content-center align-items-center flex-row");
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.OpenComponent<Blazorise.Tab>(20);
                __builder2.AddAttribute(21, "Name", "today");
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(23, "Today");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n                    ");
                __builder2.OpenComponent<Blazorise.Tab>(25);
                __builder2.AddAttribute(26, "Name", "thisweek");
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(28, "This Week");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        ");
            }
            ));
            __builder.AddAttribute(32, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.OpenComponent<Blazorise.TabPanel>(34);
                __builder2.AddAttribute(35, "Name", "today");
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(37, "\r\n                Leaders today\r\n                ");
                    __builder3.AddMarkupContent(38, @"<div>
                        <div class=""card"">
                            <div class=""card-body"">
                                This is some text within a card body.
                            </div>
                        </div>
                        <div class=""card"">
                            <div class=""card-body"">
                                This is some text within a card body.
                            </div>
                        </div>
                        <div class=""card"">
                          <div class=""card-body"">
                            This is some text within a card body.
                          </div>
                        </div>
                    </div>
            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.OpenComponent<Blazorise.TabPanel>(40);
                __builder2.AddAttribute(41, "Name", "thisweek");
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(43, "\r\n                Leaders thisweek\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Lan\Desktop\EnQ-admin\Components\TopLeaders.razor"
       
    string selectedTab = "today";

    private void OnSelectedTabChanged( string name )
    {
        selectedTab = name;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591