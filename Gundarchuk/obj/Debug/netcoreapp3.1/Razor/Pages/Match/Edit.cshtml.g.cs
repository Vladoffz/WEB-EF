#pragma checksum "C:\Users\vladg\source\repos\Gundarchuk\Gundarchuk\Pages\Match\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c7f7f39de7aa119998d82c02d647030c3d2d4c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Match_Edit), @"mvc.1.0.razor-page", @"/Pages/Match/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7f7f39de7aa119998d82c02d647030c3d2d4c7", @"/Pages/Match/Edit.cshtml")]
    public class Pages_Match_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\vladg\source\repos\Gundarchuk\Gundarchuk\Pages\Match\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Match</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Match.Id"" />
            <div class=""form-group"">
                <label asp-for=""Match.Name"" class=""control-label""></label>
                <input asp-for=""Match.Name"" class=""form-control"" />
                <span asp-validation-for=""Match.Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Match.Schet"" class=""control-label""></label>
                <input asp-for=""Match.Schet"" class=""form-control"" />
                <span asp-validation-for=""Match.Schet"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Match.PlayedDate"" class=""control-label""></label>
                <input asp-for=""Match.PlayedDate"" class=""form-control"" />");
            WriteLiteral(@"
                <span asp-validation-for=""Match.PlayedDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-page=""./Index"">Back to List</a>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gundarchuk.Pages.Match.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Gundarchuk.Pages.Match.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Gundarchuk.Pages.Match.EditModel>)PageContext?.ViewData;
        public Gundarchuk.Pages.Match.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
