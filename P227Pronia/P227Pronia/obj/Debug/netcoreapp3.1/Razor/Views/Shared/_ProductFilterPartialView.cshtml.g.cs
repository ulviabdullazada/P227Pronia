#pragma checksum "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad94e6b9378a894a1bee65849b14c54a84df80a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductFilterPartialView), @"mvc.1.0.view", @"/Views/Shared/_ProductFilterPartialView.cshtml")]
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
#line 2 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\_ViewImports.cshtml"
using P227Pronia.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\_ViewImports.cshtml"
using P227Pronia.ViewModels.Home;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad94e6b9378a894a1bee65849b14c54a84df80a6", @"/Views/Shared/_ProductFilterPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6a6c0c6bb0fefd1fc07fc936a2d8f46d75585c4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ProductFilterPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product Images"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div
                    class=""tab-pane fade show active""
                    id=""grid-view""
                    role=""tabpanel""
                    aria-labelledby=""grid-view-tab""
                  >
                    <div class=""product-grid-view row g-y-20"">
");
#nullable restore
#line 9 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
         foreach (var product in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-md-4 col-sm-6\">\r\n                                    <div class=\"product-item\">\r\n                                        <div class=\"product-img\">\r\n                                            <a>\r\n");
#nullable restore
#line 15 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
                                             foreach (var img in product.ProductImages.Where(pi => pi.Status != null))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad94e6b9378a894a1bee65849b14c54a84df80a64862", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
AddHtmlAttributeValue("", 825, img.Status==true?"primary-img":"secondary-img", 825, 49, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 930, "~/assets/images/website-images/", 930, 31, true);
#nullable restore
#line 18 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
AddHtmlAttributeValue("", 961, img.ImageUrl, 961, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </a>
                                            <div class=""product-add-action"">
                                                <ul>
                                                    <li>
                                                        <a href=""wishlist.html""
                                                    data-tippy=""Add to wishlist""
                                                    data-tippy-inertia=""true""
                                                    data-tippy-animation=""shift-away""
                                                    data-tippy-delay=""50""
                                                    data-tippy-arrow=""true""
                                                    data-tippy-theme=""sharpborder"">
                                                            <i class=""pe-7s-like""></i>
                                                        </a>
                                                    </li>
         ");
            WriteLiteral(@"                                           <li class=""quuickview-btn""
                                                data-bs-toggle=""modal""
                                                data-bs-target=""#quickModal"">
                                                        <a href=""#""
                                                    data-tippy=""Quickview""
                                                    data-tippy-inertia=""true""
                                                    data-tippy-animation=""shift-away""
                                                    data-tippy-delay=""50""
                                                    data-tippy-arrow=""true""
                                                    data-tippy-theme=""sharpborder"">
                                                            <i class=""pe-7s-look""></i>
                                                        </a>
                                                    </li>
                                             ");
            WriteLiteral(@"       <li>
                                                        <a href=""cart.html""
                                                    data-tippy=""Add to cart""
                                                    data-tippy-inertia=""true""
                                                    data-tippy-animation=""shift-away""
                                                    data-tippy-delay=""50""
                                                    data-tippy-arrow=""true""
                                                    data-tippy-theme=""sharpborder"">
                                                            <i class=""pe-7s-cart""></i>
                                                        </a>
                                                    </li>
                                                </ul>
                                            </div>
                                        </div>
                                        <div class=""product-content"">
                  ");
            WriteLiteral("                          <a class=\"product-name\"\r\n                                        href=\"single-product-variable.html\">");
#nullable restore
#line 64 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
                                                                       Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            <div class=\"price-box pb-1\">\r\n                                                <span class=\"new-price\">$");
#nullable restore
#line 66 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
                                                                    Write(product.SellPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </div>\r\n                                            <div class=\"rating-box\">\r\n                                                <ul>\r\n");
#nullable restore
#line 70 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
                                                     for (int i = 0; i < product.Raiting; i++)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <li><i class=\"fa fa-star\"></i></li>\r\n");
#nullable restore
#line 73 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </ul>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 79 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                  </div>\r\n<div\r\nclass=\"tab-pane fade\"\r\nid=\"list-view\"\r\nrole=\"tabpanel\"\r\naria-labelledby=\"list-view-tab\"\r\n>\r\n<div class=\"product-list-view row g-y-30\">\r\n");
#nullable restore
#line 89 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-12\">\r\n            <div class=\"product-item\">\r\n                <div class=\"product-img\">\r\n                    <a href=\"single-product-variable.html\">\r\n");
#nullable restore
#line 95 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
                         foreach (var item in product.ProductImages.Where(p=>p.Status != null))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("class", "\r\n                            class=\"", 5784, "\"", 5875, 1);
#nullable restore
#line 98 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
WriteAttributeValue("", 5821, (item.Status == true)?"primary-img":"secondary-img", 5821, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", "\r\n                            src=\"", 5876, "\"", 5954, 2);
            WriteAttributeValue("", 5911, "assets/images/website-images/", 5911, 29, true);
#nullable restore
#line 99 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
WriteAttributeValue("", 5940, item.ImageUrl, 5940, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                            alt=\"Product Images\"\r\n                            />\r\n");
#nullable restore
#line 102 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </a>\r\n                </div>\r\n                <div class=\"product-content\">\r\n                <a\r\n                    class=\"product-name\"\r\n                    href=\"single-product-variable.html\"\r\n                    >");
#nullable restore
#line 109 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
                Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a\r\n                >\r\n                <div class=\"price-box pb-1\">\r\n                    <span class=\"new-price\">$");
#nullable restore
#line 112 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
                                        Write(product.SellPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"rating-box\">\r\n                            <ul>\r\n");
#nullable restore
#line 116 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
                                 for (int i = 0; i < product.Raiting; i++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><i class=\"fa fa-star\"></i></li>\r\n");
#nullable restore
#line 119 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                </div>\r\n                <p class=\"short-desc mb-0\">\r\n                    ");
#nullable restore
#line 123 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
               Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
                <div class=""product-add-action"">
                    <ul>
                    <li>
                        <a
                        href=""wishlist.html""
                        data-tippy=""Add to wishlist""
                        data-tippy-inertia=""true""
                        data-tippy-animation=""shift-away""
                        data-tippy-delay=""50""
                        data-tippy-arrow=""true""
                        data-tippy-theme=""sharpborder""
                        >
                        <i class=""pe-7s-like""></i>
                        </a>
                    </li>
                    <li
                        class=""quuickview-btn""
                        data-bs-toggle=""modal""
                        data-bs-target=""#quickModal""
                    >
                        <a
                        href=""#""
                        data-tippy=""Quickview""
                        data-tippy-inertia=""true""
             ");
            WriteLiteral(@"           data-tippy-animation=""shift-away""
                        data-tippy-delay=""50""
                        data-tippy-arrow=""true""
                        data-tippy-theme=""sharpborder""
                        >
                        <i class=""pe-7s-look""></i>
                        </a>
                    </li>
                    <li>
                        <a
                        href=""cart.html""
                        data-tippy=""Add to cart""
                        data-tippy-inertia=""true""
                        data-tippy-animation=""shift-away""
                        data-tippy-delay=""50""
                        data-tippy-arrow=""true""
                        data-tippy-theme=""sharpborder""
                        >
                        <i class=""pe-7s-cart""></i>
                        </a>
                    </li>
                    </ul>
                </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 175 "C:\Users\Ülvi\Desktop\P227 Pronia\P227Pronia\P227Pronia\Views\Shared\_ProductFilterPartialView.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
