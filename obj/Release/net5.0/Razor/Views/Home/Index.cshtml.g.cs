#pragma checksum "D:\Games\Site_10 — копия — копия\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0a79c26ac8aba574f232f1ca1607d449a4ad7c9"
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
#line 1 "D:\Games\Site_10 — копия — копия\Views\_ViewImports.cshtml"
using Site_1.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Games\Site_10 — копия — копия\Views\_ViewImports.cshtml"
using Site_1.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0a79c26ac8aba574f232f1ca1607d449a4ad7c9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6fb573fc01a872e2fa183fa3cdbc5b3be65a6ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Лучшие телефоны</h1>\r\n\r\n<div class=\"row mt-5 mb-2\">\r\n\r\n");
#nullable restore
#line 7 "D:\Games\Site_10 — копия — копия\Views\Home\Index.cshtml"
      
        foreach (Car car in Model.favCars)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Games\Site_10 — копия — копия\Views\Home\Index.cshtml"
       Write(Html.Partial("AllCars", car));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Games\Site_10 — копия — копия\Views\Home\Index.cshtml"
                                         ;
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
