#pragma checksum "C:\Users\sonmc\Desktop\New folder\AspnetMvcC11G1\WebApplication4\Views\Product\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe448ad87298462af1a5b45422ffd89373b4bba9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Delete), @"mvc.1.0.view", @"/Views/Product/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Delete.cshtml", typeof(AspNetCore.Views_Product_Delete))]
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
#line 1 "C:\Users\sonmc\Desktop\New folder\AspnetMvcC11G1\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4;

#line default
#line hidden
#line 2 "C:\Users\sonmc\Desktop\New folder\AspnetMvcC11G1\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe448ad87298462af1a5b45422ffd89373b4bba9", @"/Views/Product/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fff4eb847734ec2c3f91807e9b1a08bbda85e45", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<h1>Are you sure you want to delete \"");
            EndContext();
            BeginContext(38, 27, false);
#line 1 "C:\Users\sonmc\Desktop\New folder\AspnetMvcC11G1\WebApplication4\Views\Product\Delete.cshtml"
                                Write(ViewBag.ProductDeleted.Name);

#line default
#line hidden
            EndContext();
            BeginContext(65, 8, true);
            WriteLiteral("\"</h1>\r\n");
            EndContext();
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