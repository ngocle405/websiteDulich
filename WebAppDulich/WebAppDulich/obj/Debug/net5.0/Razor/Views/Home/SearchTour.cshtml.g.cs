#pragma checksum "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\SearchTour.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2625b9febc178d19b686992268cf9aeef0f8af2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SearchTour), @"mvc.1.0.view", @"/Views/Home/SearchTour.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2625b9febc178d19b686992268cf9aeef0f8af2f", @"/Views/Home/SearchTour.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6afcb3ec0253960dd9d5a52169c06981518d2b09", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SearchTour : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formSearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("formSearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://dulichvietnam.com.vn/tour/tour.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\SearchTour.cshtml"
  
    var ListTour = (List<WebAppDulich.Data.Tour>)ViewBag.ListTour;
    ViewData["Title"] = "SearchTour";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .box-filter {
        border: 1px solid #dddddd;
        margin-bottom: 20px;
        -webkit-box-shadow: 4px 4px 4px rgb(0 0 0 / 5%);
        -moz-box-shadow: 4px 4px 4px rgba(0, 0, 0, 0.05);
        box-shadow: 4px 4px 4px rgb(0 0 0 / 5%);
    }
    .box-filter .item-filter {
        padding: 15px;
        border-bottom: 1px solid #dddddd;
    }
    .filterTitle {
        font-size: 16px;
        line-height: 25px;
        font-weight: bold;
        margin-bottom: 10px;
        color: #0062a7;
        text-transform: uppercase;
    }
    .box-filter .filter-title {
        font-size: 16px;
        line-height: 20px;
        text-transform: uppercase;
        font-weight: bold;
        background: #f6f6f6;
        padding: 10px 15px;
    }
    .block-filter .grid {
        display: -webkit-box;
        display: -moz-box;
        display: -ms-flexbox;
        display: flex;
        align-items: center;
        margin: 0 -10px;
        flex-wrap: wrap;
    }
   ");
            WriteLiteral(@" .tour-detail {
        border: 1px solid #dddddd;
        -webkit-box-shadow: 4px 4px 4px rgb(0 0 0 / 5%);
        -moz-box-shadow: 4px 4px 4px rgba(0, 0, 0, 0.05);
        box-shadow: 4px 4px 4px rgb(0 0 0 / 5%);
        padding: 19px;
    }

    element.style {
    }

    .tour-detail .i-img {
        width: 240px;
         margin-right: 20px; 
         float: left; 
    }
    .tour-detail .i-info {
        width: 160px;
        float: right;
        text-align: right;
    }
    .tour-detail .i-desc {
        float: left;
        width: -webkit-calc(100% - 440px);
        width: -moz-calc(100% - 440px);
        width: calc(100% - 440px);
    }
    .tour-detail .i-price {
        font-size: 22px;
        line-height: 30px;
        color: #d82727;
        font-weight: bold;
        margin-bottom: 5px;
    }
</style>
<div id=""vnt-content"">
    <div class=""bg-search"">
        <div class=""style-search"">
            <div class=""wrapper"">
                <div class=""form-sea");
            WriteLiteral(@"rch"">
                    <div class=""fs-row"">
                        <div class=""fs-cel fs-search"">
                            <div class=""sp20 bre"">
                                <div class=""title-search"">TÌM TOUR THEO ĐIỂM ĐẾN</div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2625b9febc178d19b686992268cf9aeef0f8af2f7451", async() => {
                WriteLiteral(@"
                                    <div class=""typeAHeadDiv"" id=""typeAHeadDiv"">
                                        <div class=""form-group"">
                                            <div class=""input-group"">
                                                <span class=""twitter-typeahead"" style=""position: relative; display: inline-block;""><input type=""text"" class=""form-control typeahead tt-hint""");
                BeginWriteAttribute("readonly", " readonly=\"", 3004, "\"", 3015, 0);
                EndWriteAttribute();
                WriteLiteral(@" autocomplete=""off"" spellcheck=""false"" tabindex=""-1"" dir=""ltr"" style=""position: absolute; top: 0px; left: 0px; border-color: transparent; box-shadow: none; opacity: 1; background: none 0% 0% / auto repeat scroll padding-box border-box rgb(238, 238, 238);""><input type=""text"" class=""form-control typeahead tt-input"" name=""keyword"" id=""idSearch"" placeholder=""Tên thành phố, khu vực ..."" autocomplete=""off"" spellcheck=""false"" dir=""auto"" style=""position: relative; vertical-align: top; background-color: transparent;""><pre aria-hidden=""true"" style=""position: absolute; visibility: hidden; white-space: pre; font-family: Muli, sans-serif; font-size: 14px; font-style: normal; font-variant: normal; font-weight: 400; word-spacing: 0px; letter-spacing: 0px; text-indent: 0px; text-rendering: auto; text-transform: none;""></pre><div class=""tt-menu"" style=""position: absolute; top: 100%; left: 0px; z-index: 100; display: none;""><div class=""tt-dataset tt-dataset-locations""></div><div class=""tt-dataset tt-dataset-pointofinterests""><");
                WriteLiteral(@"/div><div class=""tt-dataset tt-dataset-tours""></div><div class=""tt-dataset tt-dataset-popularLocation""></div></div></span>
                                                <span class=""input-group-btn"">
                                                    <button class=""btn searchButton"" id=""searchButton""><span><i class=""fab fa-sistrix""></i></span></button>
                                                </span>
                                            </div>
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""fs-cel fs-tour"">
                            <div class=""sp20"">
                              
                                
                            </div>
                        </div>
                    </div>
                </div>
                <link href=""https://dulichvietnam.com.vn/tour/js/search/search.css"" rel=""stylesheet"" type=""text/css"">




            </div>
        </div>
    </div>

    <div id=""vnt-navation"" class=""breadcrumb"">
        <div class=""wrapper"">
            <div class=""navation"">
                <ul><li><a href=""https://dulichvietnam.com.vn/tour/"">Trang chủ</a></li><li><a href=""https://dulichvietnam.com.vn/tour/tour.html"">Tour du lịch</a></li></ul>
            </div>
        </div>
    </div>
    <div class=""box_mid"">
        <div class=""wrapper"">
            <div class=""mid-title"">
                <div class=""fl""><h1 class=""title-main"">Tou");
            WriteLiteral(@"r du lịch</h1></div>
                <div class=""fr"">
                    
                    <div class=""hidden-lg hidden-md visible-sm visible-xs"">
                        <div class=""popup_mobile"" id=""sapxep"">
                            <div class=""pmTitle"">Sắp xếp</div>
                            <div class=""pmClose""><i class=""fa fa-times""></i></div>
                            <div class=""pmContent"">
                                <div class=""list-filter"">
                                    <ul>
                                        <li class=""current""><a href=""https://dulichvietnam.com.vn/tour/tour.html/?sort=0"" class=""current"">Sắp xếp theo</a></li>
                                        <li><a href=""https://dulichvietnam.com.vn/tour/tour.html/?sort=1"">Mới nhất</a></li>
                                        <li><a href=""https://dulichvietnam.com.vn/tour/tour.html/?sort=2"">Giá tăng dần</a></li>
                                        <li><a href=""https://dulichvietnam.com.vn/tour/t");
            WriteLiteral(@"our.html/?sort=3"">Giá giảm dần</a></li>
                                        <li><a href=""https://dulichvietnam.com.vn/tour/tour.html/?sort=4"">Xem nhiều</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""clear""></div>
            </div>
            <div class=""mid-content"">
                <div class=""hidden-lg hidden-md visible-sm visible-xs"">
                    
                </div>
                <div class=""row cel-p10"">
                    <div class=""col-md-3 col-sm-12 col-xs-12"">
                        <div class=""popup_mobile"">
                            <div class=""pmContent"">
                                <div class=""box-filter"">
                                    <div class=""filter-title"">TÌM KIẾM</div>
                                    <div class=""item-filter"">
                      ");
            WriteLiteral(@"                  <div class=""filterTitle""><h2>Theo loại hình</h2></div><div class=""filterContent"">
                                            <ul class=""ul_filter"">
                                                <li class=""li-show"">
                                                    <label data-link=""https://dulichvietnam.com.vn/tour/tour.html/?cat_id=36"">
                                                        <input type=""checkbox"">
                                                        <span class=""check""></span>
                                                        <span>Tour lễ 30.4</span>
                                                    </label>
                                                </li>
                                                <li class=""li-show"">
                                                    <label data-link=""https://dulichvietnam.com.vn/tour/tour.html/?cat_id=22"">
                                                        <input type=""checkbox"">
            ");
            WriteLiteral(@"                                            <span class=""check""></span>
                                                        <span>Tour bán chạy, HOT</span>
                                                    </label>
                                                </li>
                                                <li class=""li-show"">
                                                    <label data-link=""https://dulichvietnam.com.vn/tour/tour.html/?cat_id=13"">
                                                        <input type=""checkbox"">
                                                        <span class=""check""></span>
                                                        <span>Tour ngắn tại điểm, City tour, hàng ngày</span>
                                                    </label>
                                                </li>
                                                <li class=""li-show"">
                                                    <label data-link=""https://dulic");
            WriteLiteral(@"hvietnam.com.vn/tour/tour.html/?cat_id=12"">
                                                        <input type=""checkbox"">
                                                        <span class=""check""></span>
                                                        <span>Tour lẻ ghép đường bay</span>
                                                    </label>
                                                </li>
                                                <li class=""li-show"">
                                                    <label data-link=""https://dulichvietnam.com.vn/tour/tour.html/?cat_id=35"">
                                                        <input type=""checkbox"">
                                                        <span class=""check""></span>
                                                        <span>Tour lẻ ghép đường bộ</span>
                                                    </label>
                                                </li>
                  ");
            WriteLiteral(@"                              <li class=""li-show"">
                                                    <label data-link=""https://dulichvietnam.com.vn/tour/tour.html/?cat_id=30"">
                                                        <input type=""checkbox"">
                                                        <span class=""check""></span>
                                                        <span>Tour cho khách đoàn, Gala, Teambuilding</span>
                                                    </label>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class=""item-filter group open"">
                                        <div class=""filterTitle""><h2>ĐIỂM ĐẾN</h2></div>
                                        <div class=""filterTitle sub"">NỘI ĐỊA<div class=""btn-more-less""><span class=""less""></span></div></div><di");
            WriteLiteral(@"v class=""filterContent"">
                                            <ul class=""ul_filter"">
                                                <li class=""li-show"">
                                                    <label class=""current"" data-link=""https://dulichvietnam.com.vn/tour/tour.html/?place_id=56"">
                                                        <input type=""checkbox""");
            BeginWriteAttribute("checked", " checked=\"", 12197, "\"", 12207, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                        <span class=""check""></span>
                                                        <span>Miền Bắc</span>
                                                    </label>

                                                </li>
                                                <li class=""li-show"">
                                                    <a data-toggle=""collapse"" href=""#divPoint_4"" aria-expanded=""false"" aria-controls=""divPoint_4"" class=""arr-sub collapsed""><i class=""fas fa-angle-down""></i></a>
                                                    <label data-link=""https://dulichvietnam.com.vn/tour/tour.html/?place_id=1"">
                                                        <input type=""checkbox"">
                                                        <span class=""check""></span>
                                                        <span>Hà Nội</span>
                                                    </label>
                       ");
            WriteLiteral(@"                             <ul class=""collapse "" id=""divPoint_4""><li><label data-link=""https://dulichvietnam.com.vn/tour/tour.html/?point_id=6&amp;place_id=1""><input type=""checkbox""><span class=""check""></span> <span>Chùa Một Cột</span></label></li><li><label data-link=""https://dulichvietnam.com.vn/tour/tour.html/?point_id=4&amp;place_id=1""><input type=""checkbox""><span class=""check""></span> <span>Hồ Hoàn Kiếm</span></label></li></ul>
                                                </li>
                                                <li class=""li-show"">
                                                    <a data-toggle=""collapse"" href=""#divPoint_31"" aria-expanded=""false"" aria-controls=""divPoint_31"" class=""arr-sub collapsed""><i class=""fas fa-angle-down""></i></a>
                                                    <label data-link=""https://dulichvietnam.com.vn/tour/tour.html/?place_id=30"">
                                                        <input type=""checkbox"">
                                   ");
            WriteLiteral(@"                     <span class=""check""></span>
                                                        <span>Sapa</span>
                                                    </label>
                                                    <ul class=""collapse "" id=""divPoint_31""><li><label data-link=""https://dulichvietnam.com.vn/tour/tour.html/?point_id=31&amp;place_id=30""><input type=""checkbox""><span class=""check""></span> <span>Thị trấn Sapa</span></label></li></ul>
                                                </li>
                                                <li class=""li-show"">
                                                    <a data-toggle=""collapse"" href=""#divPoint_57"" aria-expanded=""false"" aria-controls=""divPoint_57"" class=""arr-sub collapsed""><i class=""fas fa-angle-down""></i></a>
                                                    <label data-link=""https://dulichvietnam.com.vn/tour/tour.html/?place_id=31"">
                                                        <input type=""checkbox"">
    ");
            WriteLiteral(@"                                                    <span class=""check""></span>
                                                        <span>Hà Giang</span>
                                                    </label>
                                                    <ul class=""collapse "" id=""divPoint_57""><li><label data-link=""https://dulichvietnam.com.vn/tour/tour.html/?point_id=82&amp;place_id=31""><input type=""checkbox""><span class=""check""></span> <span>Mèo Vạc</span></label></li><li><label data-link=""https://dulichvietnam.com.vn/tour/tour.html/?point_id=58&amp;place_id=31""><input type=""checkbox""><span class=""check""></span> <span>Thung lũng Sủng Là</span></label></li><li><label data-link=""https://dulichvietnam.com.vn/tour/tour.html/?point_id=57&amp;place_id=31""><input type=""checkbox""><span class=""check""></span> <span>Đồng Văn</span></label></li></ul>
                                                </li>
                                                <li class=""li-show"">
                           ");
            WriteLiteral(@"                         <a data-toggle=""collapse"" href=""#divPoint_64"" aria-expanded=""false"" aria-controls=""divPoint_64"" class=""arr-sub collapsed""><i class=""fas fa-angle-down""></i></a>
                                                    <label data-link=""https://dulichvietnam.com.vn/tour/tour.html/?place_id=71"">
                                                        <input type=""checkbox"">
                                                        <span class=""check""></span>
                                                        <span>Vĩnh Phúc</span>
                                                    </label>
                                                    <ul class=""collapse "" id=""divPoint_64""><li><label data-link=""https://dulichvietnam.com.vn/tour/tour.html/?point_id=83&amp;place_id=71""><input type=""checkbox""><span class=""check""></span> <span>Tam Đảo</span></label></li><li><label data-link=""https://dulichvietnam.com.vn/tour/tour.html/?point_id=64&amp;place_id=71""><input type=""checkbox""><span clas");
            WriteLiteral(@"s=""check""></span> <span>Đại Lải</span></label></li></ul>
                                                </li>
                                                <li class=""li-show"">
                                                    <label data-link=""https://dulichvietnam.com.vn/tour/tour.html/?place_id=91"">
                                                        <input type=""checkbox"">
                                                        <span class=""check""></span>
                                                        <span>Vinh</span>
                                                    </label>

                                                </li>
                                                
                                                
                                            </ul><div class=""div-more-less""><span class=""txt-more"">Xem thêm</span><span class=""txt-less"">Rút gọn</span></div>
                                        </div>
                                        <div");
            WriteLiteral(@" class=""filterTitle sub"">QUỐC TẾ<div class=""btn-more-less""><span class=""less""></span></div></div><div class=""filterContent"">
                                            <div class=""div-more-less""><span class=""txt-more"">Xem thêm</span><span class=""txt-less"">Rút gọn</span></div>
                                        </div>
                                    </div>



                                </div>


                            </div>
                        </div>

                        <div class=""div_adv hidden-sm hidden-xs"">
                            <div class=""advertise""><a href=""https://dulichvietnam.com.vn/tour/lich-khoi-hanh.html""");
            BeginWriteAttribute("title", " title=\"", 19025, "\"", 19033, 0);
            EndWriteAttribute();
            WriteLiteral(" onmousedown=\"return rwt(this,\'advertise\',\'27\')\" target=\"_blank\"><img src=\"https://dulichvietnam.com.vn/tour/vnt_upload/weblink/banner-lich-khoi-hanh.png\"");
            BeginWriteAttribute("alt", " alt=\"", 19188, "\"", 19194, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></div>
                        </div>
                    </div>
                    <div class=""col-md-9 col-sm-12 col-xs-12"">

                        <div class=""block-filter"">
                            
                        </div>

                        <div class=""list-tour"" id=""ext_load_more"">
");
#nullable restore
#line 294 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\SearchTour.cshtml"
                             if (ListTour.Count() > 0)
                            {
                                foreach (var item in ListTour)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"item\">\r\n                                    <div class=\"tour-detail\">\r\n                                        <div class=\"i-img\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 19926, "\"", 19957, 2);
            WriteAttributeValue("", 19933, "/home/OrderTour/", 19933, 16, true);
#nullable restore
#line 301 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\SearchTour.cshtml"
WriteAttributeValue("", 19949, item.Id, 19949, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 20013, "\"", 20029, 1);
#nullable restore
#line 302 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\SearchTour.cshtml"
WriteAttributeValue("", 20019, item.Logo, 20019, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 20030, "\"", 20046, 1);
#nullable restore
#line 302 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\SearchTour.cshtml"
WriteAttributeValue("", 20036, item.Logo, 20036, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            </a>
                                            <div class=""ribbon""><div class=""rib"" style=""background-color: #d82727;  border-color: #d82727"">TOUR BÁN CHẠY</div></div>
                                        </div>
                                        <div class=""i-desc"">
                                            <div class=""i-title"">
                                                <h3 class=""title""><a");
            BeginWriteAttribute("href", " href=\"", 20513, "\"", 20544, 2);
            WriteAttributeValue("", 20520, "/home/OrderTour/", 20520, 16, true);
#nullable restore
#line 308 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\SearchTour.cshtml"
WriteAttributeValue("", 20536, item.Id, 20536, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 308 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\SearchTour.cshtml"
                                                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                            </div>\r\n                                            <div class=\"i-content\">\r\n                                                <div><strong>Loại hình:</strong>");
#nullable restore
#line 311 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\SearchTour.cshtml"
                                                                           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                <div><strong>Điểm đi:</strong> ");
#nullable restore
#line 312 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\SearchTour.cshtml"
                                                                          Write(item.DeparturePoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                <div><strong>Điểm đến:</strong> ");
#nullable restore
#line 313 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\SearchTour.cshtml"
                                                                           Write(item.PlaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                <div><strong>Địa danh:</strong> ");
#nullable restore
#line 314 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\SearchTour.cshtml"
                                                                           Write(item.Destination);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                <div><strong>Thời gian:</strong> ");
#nullable restore
#line 315 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\SearchTour.cshtml"
                                                                            Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                <div><strong>Ghi chú:</strong> Xuất phát ");
#nullable restore
#line 316 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\SearchTour.cshtml"
                                                                                    Write(item.Start);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                            </div>
                                        </div>
                                        <div class=""i-info"">
                                            <div>Giá 1 khách</div>
                                            <div class=""i-price""> ");
#nullable restore
#line 321 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\SearchTour.cshtml"
                                                             Write(double.Parse(item.Price.ToString()).ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"   đ</div>

                                            <div>
                                                <a class=""btn btn-danger"" href=""#"">Chi tiết<i class=""fa fa-chevron-right""></i></a>
                                            </div>
                                            <div class=""i-icon"" style=""display: none"">
                                                <ul>
                                                    <li title=""Máy bay""><i class=""fa fa-plane""></i></li>
                                                    <li title=""Ô tô""><i class=""fa fa-bus""></i></li>
                                                </ul>
                                            </div>
                                        </div>
                                        <div class=""clear""></div>
                                    </div>
                                </div>
");
#nullable restore
#line 336 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\SearchTour.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        <div class=\"tour-desc desc\"></div>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
