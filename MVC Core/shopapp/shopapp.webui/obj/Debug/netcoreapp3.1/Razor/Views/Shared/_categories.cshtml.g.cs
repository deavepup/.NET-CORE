#pragma checksum "C:\Users\dnmez\OneDrive\Masaüstü\.NET CORE\MVC Core\shopapp\shopapp.webui\Views\Shared\_categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96290c2d32988db8b3e70d783b19d384ce8de222"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__categories), @"mvc.1.0.view", @"/Views/Shared/_categories.cshtml")]
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
#line 2 "C:\Users\dnmez\OneDrive\Masaüstü\.NET CORE\MVC Core\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96290c2d32988db8b3e70d783b19d384ce8de222", @"/Views/Shared/_categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"415ce9953bd46be8f2c4fe4cc22e26d003bfb282", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n <div class=\"list-group\">\r\n");
#nullable restore
#line 4 "C:\Users\dnmez\OneDrive\Masaüstü\.NET CORE\MVC Core\shopapp\shopapp.webui\Views\Shared\_categories.cshtml"
     foreach (var category in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"#\" class=\"list-group-item list-group-item-action\">");
#nullable restore
#line 6 "C:\Users\dnmez\OneDrive\Masaüstü\.NET CORE\MVC Core\shopapp\shopapp.webui\Views\Shared\_categories.cshtml"
                                                              Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 7 "C:\Users\dnmez\OneDrive\Masaüstü\.NET CORE\MVC Core\shopapp\shopapp.webui\Views\Shared\_categories.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591