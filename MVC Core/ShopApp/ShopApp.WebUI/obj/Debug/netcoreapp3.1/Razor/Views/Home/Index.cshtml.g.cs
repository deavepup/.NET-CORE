#pragma checksum "C:\Users\PC\Desktop\.NET-CORE\MVC Core\ShopApp\ShopApp.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edea75be339335a6d534fef91df5310a6e8ed426"
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
#line 1 "C:\Users\PC\Desktop\.NET-CORE\MVC Core\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\Desktop\.NET-CORE\MVC Core\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edea75be339335a6d534fef91df5310a6e8ed426", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d92f221954cd04f7795f709513028a13b6a3d25", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PC\Desktop\.NET-CORE\MVC Core\ShopApp\ShopApp.WebUI\Views\Home\Index.cshtml"
  
    var popularClass = Model.Products.Count > 2 ? "popular" : "";
    var products = Model.Products;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("MessageBox", async() => {
                WriteLiteral("\r\n    <div class=\"alert alert-success text-center m-0\">\r\n        You have a message!\r\n    </div>\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\PC\Desktop\.NET-CORE\MVC Core\ShopApp\ShopApp.WebUI\Views\Home\Index.cshtml"
 if (products.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\PC\Desktop\.NET-CORE\MVC Core\ShopApp\ShopApp.WebUI\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\PC\Desktop\.NET-CORE\MVC Core\ShopApp\ShopApp.WebUI\Views\Home\Index.cshtml"
                                          
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n");
#nullable restore
#line 20 "C:\Users\PC\Desktop\.NET-CORE\MVC Core\ShopApp\ShopApp.WebUI\Views\Home\Index.cshtml"
         foreach (var product in products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3\">\r\n                ");
#nullable restore
#line 23 "C:\Users\PC\Desktop\.NET-CORE\MVC Core\ShopApp\ShopApp.WebUI\Views\Home\Index.cshtml"
           Write(await Html.PartialAsync("_product", product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 25 "C:\Users\PC\Desktop\.NET-CORE\MVC Core\ShopApp\ShopApp.WebUI\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 27 "C:\Users\PC\Desktop\.NET-CORE\MVC Core\ShopApp\ShopApp.WebUI\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
