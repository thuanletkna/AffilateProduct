#pragma checksum "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\Components\LeftSideBarProduct\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76b3b1114b6e71a83d7dc02c34336d382dcceb01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LeftSideBarProduct_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LeftSideBarProduct/Default.cshtml")]
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
#line 1 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\_ViewImports.cshtml"
using AffilateSource.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\_ViewImports.cshtml"
using AffilateSource.App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\Components\LeftSideBarProduct\Default.cshtml"
using AffilateSource.Shared.ViewModel.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\Components\LeftSideBarProduct\Default.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76b3b1114b6e71a83d7dc02c34336d382dcceb01", @"/Views/Shared/Components/LeftSideBarProduct/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdd3d95b9b2d6c26935d96b18407e8738c804623", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_LeftSideBarProduct_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LeftSideBarViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\Components\LeftSideBarProduct\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Side bar start -->\r\n<div class=\"col-lg-3 col-md-4 col-sm-6\">\r\n    <aside class=\"side-bar\">\r\n        <div class=\"widget\">\r\n            <h4 class=\"widget-title\">T??m ki???m</h4>\r\n            <div class=\"search-bx\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76b3b1114b6e71a83d7dc02c34336d382dcceb015259", async() => {
                WriteLiteral(@"
                    <div class=""input-group"">
                        <input name=""text"" type=""text"" class=""form-control"" placeholder=""Nh???p t??? kh??a..."">
                        <span class=""input-group-btn"">
                            <button type=""submit"" class=""site-button""><i class=""fa fa-search""></i></button>
                        </span>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"widget widget_categories\">\r\n            <h4 class=\"widget-title\">Danh m???c khuy???n m??i</h4>\r\n            <ul>\r\n");
#nullable restore
#line 28 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\Components\LeftSideBarProduct\Default.cshtml"
                 foreach (var item in Model.ListcategoryProductSidebar)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1146, "\"", 1177, 4);
            WriteAttributeValue("", 1153, "/", 1153, 1, true);
#nullable restore
#line 30 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\Components\LeftSideBarProduct\Default.cshtml"
WriteAttributeValue("", 1154, item.SeoAlias, 1154, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1168, "-", 1168, 1, true);
#nullable restore
#line 30 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\Components\LeftSideBarProduct\Default.cshtml"
WriteAttributeValue("", 1169, item.Id, 1169, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\Components\LeftSideBarProduct\Default.cshtml"
                                                      Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>(10)</li>\r\n");
#nullable restore
#line 31 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\Components\LeftSideBarProduct\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </ul>\r\n        </div>\r\n        <div class=\"widget recent-posts-entry\">\r\n            <h4 class=\"widget-title\">B??i ????ng ph??? bi???n</h4>\r\n            <div class=\"widget-post-bx\">\r\n");
#nullable restore
#line 38 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\Components\LeftSideBarProduct\Default.cshtml"
                 foreach (var item in Model.ListPostViewCount)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"widget-post clearfix\">\r\n                        <div class=\"dez-post-media\"> <img style=\"width:90px;height:72px\"");
            BeginWriteAttribute("src", " src=\"", 1664, "\"", 1719, 1);
#nullable restore
#line 41 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\Components\LeftSideBarProduct\Default.cshtml"
WriteAttributeValue("", 1670, Configuration["BackendApiUrl"]+ item.ImagePost, 1670, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1720, "\"", 1737, 1);
#nullable restore
#line 41 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\Components\LeftSideBarProduct\Default.cshtml"
WriteAttributeValue("", 1726, item.Title, 1726, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""200"" height=""143""> </div>
                        <div class=""dez-post-info"">
                            <div class=""dez-post-header"">
                                <h6 style=""overflow: hidden;text-overflow: ellipsis;-webkit-line-clamp: 2;display: -webkit-box;-webkit-box-orient: vertical;"" class=""post-title text-uppercase""><a");
            BeginWriteAttribute("href", " href=\"", 2079, "\"", 2118, 4);
            WriteAttributeValue("", 2086, "/details/", 2086, 9, true);
#nullable restore
#line 44 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\Components\LeftSideBarProduct\Default.cshtml"
WriteAttributeValue("", 2095, item.SeoAlias, 2095, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2109, "-", 2109, 1, true);
#nullable restore
#line 44 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\Components\LeftSideBarProduct\Default.cshtml"
WriteAttributeValue("", 2110, item.Id, 2110, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 44 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\Components\LeftSideBarProduct\Default.cshtml"
                                                                                                                                                                                                                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                            </div>\r\n                            <div class=\"dez-post-meta\">\r\n                                <ul>\r\n                                    <li class=\"post-author\">????ng b???i <a href=\"javascript:void(0);\">");
#nullable restore
#line 48 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\Components\LeftSideBarProduct\Default.cshtml"
                                                                                              Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 48 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\Components\LeftSideBarProduct\Default.cshtml"
                                                                                                              Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 53 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\Components\LeftSideBarProduct\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </div>\r\n        </div>\r\n        <div class=\"widget\">\r\n            <img src=\"/portalstyle/images/ads/add.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2705, "\"", 2711, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
        </div>
        
        <div class=""widget widget_gallery"">
            <h4 class=""widget-title"">Our services</h4>
            <ul>
                <li>
                    <a href=""javascript:void(0);"">
                        <div class=""dez-post-thum dez-img-overlay1 dez-img-effect zoom-slow"">
                            <img src=""/portalstyle/images/gallery/pic2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3106, "\"", 3112, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </a>
                </li>
                <li>
                    <a href=""javascript:void(0);"">
                        <div class=""dez-post-thum dez-img-overlay1 dez-img-effect zoom-slow"">
                            <img src=""/portalstyle/images/gallery/pic1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3441, "\"", 3447, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </a>
                </li>
                <li>
                    <a href=""javascript:void(0);"">
                        <div class=""dez-post-thum dez-img-overlay1 dez-img-effect zoom-slow"">
                            <img src=""/portalstyle/images/gallery/pic5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3776, "\"", 3782, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </a>
                </li>
                <li>
                    <a href=""javascript:void(0);"">
                        <div class=""dez-post-thum dez-img-overlay1 dez-img-effect zoom-slow"">
                            <img src=""/portalstyle/images/gallery/pic7.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4111, "\"", 4117, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </a>
                </li>
                <li>
                    <a href=""javascript:void(0);"">
                        <div class=""dez-post-thum dez-img-overlay1 dez-img-effect zoom-slow"">
                            <img src=""/portalstyle/images/gallery/pic8.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4446, "\"", 4452, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </a>
                </li>
                <li>
                    <a href=""javascript:void(0);"">
                        <div class=""dez-post-thum dez-img-overlay1 dez-img-effect zoom-slow"">
                            <img src=""/portalstyle/images/gallery/pic9.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4781, "\"", 4787, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </a>
                </li>
            </ul>
        </div>
        <div class=""widget widget_tag_cloud"">
            <h4 class=""widget-title"">Tags</h4>
            <div class=""tagcloud"">
                <a href=""javascript:void(0);"">Design</a>
                <a href=""javascript:void(0);"">User interface</a>
                <a href=""javascript:void(0);"">SEO</a>
                <a href=""javascript:void(0);"">WordPress</a>
                <a href=""javascript:void(0);"">Development</a>
                <a href=""javascript:void(0);"">Joomla</a>
                <a href=""javascript:void(0);"">Design</a>
                <a href=""javascript:void(0);"">User interface</a>
                <a href=""javascript:void(0);"">SEO</a>
                <a href=""javascript:void(0);"">WordPress</a>
                <a href=""javascript:void(0);"">Development</a>
                <a href=""javascript:void(0);"">Joomla</a>
                <a href=""javascript:void(0);"">Design");
            WriteLiteral("</a>\r\n            </div>\r\n        </div>\r\n    </aside>\r\n</div>\r\n<!-- Side bar END -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeftSideBarViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
