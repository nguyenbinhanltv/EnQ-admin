#pragma checksum "C:\Users\Lan\Desktop\EnQ-admin\Components\BottomLeadersItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46e3540faa4f3dac294de16b283a072deda81a6e"
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
    public partial class BottomLeadersItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "m-2");
            __builder.AddAttribute(2, "style", "height: 100%; width: 80%;");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<Blazorise.Card>(4);
            __builder.AddAttribute(5, "Style", "height: 100%; width: 100%;");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<Blazorise.CardBody>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(10, "\r\n            ");
                    __builder3.OpenComponent<Blazorise.CardTitle>(11);
                    __builder3.AddAttribute(12, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 4 "C:\Users\Lan\Desktop\EnQ-admin\Components\BottomLeadersItem.razor"
                             5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(14, "Card title");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n            ");
                    __builder3.OpenComponent<Blazorise.CardText>(16);
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(18, "\r\n                Lorem...\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
