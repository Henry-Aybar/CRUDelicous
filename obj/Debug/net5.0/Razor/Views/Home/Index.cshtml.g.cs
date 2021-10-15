#pragma checksum "D:\CodingDojo\CSharp\ORM\CRUDelicous\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d43ede866e70f550919bc291296ea4738e4c9988"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d43ede866e70f550919bc291296ea4738e4c9988", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15d9c59b2edf24413e9b9d8c1401b0b4b9b9a8a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\CodingDojo\CSharp\ORM\CRUDelicous\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Display All Chefs";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""w-50 mx-auto"">
    <h1>Chefs | <a href=""/dishes"">Dishes</a> </h1>
    <a href=""/chef/new"" class=""btn btn-primary m-3"">Add a Chef</a>
    <a href=""/dish/new"" class=""btn btn-primary m-3"">Add a Dish</a>
    <h3> Check Out Some of Our Amazing Chefs!!</h3>
    
    <table class=""table table-hover"">
    <thead class=""thead-light"">
        <tr>
            <th scope=""col"">Name</th>
            <th scope=""col"">Age</th>
            <th scope=""col""># of Dishes</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "D:\CodingDojo\CSharp\ORM\CRUDelicous\Views\Home\Index.cshtml"
          
            foreach(Chef chef in ViewBag.AllChefs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 24 "D:\CodingDojo\CSharp\ORM\CRUDelicous\Views\Home\Index.cshtml"
                   Write(chef.ChefFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "D:\CodingDojo\CSharp\ORM\CRUDelicous\Views\Home\Index.cshtml"
                                       Write(chef.ChefLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "D:\CodingDojo\CSharp\ORM\CRUDelicous\Views\Home\Index.cshtml"
                   Write(chef.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "D:\CodingDojo\CSharp\ORM\CRUDelicous\Views\Home\Index.cshtml"
                   Write(chef.Dishes.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 28 "D:\CodingDojo\CSharp\ORM\CRUDelicous\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n\r\n</div>\r\n");
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
