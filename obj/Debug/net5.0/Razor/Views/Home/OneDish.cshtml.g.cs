#pragma checksum "D:\CodingDojo\CSharp\ORM\CRUDelicous\Views\Home\OneDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1d7a330de59bd7b29656ed916023995cf7b90fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OneDish), @"mvc.1.0.view", @"/Views/Home/OneDish.cshtml")]
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
#line 1 "D:\CodingDojo\CSharp\ORM\CRUDelicous\Views\_ViewImports.cshtml"
using CRUDelicous;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CodingDojo\CSharp\ORM\CRUDelicous\Views\_ViewImports.cshtml"
using CRUDelicous.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1d7a330de59bd7b29656ed916023995cf7b90fa", @"/Views/Home/OneDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15d9c59b2edf24413e9b9d8c1401b0b4b9b9a8a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OneDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\CodingDojo\CSharp\ORM\CRUDelicous\Views\Home\OneDish.cshtml"
  
    ViewData["Title"] = "View @ViewBag.OneDish.DishName";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"w-50 mx-auto\">\r\n    <a href=\"/\" class=\"btn btn-primary\">Home</a>\r\n    <h1>");
#nullable restore
#line 7 "D:\CodingDojo\CSharp\ORM\CRUDelicous\Views\Home\OneDish.cshtml"
   Write(ViewBag.OneDish.DishName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    \r\n    <h3>Description: ");
#nullable restore
#line 9 "D:\CodingDojo\CSharp\ORM\CRUDelicous\Views\Home\OneDish.cshtml"
                Write(ViewBag.OneDish.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h4>Calories:");
#nullable restore
#line 10 "D:\CodingDojo\CSharp\ORM\CRUDelicous\Views\Home\OneDish.cshtml"
            Write(ViewBag.OneDish.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n    <h4>Taste:");
#nullable restore
#line 11 "D:\CodingDojo\CSharp\ORM\CRUDelicous\Views\Home\OneDish.cshtml"
         Write(ViewBag.OneDish.Taste);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 350, "\"", 386, 3);
            WriteAttributeValue("", 357, "/", 357, 1, true);
#nullable restore
#line 13 "D:\CodingDojo\CSharp\ORM\CRUDelicous\Views\Home\OneDish.cshtml"
WriteAttributeValue("", 358, ViewBag.OneDish.DishId, 358, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 381, "/edit", 381, 5, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary m-3\">Edit This Dish</a>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 442, "\"", 480, 3);
            WriteAttributeValue("", 449, "/", 449, 1, true);
#nullable restore
#line 14 "D:\CodingDojo\CSharp\ORM\CRUDelicous\Views\Home\OneDish.cshtml"
WriteAttributeValue("", 450, ViewBag.OneDish.DishId, 450, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 473, "/delete", 473, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete this Post</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
