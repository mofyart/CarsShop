#pragma checksum "C:\Users\Артем\Desktop\Site_10 — копия — копия\Views\OneCart\OneCar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd85ac9f7fb5237539b035a58eb44eda78990b50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OneCart_OneCar), @"mvc.1.0.view", @"/Views/OneCart/OneCar.cshtml")]
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
#line 1 "C:\Users\Артем\Desktop\Site_10 — копия — копия\Views\_ViewImports.cshtml"
using Site_1.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Артем\Desktop\Site_10 — копия — копия\Views\_ViewImports.cshtml"
using Site_1.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd85ac9f7fb5237539b035a58eb44eda78990b50", @"/Views/OneCart/OneCar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6fb573fc01a872e2fa183fa3cdbc5b3be65a6ff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_OneCart_OneCar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OneCarViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShopCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <style>
        .cotaier {
            position: relative;
            z-index: 10;
            display: inline-flex;
            justify-content: center;
            align-items: center;
            margin: 20px;
        }

            .cotaier .card {
                position: relative;
                width: 500px;
                height: 600px;
                justify-content: center;
                align-items: center;
                flex-direction: column;
                background: rgba(255, 255, 255, 0.05);
                box-shadow: 0 10px 25px rgba(0, 0, 0, 0.2)
            }

                .cotaier .card .ig {
                    position: relative;
                    display: flex;
                    justify-content: center;
                    align-items: center;
                    flex-direction: column;
                    padding: 39px;
                    transition: 0.5s ease-in-out;
                }

                    .cotaier .card .ig img {");
            WriteLiteral(@"
                        width: 200px;
                        height: 200px;
                        margin: -200px 0 20px;
                        transition: 0.5s ease-in-out;
                    }

                .cotaier .card:hover .ig img {
                    transform: scale(1.4);
                }

                .cotaier .card .ig h2 {
                    margin: 20px;
                    font-weight: 400;
                }

                .cotaier .card .content {
                    position: absolute;
                    bottom: -150px;
                    display: flex;
                    justify-content: center;
                    align-items: center;
                    flex-direction: column;
                    transition: 0.5s ease-in-out;
                }

            


                .cotaier .card .content .size,
                .cotaier .card .content .color,
                .cotaier .card .content .price {
                    display: flex;
    ");
            WriteLiteral(@"                justify-content: center;
                    align-items: center;
                    padding: 8px 20px;
                }

                    .cotaier .card .content .size h3,
                    .cotaier .card .content .color h3,
                    .cotaier .card .content .price h3 {
                        font-weight: 400;
                        font-size: 18px;
                        text-transform: uppercase;
                        letter-spacing: 2px;
                        margin-right: 10px;
                    }

                    .cotaier .card .content .size span {
                        height: 26px;
                        text-align: center;
                        line-height: 17px;
                        display: inline-block;
                        color: #111;
                        background: #fff;
                        border-radius: 4px;
                        font-weight: 500;
                        transition: 0.5s;
            ");
            WriteLiteral(@"            cursor: pointer;
                    }

                        .cotaier .card .content .size span:hover {
                            background: #111;
                            color: #fff;
                        }


                    .cotaier .card .content .price span {
                        height: 20px;
                        line-height: 11px;
                        font-weight: 500;
                        border-radius: 50%;
                        color: black;
                    }

                .cotaier .card .content a {
                    position: relative;
                    display: inline-block;
                    background: black;
                    border-radius: 40px;
                    font-weight: 600;
                    letter-spacing: 1px;
                    color: white;
                }
 
        .cotaier .card .content .color span {
            width: 40px;
            height: 26px;
            text-align: center;
    ");
            WriteLiteral(@"        line-height: 16px;
            display: inline-block;
            color: #111;
            background: #fff;
            border-radius: 4px;
            font-weight: 500;
        }
        .rounded {
            counter-reset: li;
            list-style: none;
            font: 14px;
            padding: 0;
            text-shadow: 0 1px 0;
        }

            .rounded a {
                position: relative;
                display: block;
                padding: .10em .10em .10em 4em;
                margin: .5em 0;
                background: #eff3fc;
                color:black;
                text-decoration: none;
                border-radius: .3em;
                transition: .10s ease-out;
            }

                .rounded a:hover {
                    background: white;
                }

                    .rounded a:hover:before {
                        transform: rotate(360deg);
                    }

                .rounded a:before {
    ");
            WriteLiteral(@"                content: counter(li);
                    counter-increment: li;
                    position: absolute;
                    left: -1.3em;
                    top: 50%;
                    margin-top: -1.3em;
                    background: #e8ebfe;
                    height: 2em;
                    width: 2em;
                    line-height: 2em;
                    border: .3em solid #111;
                    text-align: center;
                    font-weight: bold;
                    border-radius: 2em;
                    transition: all .3s ease-out;
                }
        .conte {
            color: #edc251;
            padding: 0 0 400px 50px;
            font-size: 110%;
            text-indent: 60px;
        }
        .conte h2 {
            font: 50px;
            color: black;
            margin: 10px 0 20px 0;
            text-indent: 0;
        }

        .conte p {
            margin: 0 0 40px 0;
            text-align: justify;
        }
");
            WriteLiteral("    </style>\r\n    <div class=\"cotaier\">\r\n\r\n\r\n        <div class=\"card \">\r\n            <div class=\"ig\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 6292, "\"", 6315, 1);
#nullable restore
#line 197 "C:\Users\Артем\Desktop\Site_10 — копия — копия\Views\OneCart\OneCar.cshtml"
WriteAttributeValue("", 6298, Model.OneCar.img, 6298, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <h2> ");
#nullable restore
#line 198 "C:\Users\Артем\Desktop\Site_10 — копия — копия\Views\OneCart\OneCar.cshtml"
                Write(Model.OneCar.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n                <div class=\"content\">\r\n                    <div class=\"price\">\r\n                        <h3>Цена:</h3>\r\n                        <span>");
#nullable restore
#line 203 "C:\Users\Артем\Desktop\Site_10 — копия — копия\Views\OneCart\OneCar.cshtml"
                         Write(Model.OneCar.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</span>\r\n                    </div>\r\n                   \r\n                    <div class=\"size\">\r\n\r\n                        <h3>Размер паямяти:</h3>\r\n                        <span>");
#nullable restore
#line 209 "C:\Users\Артем\Desktop\Site_10 — копия — копия\Views\OneCart\OneCar.cshtml"
                         Write(Model.OneCar.size);

#line default
#line hidden
#nullable disable
            WriteLiteral(" gb</span>\r\n\r\n                    </div>\r\n\r\n                    <div class=\"color\">\r\n                        <h3>Цвет:</h3>\r\n\r\n                        <span>");
#nullable restore
#line 216 "C:\Users\Артем\Desktop\Site_10 — копия — копия\Views\OneCart\OneCar.cshtml"
                         Write(Model.OneCar.color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                    </div>\r\n                    <p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd85ac9f7fb5237539b035a58eb44eda78990b5012531", async() => {
                WriteLiteral("Добавить в корзину");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 221 "C:\Users\Артем\Desktop\Site_10 — копия — копия\Views\OneCart\OneCar.cshtml"
                                                    WriteLiteral(Model.OneCar.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </p>\r\n\r\n                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"conte\">\r\n            <h2>Информация:</h2>\r\n\r\n            <ol class=\"rounded\">\r\n                <li><a href=\"#\">Операционная система: ");
#nullable restore
#line 233 "C:\Users\Артем\Desktop\Site_10 — копия — копия\Views\OneCart\OneCar.cshtml"
                                                 Write(Model.OneCar.oper);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                <li><a href=\"#\">Дисплей: ");
#nullable restore
#line 234 "C:\Users\Артем\Desktop\Site_10 — копия — копия\Views\OneCart\OneCar.cshtml"
                                    Write(Model.OneCar.dis);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></li>\r\n                <li><a href=\"#\">Разрешение дисплея: ");
#nullable restore
#line 235 "C:\Users\Артем\Desktop\Site_10 — копия — копия\Views\OneCart\OneCar.cshtml"
                                               Write(Model.OneCar.raz);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                <li><a href=\"#\">Процессор: ");
#nullable restore
#line 236 "C:\Users\Артем\Desktop\Site_10 — копия — копия\Views\OneCart\OneCar.cshtml"
                                      Write(Model.OneCar.proz);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                <li><a href=\"#\">Объем оперативной памяти: ");
#nullable restore
#line 237 "C:\Users\Артем\Desktop\Site_10 — копия — копия\Views\OneCart\OneCar.cshtml"
                                                     Write(Model.OneCar.ob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n            </ol>\r\n\r\n        </div>\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OneCarViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
