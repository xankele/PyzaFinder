#pragma checksum "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e84d8085a43f65e536a1989f1695fc84f219cac3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PyzaFinder.Pages.Pages_Map), @"mvc.1.0.razor-page", @"/Pages/Map.cshtml")]
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
#line 1 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\_ViewImports.cshtml"
using PyzaFinder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
using Npgsql;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e84d8085a43f65e536a1989f1695fc84f219cac3", @"/Pages/Map.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87f6dd555936641a2f2bde143b07bd45bae0cb57", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Map : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Map.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/fontello/css/fontello.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/oLayers/OpenLayers.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/oLayers/myInit.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/oLayers/myMarkersCloud.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/pyzunia.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position: absolute; bottom: 0; right: 0; width: 12%; height: auto; margin: 60px; z-index:1000;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onfocus", new global::Microsoft.AspNetCore.Html.HtmlString("if (this.value == \'Search\') {this.value = \'\';}"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("        height: 35px;\n        border-radius: 46px;\n        box-shadow: 22px 12px 21px 0px rgba(0,0,0,0.15);\n        background-color: #ffffff;\n        color: #000000;\n        outline: 1px;\n        border: 1px;\n        border-radius: 46px;\n"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/star.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: auto; width: 18%; float: left;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/starL.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Opinion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
   Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e84d8085a43f65e536a1989f1695fc84f219cac310095", async() => {
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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e84d8085a43f65e536a1989f1695fc84f219cac311272", async() => {
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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e84d8085a43f65e536a1989f1695fc84f219cac312536", async() => {
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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e84d8085a43f65e536a1989f1695fc84f219cac313634", async() => {
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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e84d8085a43f65e536a1989f1695fc84f219cac314732", async() => {
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
                WriteLiteral("\n");
            }
            );
            WriteLiteral("\n<div id=\"basicMap\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e84d8085a43f65e536a1989f1695fc84f219cac315907", async() => {
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
            WriteLiteral(@"</div>

<div id=""search""></div>

<div id=""search2"">
    <div style="" padding-top: 15px; padding-bottom:15px;"">
        <div style=""background-color: white;
    width: 260px;
    height: 35px;
    display: block;
    margin-left: 20px;
    color: grey;
    text-align: left;
    font-size: 23px;
    margin-bottom: 10px;
    border-radius: 46px;
    box-shadow: 22px 12px 21px 0px rgba(0,0,0,0.15);"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e84d8085a43f65e536a1989f1695fc84f219cac317439", async() => {
                WriteLiteral("\n                <i class=\"icon-search\"></i>\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e84d8085a43f65e536a1989f1695fc84f219cac317759", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#nullable restore
#line 142 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchTerm);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
    <h2 style=""font-size:20px"">LIST OF RESTAURANTS</h2>
    <ul id=""restaurants"">
        <div style=""width: 100%; height: 560px; overflow-y: auto;"">
            <script type=""text/javascript"">
                init();
            </script>
");
#nullable restore
#line 161 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
             foreach (var item in Model.DumplingRestaurants)
            {
                string path = SelectPath(item.IdRestaurant);
                string grade = SelectGrade(item.IdRestaurant).ToString();
                string coord_x = SelectCoordinates(item.IdRestaurant, "coordinate_x").ToString();
                string coord_y = SelectCoordinates(item.IdRestaurant, "coordinate_y").ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("                <script type=\"text/javascript\">                       \n                fDrawMarkers(\"");
#nullable restore
#line 168 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 168 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
                                       Write(coord_x);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 168 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
                                                   Write(coord_y);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 168 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
                                                               Write(path);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 168 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
                                                                        Write(grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");                              \n                </script>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e84d8085a43f65e536a1989f1695fc84f219cac322911", async() => {
                WriteLiteral("\n                    <li>\n                        <div class=\"jeden\">\n                            <div class=\"napis\">\n                                Name: ");
#nullable restore
#line 174 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
                                 Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br>\n                                Today:\n");
#nullable restore
#line 176 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
                                  string day = DateTime.Now.DayOfWeek.ToString(); 

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
#nullable restore
#line 177 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
                           Write(SelectSchedule(day, item.IdRestaurant));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n                                <br>\n                                ");
#nullable restore
#line 179 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
                           Write(Html.DisplayFor(m => item.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </div>\n                            <a href=\"polecam.html\"><img");
                BeginWriteAttribute("src", " src=\"", 7368, "\"", 7392, 1);
#nullable restore
#line 181 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
WriteAttributeValue("", 7374, Url.Content(path), 7374, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"height: 98%; border-radius: 25px; padding-right: 2%; width: auto; float: right;\"></a>\n                        </div>\n                        <div class=\"dwa\">\n                            <div class=\"gwiazdki\">\n");
#nullable restore
#line 185 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
                                   int ocena = 0;
                                    ocena = SelectGrade(item.IdRestaurant);
                                    if (ocena == 0)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <p>brak ocen</p> ");
#nullable restore
#line 189 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
                                                         }
                                    while (ocena > 0)
                                    {
                                        if (ocena > 1)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e84d8085a43f65e536a1989f1695fc84f219cac326148", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" ");
#nullable restore
#line 194 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
                                                                                                                      ocena -= 2;
                                        }
                                        if (ocena <= 1 && ocena > 0)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e84d8085a43f65e536a1989f1695fc84f219cac327834", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" ");
#nullable restore
#line 198 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
                                                                                                                       ocena--;
                                        }
                                    } 

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\n                            <div class=\"opinie\">\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e84d8085a43f65e536a1989f1695fc84f219cac329523", async() => {
                    WriteLiteral("Show opinions");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_15.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 203 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
                                                        WriteLiteral(item.IdRestaurant);

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
                WriteLiteral("\n                            </div>\n                            <div class=\"odleglosc\">\n                                Distance: 5m\n                            </div>\n                        </div>\n                    </li>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_16.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 170 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
                                        WriteLiteral(item.IdRestaurant);

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
            WriteLiteral("\n");
#nullable restore
#line 211 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n    </ul>\n\n</div>\n<div>\n\n</div>\n<div id=\"pyza\">\n\n</div>\n\n\n\n\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Anna\Desktop\PyzaFinder-Opinia\PyzaFinder\Pages\Map.cshtml"
                  private static NpgsqlConnection GetConnection()
    {
        return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=Szczeniak101;Database=pierogi");
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
    //private static long CountRowsGrade(int obcy)
    //{
    //    using (NpgsqlConnection con = GetConnection())//nawiązanie połączenia z bazą
    //    {
    //        long val = 0;
    //        string query = $"select count(*) from public.opinion where id_restaurant={obcy}";
    //        con.Open();
    //        // Define a query returning a single row result set
    //        NpgsqlCommand command = new NpgsqlCommand(query, con);
    //        // Execute the query and obtain the value of the first column of the first row
    //        if (command.ExecuteScalar() != null)
    //        {
    //            Int64 count = (Int64)command.ExecuteScalar();
    //            val = count;
    //        }
    //        con.Close();
    //        return val;
    //    }
    //}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PyzaFinder.Pages.MapModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PyzaFinder.Pages.MapModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PyzaFinder.Pages.MapModel>)PageContext?.ViewData;
        public PyzaFinder.Pages.MapModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
