#pragma checksum "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "078f8962b3c63c0394c1d0b7f4d98d6a1e5ec822"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PyzaFinder.Pages.Pages_Details), @"mvc.1.0.razor-page", @"/Pages/Details.cshtml")]
namespace PyzaFinder.Pages
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
#line 1 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\_ViewImports.cshtml"
using PyzaFinder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
using Npgsql;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"078f8962b3c63c0394c1d0b7f4d98d6a1e5ec822", @"/Pages/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87f6dd555936641a2f2bde143b07bd45bae0cb57", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Details.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/fontello/css/fontello.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/oLayers/OpenLayers.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/oLayers/myInit.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/oLayers/myMarkersCloud.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/pyzunia.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 150px; width: 150px; border-radius: 90px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Map", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("stronka"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Gallery", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
   Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "078f8962b3c63c0394c1d0b7f4d98d6a1e5ec8227685", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "078f8962b3c63c0394c1d0b7f4d98d6a1e5ec8228863", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "078f8962b3c63c0394c1d0b7f4d98d6a1e5ec82210128", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "078f8962b3c63c0394c1d0b7f4d98d6a1e5ec82211228", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "078f8962b3c63c0394c1d0b7f4d98d6a1e5ec82212328", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"czesci\" style=\"width: 29%\">\r\n\r\n\r\n    <div class=\"text-center\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "078f8962b3c63c0394c1d0b7f4d98d6a1e5ec82213584", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <br />\r\n\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 4346, "\"", 4373, 1);
#nullable restore
#line 112 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
WriteAttributeValue("", 4353, Model.Link.PageLink, 4353, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"stronka\">Strona głowna restauracji </a>\r\n        <h5>INFORMACJE</h5> <br />\r\n        Telefon: ");
#nullable restore
#line 114 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
            Write(Model.DumplingRestaurant.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        Adres: ");
#nullable restore
#line 115 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
          Write(Model.DumplingRestaurant.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        Godziny otwarcia <br />\r\n        Poniedzialek: ");
#nullable restore
#line 117 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
                 Write(Model.Schedule.Monday);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        Wtorek: ");
#nullable restore
#line 118 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
           Write(Model.Schedule.Tuesday);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        Sroda: ");
#nullable restore
#line 119 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
          Write(Model.Schedule.Wednesday);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        Czwartek: ");
#nullable restore
#line 120 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
             Write(Model.Schedule.Thursday);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        Piatek: ");
#nullable restore
#line 121 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
           Write(Model.Schedule.Friday);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        Sobota: ");
#nullable restore
#line 122 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
           Write(Model.Schedule.Saturday);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        Niedziela: ");
#nullable restore
#line 123 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
              Write(Model.Schedule.Sunday);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 4958, "\"", 4989, 1);
#nullable restore
#line 124 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
WriteAttributeValue("", 4965, Model.Link.FacebookLink, 4965, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-facebook-squared\" style=\"display:inline-block; font-size: 32px;\"></i></ahref=\"");
#nullable restore
#line 124 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
                                                                                                                                   Write(Model.Link.PageLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 5118, "\"", 5150, 1);
#nullable restore
#line 125 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
WriteAttributeValue("", 5125, Model.Link.InstagramLink, 5125, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""icon-instagram"" style=""display:inline-block; font-size: 32px;""></i></a>
</div>

</div>

<div class=""czesci"" style=""width: 35%"">

    <div class=""text-center"">



        <div id=""basicMap""></div>
        <div id=""pyza"" style=""height:120px;"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "078f8962b3c63c0394c1d0b7f4d98d6a1e5ec82219169", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <script type=\"text/javascript\">\r\n            init();\r\n        </script>\r\n\r\n\r\n\r\n\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "078f8962b3c63c0394c1d0b7f4d98d6a1e5ec82220336", async() => {
                WriteLiteral("Wroc do mapy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"czesci\" style=\"width: 35%\">\r\n    <div class=\"text-center\">\r\n        <h3> ");
#nullable restore
#line 153 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
        Write(Model.DumplingRestaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n        <h5> O RESTAURACJI </h5> <br />\r\n        ");
#nullable restore
#line 155 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
   Write(Model.DumplingRestaurant.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "078f8962b3c63c0394c1d0b7f4d98d6a1e5ec82222267", async() => {
                WriteLiteral("Galeria");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 157 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
                                WriteLiteral(Model.DumplingRestaurant.IdRestaurant);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n");
#nullable restore
#line 162 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
   string path = SelectPath(Model.DumplingRestaurant.IdRestaurant);
    string grade = SelectGrade(Model.DumplingRestaurant.IdRestaurant).ToString();
    string coord_x = SelectCoordinates(Model.DumplingRestaurant.IdRestaurant, "coordinate_x").ToString();
    string coord_y = SelectCoordinates(Model.DumplingRestaurant.IdRestaurant, "coordinate_y").ToString(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\">\r\n        fDrawMarkers(\"");
#nullable restore
#line 167 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
                 Write(Model.DumplingRestaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 167 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
                                                   Write(coord_x);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 167 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
                                                               Write(coord_y);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 167 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
                                                                           Write(path);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 167 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
                                                                                    Write(grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n    fInitCenterMap(\"");
#nullable restore
#line 168 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
               Write(coord_y);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 168 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
                           Write(coord_x);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", 14);\r\n</script>");
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\Studia\6 semestr\Projekt zespołowy\PyzaFinder\PyzaFinder\Pages\Details.cshtml"
                  private static NpgsqlConnection GetConnection()
    {
        return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=12345;Database=pierogi");
    }
    private static string SelectSchedule(string day, int obcy)
    {
        using (NpgsqlConnection con = GetConnection())//nawiązanie połączenia z bazą
        {
            string val = "brak";
            string query = $"select {day} from public.schedule where id_restaurant={obcy}";
            con.Open();
            // Define a query returning a single row result set
            NpgsqlCommand command = new NpgsqlCommand(query, con);
            // Execute the query and obtain the value of the first column of the first row
            if (command.ExecuteScalar() != null)
            {
                string count = (string)command.ExecuteScalar();
                val = count;
            }
            con.Close();
            return val;
        }
    }
    private static string SelectPath(int obcy)
    {
        using (NpgsqlConnection con = GetConnection())//nawiązanie połączenia z bazą
        {
            string val = "brak";
            string query = $"select path from public.photo where id_restaurant={obcy} order by id_photo";
            con.Open();
            // Define a query returning a single row result set
            NpgsqlCommand command = new NpgsqlCommand(query, con);
            // Execute the query and obtain the value of the first column of the first row
            if (command.ExecuteScalar() != null)
            {
                string count = (string)command.ExecuteScalar();
                val = count;
            }
            con.Close();
            return val;
        }
    }
    private static string SelectCoordinates(int obcy, string coordinate)
    {
        using (NpgsqlConnection con = GetConnection())//nawiązanie połączenia z bazą
        {
            string val = "brak";
            string query = $"select {coordinate} from public.coordinates where id_restaurant={obcy}";
            con.Open();
            // Define a query returning a single row result set
            NpgsqlCommand command = new NpgsqlCommand(query, con);
            // Execute the query and obtain the value of the first column of the first row
            if (command.ExecuteScalar() != null)
            {
                string count = (string)command.ExecuteScalar().ToString();
                val = count;
            }
            con.Close();
            return val;
        }
    }
    private static int SelectGrade(int obcy)
    {
        using (NpgsqlConnection con = GetConnection())//nawiązanie połączenia z bazą
        {
            int val = 0;
            string query = $"select grade from public.opinion where id_restaurant={obcy}";
            con.Open();
            // Define a query returning a single row result set
            NpgsqlCommand command = new NpgsqlCommand(query, con);
            // Execute the query and obtain the value of the first column of the first row
            var id = 0;
            var reader = command.ExecuteReader();
            int petla = 0;
            while (reader.Read())
            {
                id = id + Int32.Parse(reader["grade"].ToString());
                petla++;
            }
            //if (command.ExecuteScalar() != null)
            //{
            //    Int32 count = (Int32)command.ExecuteScalar();
            //    val = count;
            //}
            val = id;
            if (petla != 0) val = id / petla;
            con.Close();
            return val;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PyzaFinder.Pages.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PyzaFinder.Pages.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PyzaFinder.Pages.DetailsModel>)PageContext?.ViewData;
        public PyzaFinder.Pages.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
