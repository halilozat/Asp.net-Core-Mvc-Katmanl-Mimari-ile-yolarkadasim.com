#pragma checksum "C:\Users\halilozat\source\repos\YolArkadasim\YolArkadasim.Mvc\Views\Skill\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da241af0cb671fb82c2c0ed3e5d79a68831536a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_Index), @"mvc.1.0.view", @"/Views/Skill/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da241af0cb671fb82c2c0ed3e5d79a68831536a7", @"/Views/Skill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main-layout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da241af0cb671fb82c2c0ed3e5d79a68831536a73245", async() => {
                WriteLiteral(@"
    <!-- basic -->
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <!-- mobile metas -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""viewport"" content=""initial-scale=1, maximum-scale=1"">
    <!-- site metas -->
    <title>mical</title>
    <meta name=""keywords""");
                BeginWriteAttribute("content", " content=\"", 398, "\"", 408, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 440, "\"", 450, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 477, "\"", 487, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <!-- bootstrap css -->\r\n    ");
#nullable restore
#line 16 "C:\Users\halilozat\source\repos\YolArkadasim\YolArkadasim.Mvc\Views\Skill\Index.cshtml"
Write(await Html.PartialAsync("_LayoutCssPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
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
            WriteLiteral("\r\n<!-- body -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da241af0cb671fb82c2c0ed3e5d79a68831536a75435", async() => {
                WriteLiteral("\r\n    <!-- loader  -->\r\n    <div class=\"loader_bg\">\r\n        <div class=\"loader\"><img src=\"images/loading.gif\" alt=\"#\" /></div>\r\n    </div>\r\n    <!-- end loader -->\r\n    <!-- header -->\r\n    <header>\r\n        <!-- header inner -->\r\n        ");
#nullable restore
#line 29 "C:\Users\halilozat\source\repos\YolArkadasim\YolArkadasim.Mvc\Views\Skill\Index.cshtml"
   Write(await Component.InvokeAsync("NavbarMenu"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    </header>
    <!-- end header inner -->
    <!-- end header -->
    <!-- wedo  section -->
    <div class=""wedo "">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""titlepage"">
                        <h2>Ne Yapıyoruz</h2>
                        <p>Uzun yolları kısaltan, cebinizi yakmayan yolculuklar sunuyoruz.</p>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-10 offset-md-1"">
                    <div class=""row"">
                        <div class=""col-md-6 margin_bottom"">
                            <div class=""work"">
                                <figure><img src=""images/img1.png"" alt=""#"" /></figure>
                            </div>
                            <div class=""work_text"">
                                <h3>Arkadaş Bul<br><span class=""blu"">Yola Çık</span></h3>
                            </");
                WriteLiteral(@"div>
                        </div>
                        <div class=""col-md-6 margin_bottom"">
                            <div class=""work"">
                                <figure><img src=""images/img2.png"" alt=""#"" /></figure>
                            </div>
                            <div class=""work_text"">
                                <h3>Arkadaş Bul<br><span class=""blu"">Yola Çık</span></h3>
                            </div>
                        </div>
                        <div class=""col-md-6 margin_bottom"">
                            <div class=""work"">
                                <figure><img src=""images/img3.png"" alt=""#"" /></figure>
                            </div>
                            <div class=""work_text"">
                                <h3>Arkadaş Bul<br><span class=""blu"">Yola Çık</span></h3>
                            </div>
                        </div>
                        <div class=""col-md-6 margin_bottom"">
                            <div");
                WriteLiteral(@" class=""work"">
                                <figure><img src=""images/img4.png"" alt=""#"" /></figure>
                            </div>
                            <div class=""work_text"">
                                <h3>Arkadaş Bul<br><span class=""blu"">Yola Çık</span></h3>
                            </div>
                        </div>
                    </div>
                    <a class=""read_more"" href=""#"">Daha Fazlası..</a>
                </div>
            </div>
        </div>
    </div>
    <!-- end wedo  section -->
    <!--  footer -->
");
#nullable restore
#line 88 "C:\Users\halilozat\source\repos\YolArkadasim\YolArkadasim.Mvc\Views\Skill\Index.cshtml"
Write(await Html.PartialAsync("_LayoutFooterPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <!-- end footer -->\r\n    <!-- Javascript files-->\r\n");
#nullable restore
#line 92 "C:\Users\halilozat\source\repos\YolArkadasim\YolArkadasim.Mvc\Views\Skill\Index.cshtml"
Write(await Html.PartialAsync("_LayoutJsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
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
