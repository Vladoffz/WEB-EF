#pragma checksum "C:\Users\vladg\source\repos\Gundarchuk\Gundarchuk\Pages\Commands\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4084188d82f51040e18b24e0d89108659d9429b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Commands_Create), @"mvc.1.0.razor-page", @"/Pages/Commands/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4084188d82f51040e18b24e0d89108659d9429b", @"/Pages/Commands/Create.cshtml")]
    public class Pages_Commands_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\vladg\source\repos\Gundarchuk\Gundarchuk\Pages\Commands\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Command</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Command.Name"" class=""control-label""></label>
                <input asp-for=""Command.Name"" class=""form-control"" />
                <span asp-validation-for=""Command.Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Command.Country"" class=""control-label""></label>
                <input asp-for=""Command.Country"" class=""form-control"" />
                <span asp-validation-for=""Command.Country"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-page=""Index"">Back to List</a>
<");
            WriteLiteral("/div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gundarchuk.Pages.Command.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Gundarchuk.Pages.Command.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Gundarchuk.Pages.Command.CreateModel>)PageContext?.ViewData;
        public Gundarchuk.Pages.Command.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
