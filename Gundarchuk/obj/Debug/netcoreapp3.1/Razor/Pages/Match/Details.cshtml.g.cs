#pragma checksum "C:\Users\vladg\source\repos\Gundarchuk\Gundarchuk\Pages\Match\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ac875cd0b2242cecceac45571879201bb2183f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Match_Details), @"mvc.1.0.razor-page", @"/Pages/Match/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ac875cd0b2242cecceac45571879201bb2183f3", @"/Pages/Match/Details.cshtml")]
    public class Pages_Match_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\vladg\source\repos\Gundarchuk\Gundarchuk\Pages\Match\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Match</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\vladg\source\repos\Gundarchuk\Gundarchuk\Pages\Match\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Match.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\vladg\source\repos\Gundarchuk\Gundarchuk\Pages\Match\Details.cshtml"
       Write(Html.DisplayFor(model => model.Match.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\vladg\source\repos\Gundarchuk\Gundarchuk\Pages\Match\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Match.Schet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\vladg\source\repos\Gundarchuk\Gundarchuk\Pages\Match\Details.cshtml"
       Write(Html.DisplayFor(model => model.Match.Schet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\vladg\source\repos\Gundarchuk\Gundarchuk\Pages\Match\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Match.PlayedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\vladg\source\repos\Gundarchuk\Gundarchuk\Pages\Match\Details.cshtml"
       Write(Html.DisplayFor(model => model.Match.PlayedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-page=\"./Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 876, "\"", 906, 1);
#nullable restore
#line 35 "C:\Users\vladg\source\repos\Gundarchuk\Gundarchuk\Pages\Match\Details.cshtml"
WriteAttributeValue("", 891, Model.Match.Id, 891, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-page=\"./Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gundarchuk.Pages.Match.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Gundarchuk.Pages.Match.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Gundarchuk.Pages.Match.DetailsModel>)PageContext?.ViewData;
        public Gundarchuk.Pages.Match.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
