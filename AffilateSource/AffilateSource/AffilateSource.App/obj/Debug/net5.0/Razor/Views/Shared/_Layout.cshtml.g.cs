#pragma checksum "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55a661f14b933bda3d2e0896ef25911f93440d5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55a661f14b933bda3d2e0896ef25911f93440d5a", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdd3d95b9b2d6c26935d96b18407e8738c804623", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55a661f14b933bda3d2e0896ef25911f93440d5a3775", async() => {
                WriteLiteral("\r\n\t<meta charset=\"utf-8\">\r\n\t<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n\t<meta name=\"keywords\"");
                BeginWriteAttribute("content", " content=\"", 146, "\"", 156, 0);
                EndWriteAttribute();
                WriteLiteral("/>\r\n\t<meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 181, "\"", 191, 0);
                EndWriteAttribute();
                WriteLiteral("/>\r\n\t<meta name=\"robots\"");
                BeginWriteAttribute("content", " content=\"", 216, "\"", 226, 0);
                EndWriteAttribute();
                WriteLiteral("/>\r\n\t<meta name=\"description\" content=\"V?????n Hoa L??\"/>\r\n\t<meta property=\"og:title\" content=\"V?????n Hoa L??\"/>\r\n\t<meta property=\"og:description\" content=\"V?????n Hoa L??\"/>\r\n");
                WriteLiteral(@"	<meta name=""format-detection"" content=""telephone=no"">
	
	<!-- FAVICONS ICON -->
	<link rel=""icon"" href=""/portalstyle/images/favicon.ico"" type=""image/x-icon"" />
	<link rel=""shortcut icon"" type=""image/x-icon"" href=""/portalstyle/images/favicon.png"" />
	
	<!-- PAGE TITLE HERE -->
	<title> V?????n Hoa L??</title>
	
	<!-- MOBILE SPECIFIC -->
	<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
	
	<!--[if lt IE 9]>
	<script src=""js/html5shiv.min.js""></script>
	<script src=""js/respond.min.js""></script>
	<![endif]-->
	
	<!-- STYLESHEETS -->
	<link rel=""stylesheet"" type=""text/css"" href=""/portalstyle/css/plugins.css"">
	<link rel=""stylesheet"" type=""text/css"" href=""/portalstyle/css/style.css"">
	<link class=""skin""  rel=""stylesheet"" type=""text/css"" href=""/portalstyle/css/skin/skin-1.css"">
	<link  rel=""stylesheet"" type=""text/css"" href=""/portalstyle/css/templete.css"">

	<!-- REVOLUTION SLIDER CSS -->
	<link rel=""stylesheet"" type=""text/css"" href=""/revolution/css/settings.css"">
	<link rel=");
                WriteLiteral("\"stylesheet\" type=\"text/css\" href=\"/revolution/css/layers.css\">\r\n\t<link rel=\"stylesheet\" type=\"text/css\" href=\"/revolution/css/navigation.css\">\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55a661f14b933bda3d2e0896ef25911f93440d5a6890", async() => {
                WriteLiteral("\r\n\t<div id=\"loading-area\"></div><div class=\"page-wraper\">\r\n\t\t<!-- header -->\r\n\t\t");
#nullable restore
#line 45 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\_Layout.cshtml"
   Write(await Component.InvokeAsync("Navigation"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t<!-- header END -->\r\n\t\t<!-- Content -->\r\n\t\t");
#nullable restore
#line 48 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t\t<!-- Content END-->\r\n\t\t<!-- Footer -->\r\n\t\t");
#nullable restore
#line 52 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\_Layout.cshtml"
   Write(await Component.InvokeAsync("Footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
		<!-- Footer END-->
		<!-- scroll top button -->
		<button class=""scroltop fa fa-chevron-up""></button>
		<!-- <div class=""contant-no-area"">
			<div class=""contact-number"">
				<h5>Have A Questions</h5>
				<h6>0800 987654320</h6>
			</div>
			<div class=""contact-pic"">
				<img src=""/portalstyle/images/testimonials/pic4.jpg"" alt=""""/>
			</div>
			<div class=""contact-name"">
				<span>Jone Cane</span>
			</div>
		</div> -->

	</div>
	<!-- JavaScript  files ========================================= -->
	<script src=""/portalstyle/js/jquery.min.js""></script><!-- JQUERY.MIN JS -->
	<script src=""/portalstyle/plugins/bootstrap/js/popper.min.js""></script><!-- BOOTSTRAP.MIN JS -->
	<script src=""/portalstyle/plugins/bootstrap/js/bootstrap.bundle.min.js""></script><!-- BOOTSTRAP.MIN JS -->
	<script src=""/portalstyle/plugins/bootstrap-select/bootstrap-select.min.js""></script><!-- FORM JS -->
	<script src=""/portalstyle/plugins/bootstrap-touchspin/jquery.bootstrap-touchspin.js""></script><!-- FORM JS -");
                WriteLiteral(@"->
	<script src=""/portalstyle/plugins/magnific-popup/magnific-popup.js""></script><!-- MAGNIFIC POPUP JS -->
	<script src=""/portalstyle/plugins/counter/waypoints-min.js""></script><!-- WAYPOINTS JS -->
	<script src=""/portalstyle/plugins/counter/counterup.min.js""></script><!-- COUNTERUP JS -->
	<script src=""/portalstyle/plugins/imagesloaded/imagesloaded.js""></script><!-- /portalstyle/imagesLOADED -->
	<script src=""/portalstyle/plugins/masonry/masonry-3.1.4.js""></script><!-- MASONRY -->
	<script src=""/portalstyle/plugins/masonry/masonry.filter.js""></script><!-- MASONRY -->
	<script src=""/portalstyle/plugins/owl-carousel/owl.carousel.js""></script><!-- OWL SLIDER -->
	<script src=""/portalstyle/js/dz.ajax.js""></script><!-- CONTACT JS  -->
	<script src=""/portalstyle/js/dz.carousel.js""></script><!-- CUSTOM FUCTIONS  -->
	<script src=""/portalstyle/js/custom.js""></script><!-- CUSTOM FUCTIONS  -->
	<!-- revolution JS FILES -->
	<script src=""/revolution/js/jquery.themepunch.tools.min.js""></script>
	<script sr");
                WriteLiteral(@"c=""/revolution/js/jquery.themepunch.revolution.min.js""></script>
	<!-- Slider revolution 5.0 Extensions  (Load Extensions only on Local File Systems !  The following part can be removed on Server for On Demand Loading) -->
	<script src=""/revolution/js/extensions/revolution.extension.actions.min.js""></script>
	<script src=""/revolution/js/extensions/revolution.extension.carousel.min.js""></script>
	<script src=""/revolution/js/extensions/revolution.extension.kenburn.min.js""></script>
	<script src=""/revolution/js/extensions/revolution.extension.layeranimation.min.js""></script>
	<script src=""/revolution/js/extensions/revolution.extension.navigation.min.js""></script>
	<script src=""/revolution/js/extensions/revolution.extension.parallax.min.js""></script>
	<script src=""/revolution/js/extensions/revolution.extension.slideanims.min.js""></script>
	<script src=""/revolution/js/extensions/revolution.extension.video.min.js""></script>
	<script src=""/portalstyle/js/rev.slider.js""></script>
	<script>
		jQuery(docume");
                WriteLiteral(@"nt).ready(function () {
			'use strict';
			dz_rev_slider_4();

		});
		/*ready*/
	</script>
	<script src=""//cdnjs.cloudflare.com/ajax/libs/wow/0.1.12/wow.min.js""></script>
<script>new WOW().init();</script>
<script>
GardenZone.handleMasonryFilter();
</script>
	");
#nullable restore
#line 112 "D:\AffilateSource_Github\AffilateProduct\AffilateSource\AffilateSource\AffilateSource.App\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
