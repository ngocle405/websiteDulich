#pragma checksum "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a21bdbfa3574dcb2a10da4ef9b719d9af0c72ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a21bdbfa3574dcb2a10da4ef9b719d9af0c72ca", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6afcb3ec0253960dd9d5a52169c06981518d2b09", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formContact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("formContact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://dulichvietnam.com.vn/tour/lien-he.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form validate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"vnt-content\">\r\n    <div id=\"vnt-navation\" class=\"breadcrumb\"");
            BeginWriteAttribute("itemscope", " itemscope=\"", 163, "\"", 175, 0);
            EndWriteAttribute();
            WriteLiteral(" itemtype=\"http://data-vocabulary.org/Breadcrumb\">\r\n        <div class=\"wrapper\">\r\n            <div class=\"navation\">\r\n                <ul><li><a");
            BeginWriteAttribute("href", " href=\"", 321, "\"", 355, 1);
#nullable restore
#line 11 "C:\Users\Administrator\Documents\websiteDulich\WebAppDulich\WebAppDulich\Views\Home\Contact.cshtml"
WriteAttributeValue("", 328, Url.Action("Index","Home"), 328, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Trang chủ</a></li><li>Liên hệ</li></ul>
            </div>
        </div>
    </div>
    <div class=""box_mid"">
        <div class=""wrapper"">
            <div class=""mid-title"">
                <div class=""title-main""><h1>Liên hệ - góp ý</h1></div>
            </div>
            <div class=""mid-content"">
                <script type=""text/javascript"" src=""//www.google.com/jsapi""></script>
                <script type=""text/javascript"" src=""//maps.google.com/maps/api/js?key=AIzaSyAF7B1zmIAlQY8iNRMYZoxxWFJ-ruFJdSQ&amp;language=vi
""></script>
                <script type=""text/javascript"" src=""https://dulichvietnam.com.vn/tour/js/google/gmaps.js""></script>

                

                <div class=""list-contact"">


                    <div class=""item"">
                        <div class=""row cel-p10"">
                            <div class=""col-md-2 col-sm-12 col-xs-12"">
                                <div class=""m5-0"">
                                    <div class=""title-contact"">");
            WriteLiteral(@"Hà Nội</div>
                                </div>
                            </div>
                            <div class=""col-md-10 col-sm-12 col-xs-12"">
                                <div class=""mb3"">
                                    <p>
                                        <strong>Văn phòng 1:</strong> 93 Hồng Hà, Ba Đình, Hà Nội. <a data-fancybox-type=""iframe"" href=""https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3723.722891801325!2d105.848055!3d21.043771!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3135abb742bcfb8d%3A0x14ead33bc4005d0!2zTOG7ryBIw6BuaCBRdeG7kWMgVOG6vyBIb8OgbmcgVmnhu4d0IE9wZW4!5e0!3m2!1svi!2sus!4v1547787270887"">map</a><br>
                                        <strong>Văn phòng 2:</strong>&nbsp;Số 48 Tố Hữu, Nam Từ Liêm, Hà Nội<br>
                                        <strong>Văng phòng 3:</strong>&nbsp;Số 126 Trần Vỹ, Cầu Giấy, Hà Nội<br>
                                        Hotline:&nbsp;<strong><a href=""http://mailto:0936206998""><span style=""color:#ff0000;"">0936");
            WriteLiteral(@"206998</span></a></strong>
                                    </p>
                                </div>

                                <div id=""gtx-trans"" style=""position: absolute; left: 297px; top: -20px;"">
                                    <div class=""gtx-trans-icon"">&nbsp;</div>
                                </div>
                            </div>
                        </div>
                    </div>


                    <div class=""item"">
                        <div class=""row cel-p10"">
                            <div class=""col-md-2 col-sm-12 col-xs-12"">
                                <div class=""m5-0"">
                                    <div class=""title-contact"">Tp Hồ Chí Minh</div>
                                </div>
                            </div>
                            <div class=""col-md-10 col-sm-12 col-xs-12"">
                                <div class=""mb3"">
                                    <p>
                                        <stron");
            WriteLiteral(@"g>Văn phòng:</strong>&nbsp;Số 9 Phan Kế Bính, Quận 1, Tp HCM.&nbsp;<a data-fancybox-type=""iframe"" href=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3919.284279112331!2d106.69721581411655!3d10.78952546190375!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x317528caae8fe639%3A0x916f3e772bab70fa!2zOSBQaGFuIEvhur8gQsOtbmgsIMSQYSBLYW8sIFF14bqtbiAxLCBI4buTIENow60gTWluaCwgVmnhu4d0IE5hbQ!5e0!3m2!1svi!2s!4v1549965560058"">map</a><br>
                                        Tel: <strong><a href=""tel:0898580008""><span style=""color:#ff0000;"">0904 555 908&nbsp;</span></a></strong>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>


                    <div class=""item"">
                        <div class=""row cel-p10"">
                            <div class=""col-md-2 col-sm-12 col-xs-12"">
                                <div class=""m5-0"">
                                    <d");
            WriteLiteral(@"iv class=""title-contact"">Đà Nẵng</div>
                                </div>
                            </div>
                            <div class=""col-md-10 col-sm-12 col-xs-12"">
                                <div class=""mb3"">
                                    <strong>Văn phòng:</strong>&nbsp;Tầng 1 - 76 Bạch Đằng, Hải Châu, Đà Nẵng.&nbsp;<a data-fancybox-type=""iframe"" href=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3833.915366607361!2d108.22245831416984!3d16.069881043690515!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31421831f3ba9267%3A0xdb62594c60781d6c!2zNzYgQuG6oWNoIMSQ4bqxbmcsIEjhuqNpIENow6J1IDEsIEjhuqNpIENow6J1LCDEkMOgIE7hurVuZyA1NTAwMDAsIFZp4buHdCBOYW0!5e0!3m2!1svi!2s!4v1549966204591"">map</a><br>
                                    Tel: <strong><a href=""http://tel: 0898 588 118""><span style=""color:#ff0000;"">0898 588 118&nbsp;</span></a></strong><br>
                                    <strong>Văn phòng:</strong>&nbsp;Tầng 5 - 78&nbsp;Bạch Đằng, Hải Châu, Đà Nẵng.&nb");
            WriteLiteral(@"sp;<a data-fancybox-type=""iframe"" href=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3833.9206241208803!2d108.22254261393262!3d16.06960828888067!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31421831f429277d%3A0x126f9c6431fd0271!2zNzggQuG6oWNoIMSQ4bqxbmcsIEjhuqNpIENow6J1IDEsIFEuIEjhuqNpIENow6J1LCDEkMOgIE7hurVuZyA1NTAwMDAsIFZp4buHdCBOYW0!5e0!3m2!1svi!2sus!4v1557214227171"">map</a><br>
                                    Tel: <strong><a href=""http://tel: 0898 588 118""><span style=""color:#ff0000;"">0898 588 118&nbsp;</span></a></strong>
                                </div>
                            </div>
                        </div>
                    </div>


                    <div class=""item"">
                        <div class=""row cel-p10"">
                            <div class=""col-md-2 col-sm-12 col-xs-12"">
                                <div class=""m5-0"">
                                    <div class=""title-contact"">Hải Phòng</div>
                                </");
            WriteLiteral(@"div>
                            </div>
                            <div class=""col-md-10 col-sm-12 col-xs-12"">
                                <div class=""mb3"">
                                    <strong>Văn phòng:</strong> HD159 Hải Đăng, Vinhomes Marina, Võ Nguyên Giáp, Lê Chân. <a data-fancybox-type=""iframe"" href=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3728.482445586207!2d106.68363631402913!3d20.85259588609403!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x314a7a8db76f7b09%3A0x66bb469104eef7a9!2zMTk5IEPhuqd1IMSQ4bqldCwgTMOqIEzhu6NpLCBOZ8O0IFF1eeG7gW4sIEjhuqNpIFBow7JuZywgVmnhu4d0IE5hbQ!5e0!3m2!1svi!2s!4v1557214831652""> map</a><br>
                                    &nbsp;
                                </div>
                            </div>
                        </div>
                    </div>


                    <div class=""item"">
                        <div class=""row cel-p10"">
                            <div class=""col-md-2 col-sm-12 col-xs-12"">
         ");
            WriteLiteral(@"                       <div class=""m5-0"">
                                    <div class=""title-contact"">Quảng Ninh</div>
                                </div>
                            </div>
                            <div class=""col-md-10 col-sm-12 col-xs-12"">
                                <strong>Văn phòng:</strong> Số 419 Đường Nguyễn Văn Cừ, Phường Hồng Hải, TP Hạ Long, Tỉnh Quảng Ninh.
                            </div>
                        </div>
                    </div>


                    <div class=""item"">
                        <div class=""row cel-p10"">
                            <div class=""col-md-2 col-sm-12 col-xs-12"">
                                <div class=""m5-0"">
                                    <div class=""title-contact"">Thanh Hóa</div>
                                </div>
                            </div>
                            <div class=""col-md-10 col-sm-12 col-xs-12"">
                                <div class=""mb3""><strong>Văn phòng:</str");
            WriteLiteral(@"ong> 99 Nguyễn Hiệu, Đông Hương, TP.&nbsp;Thanh Hóa.&nbsp;<a class=""view_map fancybox"" data-fancybox-type=""iframe"" href=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3753.8687298361747!2d105.78459211438782!3d19.803162333859387!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x313657fea12664bb%3A0xe7c8a9ebe0169203!2zOTkgTmd1eeG7hW4gSGnhu4d1LCDEkMO0bmcgSMawbmcsIEhv4bqxbmcgSG_DoSwgVGhhbmggSG_DoSwgVmnhu4d0IE5hbQ!5e0!3m2!1svi!2s!4v1550043775085"">map</a></div>
                            </div>
                        </div>
                    </div>


                    <div class=""item"">
                        <div class=""row cel-p10"">
                            <div class=""col-md-2 col-sm-12 col-xs-12"">
                                <div class=""m5-0"">
                                    <div class=""title-contact"">Cần Thơ</div>
                                </div>
                            </div>
                            <div class=""col-md-10 col-sm-12 col-xs-12"">
           ");
            WriteLiteral(@"                     <div class=""mb3"">
                                    <strong>Văn phòng:</strong> 57 Ung Văn Khiêm, Ninh Kiều, Cần Thơ.&nbsp;<a data-fancybox-type=""iframe"" href=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3928.655668668099!2d105.78053861411124!3d10.045246275011392!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31a062a823350ee9%3A0xb83d137d523ea899!2zNTcgVW5nIFbEg24gS2hpw6ptLCBBbiBI4buZaSwgTmluaCBLaeG7gXUsIEPhuqduIFRoxqEsIFZp4buHdCBOYW0!5e0!3m2!1svi!2s!4v1549966098817"">map</a><br>
                                    Tel:&nbsp;(0292) 7304848
                                </div>
                            </div>
                        </div>
                    </div>


                    <div class=""item"">
                        <div class=""row cel-p10"">
                            <div class=""col-md-2 col-sm-12 col-xs-12"">
                                <div class=""m5-0"">
                                    <div class=""title-contact"">Huế</div>
         ");
            WriteLiteral(@"                       </div>
                            </div>
                            <div class=""col-md-10 col-sm-12 col-xs-12"">
                                <div class=""mb3""><strong>Văn phòng:</strong> 11 Nguyễn Công Trứ, Huế, Thừa Thiên Huế.&nbsp;<a class=""view_map fancybox"" data-fancybox-type=""iframe"" href=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3826.0693917735175!2d107.59370131434157!3d16.472023632893666!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3141a122f1167263%3A0xe861120ea2a93e59!2zMTEgTmd1eeG7hW4gQ8O0bmcgVHLhu6ksIFBow7ogSOG7mWksIFRow6BuaCBwaOG7kSBIdeG6vywgVGjhu6thIFRoacOqbiBIdeG6vywgVmnhu4d0IE5hbQ!5e0!3m2!1svi!2s!4v1550046948593"">map</a></div>
                            </div>
                        </div>
                    </div>


                    <div class=""item"">
                        <div class=""row cel-p10"">
                            <div class=""col-md-2 col-sm-12 col-xs-12"">
                                <div class=""m5-0"">
         ");
            WriteLiteral(@"                           <div class=""title-contact"">Phú Yên</div>
                                </div>
                            </div>
                            <div class=""col-md-10 col-sm-12 col-xs-12"">
                                <div class=""mb3""><strong>Văn phòng:</strong>&nbsp;247 Trường Chinh - Phường 7 - Tp.Tuy Hòa&nbsp;</div>
                            </div>
                        </div>
                    </div>


                    <div class=""item"">
                        <div class=""row cel-p10"">
                            <div class=""col-md-2 col-sm-12 col-xs-12"">
                                <div class=""m5-0"">
                                    <div class=""title-contact"">Dak Lak</div>
                                </div>
                            </div>
                            <div class=""col-md-10 col-sm-12 col-xs-12"">
                                <div class=""mb3""><strong>Văn phòng:</strong> 313 Phan Chu Trinh, Buôn Ma Thuột, Dak Lak&nbsp;<a ");
            WriteLiteral(@"class=""view_map fancybox"" data-fancybox-type=""iframe"" href=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3892.317752978748!2d108.04903501430186!3d12.692671724372689!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3171f7d9aa44383f%3A0x5467b8a2eb3a9279!2zMzEzIFBoYW4gQ2h1IFRyaW5oLCBUw6JuIEzhu6NpLCBUaMOgbmggcGjhu5EgQnXDtG4gTWEgVGh14buZdCwgxJDhuq9rIEzhuq9rLCBWaeG7h3QgTmFt!5e0!3m2!1svi!2s!4v1550047162243"">map</a></div>
                            </div>
                        </div>
                    </div>


                    <div class=""item"">
                        <div class=""row cel-p10"">
                            <div class=""col-md-2 col-sm-12 col-xs-12"">
                                <div class=""m5-0"">
                                    <div class=""title-contact"">Quy Nhơn</div>
                                </div>
                            </div>
                            <div class=""col-md-10 col-sm-12 col-xs-12"">
                                <strong>Văn phòng:");
            WriteLiteral(@"</strong> 43A Lê Thánh Tôn, Lê Lợi, Quy Nhơn. <a data-fancybox-type=""iframe"" href=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3875.0907817986968!2d109.2324785141433!3d13.773398700505144!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x316f6c87e2fe885f%3A0xc6648b256257cda8!2zNDNhIEzDqiBUaMOhbmggVMO0biwgUGjGsOG7nW5nIEzDqiBM4bujaSwgVGjDoG5oIHBo4buRIFF1aSBOaMahbiwgQsOsbmggxJDhu4tuaCwgVmnhu4d0IE5hbQ!5e0!3m2!1svi!2sus!4v1557216511658"">map</a>
                            </div>
                        </div>
                    </div>


                    <div class=""item"">
                        <div class=""row cel-p10"">
                            <div class=""col-md-2 col-sm-12 col-xs-12"">
                                <div class=""m5-0"">
                                    <div class=""title-contact"">Khánh Hòa</div>
                                </div>
                            </div>
                            <div class=""col-md-10 col-sm-12 col-xs-12"">
                        ");
            WriteLiteral(@"        <div class=""mb3""><strong>Văn phòng:</strong> 15 Ngô Đức Kế, Nha Trang, Khánh Hòa.&nbsp;<a class=""view_map fancybox"" data-fancybox-type=""iframe"" href=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3899.1183313145243!2d109.18815131429803!3d12.240266333815594!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3170677dcf0da6cf%3A0xe0aea764174b3b56!2zMTUgTmfDtCDEkOG7qWMgS-G6vywgVMOibiBM4bqtcCwgVGjDoG5oIHBo4buRIE5oYSBUcmFuZywgS2jDoW5oIEjDsmEgNjUwMDAwLCBWaeG7h3QgTmFt!5e0!3m2!1svi!2s!4v1550047351535"">map</a></div>

                                <div class=""mb3"">Tel:&nbsp;(0258) 7304848</div>
                            </div>
                        </div>
                    </div>


                    <div class=""item"">
                        <div class=""row cel-p10"">
                            <div class=""col-md-2 col-sm-12 col-xs-12"">
                                <div class=""m5-0"">
                                    <div class=""title-contact"">Lâm Đồng</div>
                 ");
            WriteLiteral(@"               </div>
                            </div>
                            <div class=""col-md-10 col-sm-12 col-xs-12"">
                                <div class=""mb3""><strong>Văn phòng:</strong> 56 Lê Thánh Tôn,&nbsp;Phường 6, Đà Lạt, Lâm Đồng.&nbsp;<a class=""view_map fancybox"" data-fancybox-type=""iframe"" href=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3906.5481849419507!2d108.37598021429396!3d11.72637954414792!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x317146d7b29111f5%3A0xfffd07c2685fd14f!2zTMOqIFRow6FuaCBUw7RuZywgdHQuIExpw6puIE5naMSpYSwgxJDhu6ljIFRy4buNbmcsIEzDom0gxJDhu5NuZywgVmnhu4d0IE5hbQ!5e0!3m2!1svi!2s!4v1550047248164"">map</a></div>

                                <div class=""mb3"">Tel:&nbsp;(0263) 7304848</div>
                            </div>
                        </div>
                    </div>


                    <div class=""item"">
                        <div class=""row cel-p10"">
                            <div class=""col-md-2 col-sm-12 col-xs-");
            WriteLiteral(@"12"">
                                <div class=""m5-0"">
                                    <div class=""title-contact"">Thái Lan</div>
                                </div>
                            </div>
                            <div class=""col-md-10 col-sm-12 col-xs-12"">
                                <div class=""mb3""><strong>Văn phòng:</strong> 52/3 Soi Na Ranong, Na Ranong Road, Khwaeng Klongtoey, Khet Klongtoey, Bangkok, 10110, 10110, Thái Lan. <a class=""fancybox"" data-fancybox-type=""iframe"" href=""loadmap.html""><i class=""fa fa-map-marker-alt""></i> map</a></div>
                                <div class=""row cel-p10"">
                                    <div class=""col-md-12 col-sm-12 col-xs-12"">
                                        <div class=""mb3"">Tel: +66 2 249 6544 </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>


                    <div cla");
            WriteLiteral(@"ss=""item"">
                        <div class=""row cel-p10"">
                            <div class=""col-md-2 col-sm-12 col-xs-12"">
                                <div class=""m5-0"">
                                    <div class=""title-contact"">Hàn Quốc</div>
                                </div>
                            </div>
                            <div class=""col-md-10 col-sm-12 col-xs-12"">
                                <div class=""mb3""><strong>Văn phòng:</strong> 2 Floor, 154-2 Donggyo - Dong, Mapo - Gu, Seoul, Korea <a class=""fancybox"" data-fancybox-type=""iframe"" href=""loadmap.html""><i class=""fa fa-map-marker-alt""></i> map</a></div>
                                <div class=""row cel-p10"">
                                    <div class=""col-md-12 col-sm-12 col-xs-12"">
                                        <div class=""mb3"">Tel:  +82 2 719 8867 </div>
                                    </div>
                                </div>
                            </div>
           ");
            WriteLiteral(@"             </div>
                    </div>


                    <div class=""item"">
                        <div class=""row cel-p10"">
                            <div class=""col-md-2 col-sm-12 col-xs-12"">
                                <div class=""m5-0"">
                                    <div class=""title-contact"">Singapore</div>
                                </div>
                            </div>
                            <div class=""col-md-10 col-sm-12 col-xs-12"">
                                <div class=""mb3""><strong>Văn phòng:</strong> 334, Kreta Ayer Rd, #03-09, Singapore <a class=""fancybox"" data-fancybox-type=""iframe"" href=""loadmap.html""><i class=""fa fa-map-marker-alt""></i> map</a></div>
                                <div class=""row cel-p10"">
                                    <div class=""col-md-12 col-sm-12 col-xs-12"">
                                        <div class=""mb3"">Tel: +65 6438 1822 </div>
                                    </div>
                        ");
            WriteLiteral(@"        </div>
                            </div>
                        </div>
                    </div>



                </div>


                <div class=""formContact"" style=""background-image: url(https://dulichvietnam.com.vn/tour/modules/contact/images/bg-contact.jpg);"">



                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a21bdbfa3574dcb2a10da4ef9b719d9af0c72ca27204", async() => {
                WriteLiteral(@"
                        <div class=""PSForm"">
                            <div>Nếu quý khách có thắc mắc hay đóng góp xin vui lòng điền vào Form dưới đây và gửi cho chúng tôi. Xin chân thành cảm ơn!</div>
                        </div>


                        <div class=""row-form"">
                            <div class=""rf_left"">
                                <label for=""name"">Họ tên <span>(*)</span></label>
                            </div>
                            <div class=""rf_right"">
                                <div class=""fa-user div_input"">
                                    <input type=""text"" name=""name"" id=""name"" class=""form-control required""");
                BeginWriteAttribute("value", " value=\"", 20974, "\"", 20982, 0);
                EndWriteAttribute();
                WriteLiteral(@" title=""Vui lòng nhập họ tên liên lạc"" aria-required=""true"">
                                </div>
                            </div>
                            <div class=""clear""></div>
                        </div>
                        <div class=""row-form"">
                            <div class=""rf_left"">
                                <label for=""email"">Email <span>(*)</span></label>
                            </div>
                            <div class=""rf_right"">
                                <div class=""fa-envelope div_input"">
                                    <input type=""text"" name=""email"" id=""email"" class=""form-control required""");
                BeginWriteAttribute("value", " value=\"", 21655, "\"", 21663, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-required=""true"">
                                </div>
                            </div>
                            <div class=""clear""></div>
                        </div>
                        <div class=""row-form"">
                            <div class=""rf_left"">
                                <label for=""phone"">Điện thoại <span>(*)</span></label>
                            </div>
                            <div class=""rf_right"">
                                <div class=""fa-phone div_input"">
                                    <input type=""text"" name=""phone"" id=""phone"" class=""form-control required""");
                BeginWriteAttribute("value", " value=\"", 22300, "\"", 22308, 0);
                EndWriteAttribute();
                WriteLiteral(@" title=""Vui lòng nhập điện thoại liên lạc"" aria-required=""true"">
                                </div>
                            </div>
                            <div class=""clear""></div>
                        </div>
                        <div class=""row-form"">
                            <div class=""rf_left"">
                                <label for=""f-content"">Nội dung liên lạc <span>(*)</span></label>
                            </div>
                            <div class=""rf_right"">
                                <div class=""fa-edit w_textarea div_input"">
                                    <textarea class=""form-control required"" id=""content"" name=""content"" rows=""3"" title=""Vui lòng nhập nội dung liên lạc"" aria-required=""true""></textarea>
                                </div>
                            </div>
                            <div class=""clear""></div>
                        </div>
                        <div class=""row-form"">
                            <div cl");
                WriteLiteral(@"ass=""rf_left"">
                                <label for=""security_code"">Mã bảo vệ <span>(*)</span></label>
                            </div>
                            <div class=""rf_right"">
                                <div class=""fa-shield-alt div_input"">
                                    <div class=""input-group"">
                                        <input type=""text"" name=""security_code"" id=""security_code"" class=""form-control required""");
                BeginWriteAttribute("title", " title=\"", 23794, "\"", 23802, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-required=""true"">
                                        <span class=""input-group-img""><img src=""https://dulichvietnam.com.vn/tour/includes/sec_image.php?code=DMjkzOQ4&amp;h=38"" alt=""Code""></span>
                                    </div>
                                </div>
                            </div>
                            <div class=""clear""></div>
                        </div>
                        <div class=""row-form c-button"">
                            <div class=""rf_left"">
                            </div>
                            <div class=""rf_right"">
                                <div class=""fl"">
                                    <button id=""do_submit"" name=""do_submit"" type=""submit"" class=""btn btnsubmit"" value=""Gửi""><span class=""fa-envelope"">Gửi</span></button>
                                </div>
                                <div class=""fr"">
                                    <button id=""btnReset"" name=""btnReset"" type=""reset"" class=""btn"" value=");
                WriteLiteral(@"""Làm lại""><span class=""fa-redo"">Làm lại</span></button>
                                </div>
                                <div class=""clear""></div>

                            </div>
                            <div class=""clear""></div>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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