#pragma checksum "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e1bc48d31e1655202e6c4ec78d22ec0616187d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminRezerv_Views_Contact_Index), @"mvc.1.0.view", @"/Areas/AdminRezerv/Views/Contact/Index.cshtml")]
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
#line 2 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\_ViewImports.cshtml"
using Core.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\_ViewImports.cshtml"
using Business.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\_ViewImports.cshtml"
using Business.ViewModels.ProductCategory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\_ViewImports.cshtml"
using Business.ViewModels.ProductVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\_ViewImports.cshtml"
using Business.ViewModels.Table;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\_ViewImports.cshtml"
using Business.ViewModels.HeadSlide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\_ViewImports.cshtml"
using Business.ViewModels.Gallery;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e1bc48d31e1655202e6c4ec78d22ec0616187d4", @"/Areas/AdminRezerv/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e307155cee57398333d77d68be7fe850da31d371", @"/Areas/AdminRezerv/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdminRezerv_Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Paginate<Contact>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-icon waves-effect waves-light btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-icon waves-effect waves-light btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
  
    int count = ((Model.CurrentPage - 1) * 10) + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- ============================================================== -->
<!-- Start Page Content here -->
<!-- ============================================================== -->

<div class=""content-page"">
    <div class=""content"">

        <!-- Start Content-->
        <div class=""container-fluid"">

            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-body table-responsive"">
                            <h4 class=""m-t-0 header-title mb-4"">
                                <b>Product Table</b>
                            </h4>
");
            WriteLiteral(@"                            <table id=""datatable-buttons"" class=""table table-striped table-bordered dt-responsive nowrap"" style=""border-collapse: collapse; border-spacing: 0; width: 100%;"">

                                <thead>
                                <tr>
                                    <th>№</th>
                                    <th>Full Name</th>
                                    <th>Email</th>
                                    <th>Phone</th>
                                    <th>Sending Date</th>
                                    <th>Status</th>
                                    <th>Setting</th>

                                </tr>
                                </thead>

                                <tbody>
");
#nullable restore
#line 39 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                 foreach (var contact in Model.Items)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 42 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td>");
#nullable restore
#line 43 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                       Write(contact.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 43 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                                          Write(contact.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 44 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                       Write(contact.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 45 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                       Write(contact.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 46 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                       Write(TimeZoneInfo.ConvertTime(contact.CreatedAt, TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time")).AddHours(13));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n");
#nullable restore
#line 48 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                             if (contact.Status)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button type=\"button\" class=\"btn btn-icon waves-effect waves-light btn-success\">Answered </button>\r\n");
#nullable restore
#line 51 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button type=\"button\" class=\"btn btn-icon waves-effect waves-light btn-purple\">Pending</button>\r\n");
#nullable restore
#line 55 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n");
#nullable restore
#line 58 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                             if (!contact.Status)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e1bc48d31e1655202e6c4ec78d22ec0616187d412643", async() => {
                WriteLiteral("\r\n                                                    Reply\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                                                                                                                  WriteLiteral(contact.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e1bc48d31e1655202e6c4ec78d22ec0616187d415438", async() => {
                WriteLiteral("\r\n                                                <i class=\"mdi mdi-delete-outline\"></i>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                                                                                                              WriteLiteral(contact.Id);

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
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 70 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"


                                    count++;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
#nullable restore
#line 77 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                         if (@Model.AllPageCount > 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <nav aria-label=\"Page navigation example\">\r\n                                <ul class=\"pagination justify-content-center\">\r\n\r\n");
#nullable restore
#line 82 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                     if (Model.CurrentPage > 1)
                                    {
                                        var prev = Model.CurrentPage - 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"page-item \">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e1bc48d31e1655202e6c4ec78d22ec0616187d419466", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
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
            WriteLiteral("\r\n                                        </li>\r\n");
#nullable restore
#line 88 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"page-item disabled\">\r\n                                            <a class=\"page-link \">Previous</a>\r\n                                        </li>\r\n");
#nullable restore
#line 94 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                      
                                        if (1 < Model.AllPageCount)
                                        {
                                            var start = 1;
                                            var end = Model.AllPageCount;
                                            for (int i = start; i <= end; i++)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li");
            BeginWriteAttribute("class", " class=\"", 5463, "\"", 5524, 2);
            WriteAttributeValue("", 5471, "page-item", 5471, 9, true);
#nullable restore
#line 102 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
WriteAttributeValue(" ", 5480, Model.CurrentPage == i ? "disabled" : "", 5481, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e1bc48d31e1655202e6c4ec78d22ec0616187d423903", async() => {
#nullable restore
#line 103 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
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
            WriteLiteral("\r\n                                                </li>\r\n");
#nullable restore
#line 105 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                            }
                                        }
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                     if (Model.CurrentPage < Model.AllPageCount)
                                    {
                                        var next = Model.CurrentPage + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"page-item\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e1bc48d31e1655202e6c4ec78d22ec0616187d427439", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
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
            WriteLiteral("\r\n                                        </li>\r\n");
#nullable restore
#line 114 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"page-item disabled\">\r\n                                            <a class=\"page-link\">Next</a>\r\n                                        </li>\r\n");
#nullable restore
#line 120 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </ul>\r\n                            </nav>\r\n");
#nullable restore
#line 124 "C:\Users\Ramal Abaszade\Desktop\StationRestaurantWebApp\StationRestaurant\Areas\AdminRezerv\Views\Contact\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>

        </div>
        <!-- end container-fluid -->

    </div>
    <!-- end content -->
    <!-- Footer Start -->
    <footer class=""footer"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12"">
                    2015 - 2021 &copy; Velonic theme by <a href=""#"">Coderthemes</a>
                </div>
            </div>
        </div>
    </footer>
    <!-- end Footer -->

</div>

<!-- ============================================================== -->
<!-- End Page content -->
<!-- ============================================================== -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Paginate<Contact>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
