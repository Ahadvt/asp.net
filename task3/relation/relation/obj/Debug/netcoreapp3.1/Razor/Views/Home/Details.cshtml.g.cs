#pragma checksum "C:\Users\HP\Desktop\asp-netCore\task3\relation\relation\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32eb466a025caf0ff3333262cb34b7f1f5bdf933"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\asp-netCore\task3\relation\relation\Views\Home\Details.cshtml"
using relation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32eb466a025caf0ff3333262cb34b7f1f5bdf933", @"/Views/Home/Details.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Group>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\HP\Desktop\asp-netCore\task3\relation\relation\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"btn-group\">\r\n    <button class=\"btn btn-secondary dropdown-toggle\" type=\"button\" id=\"defaultDropdown\" data-bs-toggle=\"dropdown\" data-bs-auto-close=\"true\" aria-expanded=\"false\">\r\n        ");
#nullable restore
#line 12 "C:\Users\HP\Desktop\asp-netCore\task3\relation\relation\Views\Home\Details.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </button>\r\n    <ul class=\"dropdown-menu\" aria-labelledby=\"defaultDropdown\">\r\n\r\n");
#nullable restore
#line 16 "C:\Users\HP\Desktop\asp-netCore\task3\relation\relation\Views\Home\Details.cshtml"
         foreach (Student student in Model.students)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a class=\"dropdown-item\" href=\"#\">student.Name</a></li>\r\n");
#nullable restore
#line 19 "C:\Users\HP\Desktop\asp-netCore\task3\relation\relation\Views\Home\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Group> Html { get; private set; }
    }
}
#pragma warning restore 1591
