#pragma checksum "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\News.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad87f4ed680b9d771ff3bbd1ab5bf437562fe07a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_News), @"mvc.1.0.view", @"/Views/Home/News.cshtml")]
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
#line 1 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\_ViewImports.cshtml"
using WebAppDulich;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\_ViewImports.cshtml"
using WebAppDulich.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad87f4ed680b9d771ff3bbd1ab5bf437562fe07a", @"/Views/Home/News.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6afcb3ec0253960dd9d5a52169c06981518d2b09", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_News : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAppDulich.Data.News>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\News.cshtml"
  
    var lst = (IEnumerable<WebAppDulich.Data.News>)ViewBag.lst;
    ViewData["Title"] = "News";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"vnt-content\">\r\n    <div id=\"vnt-navation\" class=\"breadcrumb\">\r\n        <div class=\"wrapper\">\r\n            <div class=\"navation\">\r\n                <ul><li><a");
            BeginWriteAttribute("href", " href=\"", 363, "\"", 397, 1);
#nullable restore
#line 12 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\News.cshtml"
WriteAttributeValue("", 370, Url.Action("index","Home"), 370, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Trang ch???</a></li><li>Tin t???c m???i</li></ul>
            </div>
        </div>
    </div>

    <div class=""box_mid"">
        <div class=""wrapper"">
            <div class=""mid-title"">
                <div class=""title-main""><h1>Tin t???c t??? du l???ch Vi???t Nam</h1></div>
            </div>
            <div class=""mid-content"">
                <div class=""region region-content"">
                    <section id=""block-system-main"" class=""block block-system clearfix"">
                        <div class=""block-content"">
                            <div class=""view view-content-function view-id-content_function view-display-id-page_5 list-views row view-dom-id-5637221ba2403770c8e48a2cc8dd47e5"">
");
#nullable restore
#line 27 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\News.cshtml"
                                 foreach (var item in lst)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""view-content"">
                                        <div class=""views-row views-row-1 views-row-odd views-row-first col-sm-3"">
                                            <div class=""views-field views-field-field-news-image"">
                                                <div class=""field-content"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 1614, "\"", 1650, 2);
            WriteAttributeValue("", 1621, "/home/NewDescription/", 1621, 21, true);
#nullable restore
#line 34 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\News.cshtml"
WriteAttributeValue("", 1642, item.Id, 1642, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <img typeof=\"foaf:Image\"");
            BeginWriteAttribute("src", "\r\n                                                             src=\"", 1734, "\"", 1812, 1);
#nullable restore
#line 36 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\News.cshtml"
WriteAttributeValue("", 1802, item.Logo, 1802, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                                             width=\"270\" height=\"210\"");
            BeginWriteAttribute("alt", " alt=\"", 1900, "\"", 1906, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    </a>
                                                </div>
                                            </div>
                                            <br />
                                            <div class=""views-field views-field-nothing "">
                                                <span class=""field-content"">
                                                    <div class=""title mt-2"">
                                                        <a");
            BeginWriteAttribute("href", " href=\"", 2434, "\"", 2470, 2);
            WriteAttributeValue("", 2441, "/home/NewDescription/", 2441, 21, true);
#nullable restore
#line 45 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\News.cshtml"
WriteAttributeValue("", 2462, item.Id, 2462, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            ");
#nullable restore
#line 46 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\News.cshtml"
                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                        </a>
                                                    </div>
                                                    <br />
                                                    <div class=""footer_product"">
                                                        <br />
                                                        <div class=""footer_left pull-left"">
                                                            <div class=""post_date"">");
#nullable restore
#line 53 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\News.cshtml"
                                                                              Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                                        </div>

                                                    </div>
                                                </span>
                                            </div>
                                        </div>


                                    </div>
");
#nullable restore
#line 63 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\News.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n\r\n                        </div>\r\n                    </section>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAppDulich.Data.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
