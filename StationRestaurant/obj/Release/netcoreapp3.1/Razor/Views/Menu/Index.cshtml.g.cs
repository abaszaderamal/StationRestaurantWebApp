#pragma checksum "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "360f7d73e4df73d32dbd6ca03186ef620848b4cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Index), @"mvc.1.0.view", @"/Views/Menu/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"360f7d73e4df73d32dbd6ca03186ef620848b4cf", @"/Views/Menu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5b0561dea52081237d9296f72d487728ddff2c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MenuVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("menu-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
  
    string statusActive = "active";

    string statusActiveShow = "  active show";
    string statusActivedontShow = "container fade tab-pane";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main>
<section id=""Menu-logo"">
    <div class=""row"">
        <div class=""menu-logo-container col-lg-12"">
           <h2 class=""menu_title"">Menu</h2>
        </div>
    </div>

</section>
<section id=""Menu"" class=""menu"">
<ul class=""nav nav-pills justify-content-center"">
");
#nullable restore
#line 19 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
     for (int i = 0; i < @Model.ProductCategories.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"nav-item\">\r\n            <a");
            BeginWriteAttribute("class", " class=\"", 568, "\"", 626, 4);
            WriteAttributeValue("", 576, "nav-link", 576, 8, true);
            WriteAttributeValue("  ", 584, "custom-btn", 586, 12, true);
            WriteAttributeValue("  ", 596, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 22 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                                             if (i == 0){

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                                                    Write(statusActive);

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                                                                      }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 598, 27, false);
            WriteAttributeValue(" ", 625, "", 626, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"pill\"");
            BeginWriteAttribute("href", " href=\"", 646, "\"", 686, 2);
            WriteAttributeValue("", 653, "#", 653, 1, true);
#nullable restore
#line 22 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
WriteAttributeValue("", 654, Model.ProductCategories[i].Name, 654, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                                                                                                                                 Write(Model.ProductCategories[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n");
#nullable restore
#line 24 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n</ul>\r\n<div class=\"menu-content tab-content\">\r\n\r\n");
#nullable restore
#line 30 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
 if (@Model.ProductCategories.Count != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("id", " id=\"", 856, "\"", 893, 1);
#nullable restore
#line 32 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
WriteAttributeValue("", 861, Model.ProductCategories[0].Name, 861, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\'container fade tab-pane active show \'>\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-7 col-md-12\">\r\n");
#nullable restore
#line 35 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                 if (Model.ProductCategories[0].Products != null)
                {
                    if (Model.ProductCategories[0].Products.Where(p=>p.IsDeleted==false)!=null)
                    {
                        
                    }
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                     foreach (var product in Model.ProductCategories[0].Products.Where(p=>p.IsDeleted==false))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"menu-item\">\r\n                            <div class=\"menu-img\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "360f7d73e4df73d32dbd6ca03186ef620848b4cf10504", async() => {
                WriteLiteral("\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 1654, "\"", 1685, 2);
                WriteAttributeValue("", 1660, "Assets/img/", 1660, 11, true);
#nullable restore
#line 46 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
WriteAttributeValue("", 1671, product.Image, 1671, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Image\">\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                                                                                 WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </div>\r\n                            <div class=\"menu-text\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "360f7d73e4df73d32dbd6ca03186ef620848b4cf13625", async() => {
                WriteLiteral("\r\n\r\n                                    <h3>\r\n                                        <span>");
#nullable restore
#line 54 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                                         Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> <strong>$");
#nullable restore
#line 54 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                                                                       Write(product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </strong>\r\n                                    </h3>\r\n                                    <p>");
#nullable restore
#line 56 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                                  Write(product.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                                                                                 WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 61 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-5 col-md-12\">\r\n                <div class=\"menu-img-container\">\r\n");
#nullable restore
#line 67 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                     if (Model.ProductCategories[0].Products.Count != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 2594, "\"", 2656, 2);
            WriteAttributeValue("", 2600, "Assets/Img/", 2600, 11, true);
#nullable restore
#line 69 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
WriteAttributeValue("", 2611, Model.ProductCategories[0].Products[0].Image, 2611, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\" \"");
            BeginWriteAttribute("alt", " alt=\"", 2667, "\"", 2673, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 70 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 77 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
 for (int i = 1; i < @Model.ProductCategories.Count; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("id", " id=\"", 2846, "\"", 2883, 1);
#nullable restore
#line 79 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
WriteAttributeValue("", 2851, Model.ProductCategories[i].Name, 2851, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\'container fade tab-pane  \'>\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-7 col-md-12\">\r\n");
#nullable restore
#line 82 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                 if (Model.ProductCategories[i].Products != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                     foreach (var product in Model.ProductCategories[i].Products.Where(p=>p.IsDeleted==false))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"menu-item\">\r\n                            <div class=\"menu-img\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "360f7d73e4df73d32dbd6ca03186ef620848b4cf20817", async() => {
                WriteLiteral("\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 3465, "\"", 3496, 2);
                WriteAttributeValue("", 3471, "Assets/img/", 3471, 11, true);
#nullable restore
#line 89 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
WriteAttributeValue("", 3482, product.Image, 3482, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Image\">\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                                                                                  WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"menu-text\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "360f7d73e4df73d32dbd6ca03186ef620848b4cf23935", async() => {
                WriteLiteral("\r\n                                    <h3>\r\n                                        <span>");
#nullable restore
#line 95 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                                         Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> <strong>$");
#nullable restore
#line 95 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                                                                       Write(product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </strong>\r\n                                    </h3>\r\n                                    <p>");
#nullable restore
#line 97 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                                  Write(product.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                                                                                                WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 101 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-5 col-md-12\">\r\n                <div class=\"menu-img-container\">\r\n");
#nullable restore
#line 107 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                     if (Model.ProductCategories[i].Products != null && Model.ProductCategories[i].Products.Count != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 4446, "\"", 4508, 2);
            WriteAttributeValue("", 4452, "Assets/Img/", 4452, 11, true);
#nullable restore
#line 109 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
WriteAttributeValue("", 4463, Model.ProductCategories[i].Products[0].Image, 4463, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\" \"");
            BeginWriteAttribute("alt", " alt=\"", 4519, "\"", 4525, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 110 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 115 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\Ramal Abaszade\Source\Repos\StationRestaurantWebApp\StationRestaurant\Views\Menu\Index.cshtml"
 
}






#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n</section>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
