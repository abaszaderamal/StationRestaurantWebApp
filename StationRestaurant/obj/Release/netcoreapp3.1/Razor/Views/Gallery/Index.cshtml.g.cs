#pragma checksum "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b4cf56d9fd987615aeb2610cbec3395d467693f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_Index), @"mvc.1.0.view", @"/Views/Gallery/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\_ViewImports.cshtml"
using StationRestaurant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\_ViewImports.cshtml"
using Business.ViewModels.Reservation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\_ViewImports.cshtml"
using Core.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\_ViewImports.cshtml"
using Business.ViewModels.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\_ViewImports.cshtml"
using Business.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\_ViewImports.cshtml"
using Business.ViewModels.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\_ViewImports.cshtml"
using Business.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b4cf56d9fd987615aeb2610cbec3395d467693f", @"/Views/Gallery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5b0561dea52081237d9296f72d487728ddff2c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Gallery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Paginate<GaleryImage>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
  
    int count = ((Model.CurrentPage - 1) * 10) + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("<main>\r\n    <section >\r\n        <h1 class=\"gallery-title\">Gallery</h1>\r\n        <div class=\"galery container\">\r\n");
#nullable restore
#line 9 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
             foreach (var item in @Model.Items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 284, "\"", 313, 2);
            WriteAttributeValue("", 291, "Assets/Img/", 291, 11, true);
#nullable restore
#line 11 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
WriteAttributeValue("", 302, item.Image, 302, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 341, "\"", 369, 2);
            WriteAttributeValue("", 347, "Assets/Img/", 347, 11, true);
#nullable restore
#line 12 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
WriteAttributeValue("", 358, item.Image, 358, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 370, "\"", 376, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n");
#nullable restore
#line 14 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"pagination_page\">\r\n");
#nullable restore
#line 17 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
                     if (@Model.AllPageCount > 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <nav  aria-label=\"Page navigation example\">\r\n                            <ul class=\"pagination justify-content-center\">\r\n            \r\n");
#nullable restore
#line 22 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
                                 if (Model.CurrentPage > 1)
                                {
                                    var prev = Model.CurrentPage - 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item \">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b4cf56d9fd987615aeb2610cbec3395d467693f7937", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
                                                                                    WriteLiteral(prev);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </li>\r\n");
#nullable restore
#line 28 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item disabled\">\r\n                                        <a class=\"page-link \">Previous</a>\r\n                                    </li>\r\n");
#nullable restore
#line 34 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
                                  
                                    if (1 < Model.AllPageCount)
                                    {
                                        var start = 1;
                                        var end = Model.AllPageCount;
                                        for (int i = start; i <= end; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li");
            BeginWriteAttribute("class", " class=\"", 1857, "\"", 1918, 2);
            WriteAttributeValue("", 1865, "page-item", 1865, 9, true);
#nullable restore
#line 42 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
WriteAttributeValue(" ", 1874, Model.CurrentPage == i ? "disabled" : "", 1875, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b4cf56d9fd987615aeb2610cbec3395d467693f12235", async() => {
#nullable restore
#line 43 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
                                                                                            WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </li>\r\n");
#nullable restore
#line 45 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
                                        }
                                    }
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
                                 if (Model.CurrentPage < Model.AllPageCount)
                                {
                                    var next = Model.CurrentPage + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b4cf56d9fd987615aeb2610cbec3395d467693f15671", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
                                                                                    WriteLiteral(next);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </li>\r\n");
#nullable restore
#line 54 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item disabled\">\r\n                                        <a class=\"page-link\">Next</a>\r\n                                    </li>\r\n");
#nullable restore
#line 60 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n                            </ul>\r\n                        </nav>\r\n");
#nullable restore
#line 64 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Gallery\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </section>\r\n\r\n</main>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Paginate<GaleryImage>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
