#pragma checksum "C:\Users\Lan\Desktop\EnQ-admin\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8285eca37a2113e2b3e14d2c7cfc3ccdae90b124"
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
#nullable restore
#line 1 "C:\Users\Lan\Desktop\EnQ-admin\Shared\NavMenu.razor"
using EnQ_admin.Data;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazorise.Bar>(0);
            __builder.AddAttribute(1, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.BarMode>(
#nullable restore
#line 3 "C:\Users\Lan\Desktop\EnQ-admin\Shared\NavMenu.razor"
          BarMode.VerticalInline

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "CollapseMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.BarCollapseMode>(
#nullable restore
#line 4 "C:\Users\Lan\Desktop\EnQ-admin\Shared\NavMenu.razor"
                  BarCollapseMode.Small

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Breakpoint", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Breakpoint>(
#nullable restore
#line 5 "C:\Users\Lan\Desktop\EnQ-admin\Shared\NavMenu.razor"
                Breakpoint.Desktop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "NavigationBreakpoint", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Breakpoint>(
#nullable restore
#line 6 "C:\Users\Lan\Desktop\EnQ-admin\Shared\NavMenu.razor"
                          Breakpoint.Tablet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ThemeContrast", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.ThemeContrast>(
#nullable restore
#line 7 "C:\Users\Lan\Desktop\EnQ-admin\Shared\NavMenu.razor"
                   ThemeContrast.Dark

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Background", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Background>(
#nullable restore
#line 8 "C:\Users\Lan\Desktop\EnQ-admin\Shared\NavMenu.razor"
                Background.Dark

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<Blazorise.BarBrand>(9);
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(11, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.BarItem>(12);
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(14, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.BarLink>(15);
                        __builder4.AddAttribute(16, "To", "home");
                        __builder4.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(18, "\r\n                ");
                            __builder5.OpenComponent<Blazorise.BarIcon>(19);
                            __builder5.AddAttribute(20, "IconName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\Lan\Desktop\EnQ-admin\Shared\NavMenu.razor"
                                   IconName.Store

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(21, "\r\n                EnQ Admin\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(22, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.OpenComponent<Blazorise.BarMenu>(25);
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.BarStart>(28);
                    __builder3.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(30, "\r\n            \r\n            ");
                        __builder4.OpenComponent<Blazorise.BarItem>(31);
                        __builder4.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(33, "\r\n                ");
                            __builder5.OpenComponent<Blazorise.BarLink>(34);
                            __builder5.AddAttribute(35, "To", "home");
                            __builder5.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(37, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.BarIcon>(38);
                                __builder6.AddAttribute(39, "IconName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 31 "C:\Users\Lan\Desktop\EnQ-admin\Shared\NavMenu.razor"
                                       IconName.Home

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(40, "\r\n                    Home\r\n                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(41, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(42, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.BarItem>(43);
                        __builder4.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(45, "\r\n                ");
                            __builder5.OpenComponent<Blazorise.BarLink>(46);
                            __builder5.AddAttribute(47, "To", "users");
                            __builder5.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(49, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.BarIcon>(50);
                                __builder6.AddAttribute(51, "IconName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 37 "C:\Users\Lan\Desktop\EnQ-admin\Shared\NavMenu.razor"
                                       IconName.Users

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(52, "\r\n                    Users\r\n                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(53, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(54, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.BarItem>(55);
                        __builder4.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(57, "\r\n                ");
                            __builder5.OpenComponent<Blazorise.BarLink>(58);
                            __builder5.AddAttribute(59, "To", "leaders");
                            __builder5.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(61, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.BarIcon>(62);
                                __builder6.AddAttribute(63, "IconName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 43 "C:\Users\Lan\Desktop\EnQ-admin\Shared\NavMenu.razor"
                                       IconName.Dashboard

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(64, "\r\n                    Leaders\r\n                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(65, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(66, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.BarItem>(67);
                        __builder4.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(69, "\r\n                ");
                            __builder5.OpenComponent<Blazorise.BarLink>(70);
                            __builder5.AddAttribute(71, "To", "questions");
                            __builder5.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(73, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.BarIcon>(74);
                                __builder6.AddAttribute(75, "IconName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 49 "C:\Users\Lan\Desktop\EnQ-admin\Shared\NavMenu.razor"
                                       IconName.QuestionCircle

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(76, "\r\n                    Questions\r\n                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(77, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(78, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.BarItem>(79);
                        __builder4.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(81, "\r\n                ");
                            __builder5.OpenComponent<Blazorise.BarLink>(82);
                            __builder5.AddAttribute(83, "To", "test-exam");
                            __builder5.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(85, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.BarIcon>(86);
                                __builder6.AddAttribute(87, "IconName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 55 "C:\Users\Lan\Desktop\EnQ-admin\Shared\NavMenu.razor"
                                       IconName.Edit

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(88, "\r\n                    Test Exam\r\n                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(89, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(90, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\Lan\Desktop\EnQ-admin\Shared\NavMenu.razor"
       
    private MenuItem[] _menuItems = new MenuItem[]
    {
        new MenuItem
        {
            iconName = "IconName.Home",
            pageName = "Home",
            routerLink = "home",
        },
        new MenuItem
        {
            iconName = "IconName.Users",
            pageName = "Users",
            routerLink = "users",
        },
        new MenuItem
        {
            iconName = "IconName.Dashboard",
            pageName = "Leaders",
            routerLink = "leaders",
        },
        new MenuItem
        {
            iconName = "IconName.QuestionCircle",
            pageName = "Questions",
            routerLink = "questions",
        },
        new MenuItem
        {
            iconName = "IconName.Edit",
            pageName = "Test Exam",
            routerLink = "test-exam",
        },
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
