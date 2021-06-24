#pragma checksum "C:\Users\dnmez\OneDrive\Masaüstü\.NET CORE\MVC Core\shopapp\shopapp.webui\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2207d07617be12934b6e269253e84e66fea9cd14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 1 "C:\Users\dnmez\OneDrive\Masaüstü\.NET CORE\MVC Core\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2207d07617be12934b6e269253e84e66fea9cd14", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6a2f9735f8df7cb46870cb1a0a73ac5a4e75cdb", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dnmez\OneDrive\Masaüstü\.NET CORE\MVC Core\shopapp\shopapp.webui\Views\Product\List.cshtml"
  
    var popularClass = Model.Products.Count>2? "popular":"";
    var products = Model.Products;
    var categoryName = Model.Category.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2207d07617be12934b6e269253e84e66fea9cd143499", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Product</title>
    <style>
        .popular {
            color:green;
            font-weight: 700;
        }
    </style>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2207d07617be12934b6e269253e84e66fea9cd145005", async() => {
                WriteLiteral(@"
    <div class=""navbar bg-primary navbar-dark navbar-expand-sm"">
        <div class=""container"">
        <ul class=""navbar-nav"">
            <li class=""nav-item"">
                <a href=""#"" class=""nav-link"">Link 1</a>
            </li>
            <li class=""nav-item"">
                <a href=""#"" class=""nav-link"">Link 1</a>
            </li>
            <li class=""nav-item"">
                <a href=""#"" class=""nav-link"">Link 1</a>
            </li>
        </ul>
        </div>
    </div>
    <header>
        <div class=""jumbotron jumbotron-fluid"">
            <div class=""container"">
                <h1 class=""display-4"">
                    ShopApp
                </h1>
                <p class=""lead"">Lorem ipsum, dolor sit amet consectetur adipisicing elit. Quisquam tenetur aspernatur necessitatibus repellendus nam id labore, quidem natus modi obcaecati sint quo vitae perspiciatis? Vero facere unde sunt error iure.</p>
            </div>
        </div>

    </header>
    <main>
 ");
                WriteLiteral("       <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <h1");
                BeginWriteAttribute("class", " class=\"", 1913, "\"", 1934, 1);
#nullable restore
#line 56 "C:\Users\dnmez\OneDrive\Masaüstü\.NET CORE\MVC Core\shopapp\shopapp.webui\Views\Product\List.cshtml"
WriteAttributeValue("", 1921, popularClass, 1921, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 56 "C:\Users\dnmez\OneDrive\Masaüstü\.NET CORE\MVC Core\shopapp\shopapp.webui\Views\Product\List.cshtml"
                                         Write(categoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n       \r\n        \r\n   \r\n\r\n");
#nullable restore
#line 63 "C:\Users\dnmez\OneDrive\Masaüstü\.NET CORE\MVC Core\shopapp\shopapp.webui\Views\Product\List.cshtml"
     if(products.Count ==0 )
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"row\"> \r\n        <div class=\"col-md-12\">\r\n            <div class=\"alert alert-danger\">\r\n                Ürün yok    \r\n            </div>\r\n        </div>\r\n        </div>\r\n");
#nullable restore
#line 72 "C:\Users\dnmez\OneDrive\Masaüstü\.NET CORE\MVC Core\shopapp\shopapp.webui\Views\Product\List.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"row\">\r\n\r\n        \r\n        \r\n");
#nullable restore
#line 79 "C:\Users\dnmez\OneDrive\Masaüstü\.NET CORE\MVC Core\shopapp\shopapp.webui\Views\Product\List.cshtml"
             foreach (var product in products)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div class=""col-md-3""> 
                       <div class=""card"">
                           <img src=""https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/iphone-12-pro-blue-hero?wid=940&hei=1112&fmt=png-alpha&.v=1604021661000""");
                BeginWriteAttribute("alt", " alt=\"", 2645, "\"", 2651, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"card-image-top\">\r\n                           <div class=\"card-body\">\r\n                               <h5 class=\"card-title\">");
#nullable restore
#line 85 "C:\Users\dnmez\OneDrive\Masaüstü\.NET CORE\MVC Core\shopapp\shopapp.webui\Views\Product\List.cshtml"
                                                 Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                               <p class=\"card-text\">");
#nullable restore
#line 86 "C:\Users\dnmez\OneDrive\Masaüstü\.NET CORE\MVC Core\shopapp\shopapp.webui\Views\Product\List.cshtml"
                                               Write(product.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                               <a");
                BeginWriteAttribute("href", " href=\"", 2915, "\"", 2922, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\">İncele</a>\r\n                           </div>\r\n                       </div>\r\n                   </div>\r\n");
#nullable restore
#line 91 "C:\Users\dnmez\OneDrive\Masaüstü\.NET CORE\MVC Core\shopapp\shopapp.webui\Views\Product\List.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                \r\n        \r\n        </div>\r\n");
#nullable restore
#line 95 "C:\Users\dnmez\OneDrive\Masaüstü\.NET CORE\MVC Core\shopapp\shopapp.webui\Views\Product\List.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </div>
    </main>
   
    







    <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
