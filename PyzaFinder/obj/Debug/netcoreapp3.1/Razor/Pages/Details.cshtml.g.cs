#pragma checksum "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e2e71a59bb522747a7454753d3106bab30898d7"
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
#line 1 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\_ViewImports.cshtml"
using PyzaFinder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
using Npgsql;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e2e71a59bb522747a7454753d3106bab30898d7", @"/Pages/Details.cshtml")]
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
#line 3 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
   Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e2e71a59bb522747a7454753d3106bab30898d77743", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e2e71a59bb522747a7454753d3106bab30898d78919", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e2e71a59bb522747a7454753d3106bab30898d710182", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e2e71a59bb522747a7454753d3106bab30898d711280", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e2e71a59bb522747a7454753d3106bab30898d712378", async() => {
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
            WriteLiteral("\n<div class=\"czesci\" style=\"width: 29%\">\n\n\n    <div class=\"text-center\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e2e71a59bb522747a7454753d3106bab30898d713622", async() => {
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
            WriteLiteral("\n        <br />\n\n        <a");
            BeginWriteAttribute("href", " href=\"", 4242, "\"", 4269, 1);
#nullable restore
#line 112 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
WriteAttributeValue("", 4249, Model.Link.PageLink, 4249, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"stronka\">Restaurant\'s main page </a>\n        <h5>INFORMATION</h5> <br />\n        Phone: ");
#nullable restore
#line 114 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
          Write(Model.DumplingRestaurant.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n        Adress: ");
#nullable restore
#line 115 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
           Write(Model.DumplingRestaurant.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n        Opening hours <br />\n        Monday: ");
#nullable restore
#line 117 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
           Write(Model.Schedule.Monday);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n        Tuesday: ");
#nullable restore
#line 118 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
            Write(Model.Schedule.Tuesday);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n        Wednesday: ");
#nullable restore
#line 119 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
              Write(Model.Schedule.Wednesday);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n        Thursday: ");
#nullable restore
#line 120 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
             Write(Model.Schedule.Thursday);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n        Friday: ");
#nullable restore
#line 121 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
           Write(Model.Schedule.Friday);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n        Saturday: ");
#nullable restore
#line 122 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
             Write(Model.Schedule.Saturday);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n        Sunday: ");
#nullable restore
#line 123 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
           Write(Model.Schedule.Sunday);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
        <i class=""icon-facebook-squared"" style=""display:inline-block;""></i>
        <i class=""icon-instagram"" style=""display:inline-block;""></i>
    </div>

</div>

<div class=""czesci"" style=""width: 35%"">

    <div class=""text-center"">



        <div id=""basicMap""></div>
        <div id=""pyza"" style=""height:120px;"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3e2e71a59bb522747a7454753d3106bab30898d718138", async() => {
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
            WriteLiteral("\n        </div>\n        <script type=\"text/javascript\">\n            init();\n        </script>\n\n\n\n\n\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e2e71a59bb522747a7454753d3106bab30898d719289", async() => {
                WriteLiteral("Back to map");
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
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"czesci\" style=\"width: 35%\">\n        <div class=\"text-center\">\n            <h3> ");
#nullable restore
#line 153 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
            Write(Model.DumplingRestaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\n            <h5> ABOUT THE RESTAURANT </h5> <br />\n            ");
#nullable restore
#line 155 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
       Write(Model.DumplingRestaurant.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e2e71a59bb522747a7454753d3106bab30898d721278", async() => {
                WriteLiteral("Restaurant\'s gallery");
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
#line 157 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
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
            WriteLiteral("\n        </div>\n\n    </div>\n\n");
#nullable restore
#line 162 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
       string path = SelectPath(Model.DumplingRestaurant.IdRestaurant);
                    string grade = SelectGrade(Model.DumplingRestaurant.IdRestaurant).ToString();
                    string coord_x = SelectCoordinates(Model.DumplingRestaurant.IdRestaurant, "coordinate_x").ToString();
                    string coord_y = SelectCoordinates(Model.DumplingRestaurant.IdRestaurant, "coordinate_y").ToString(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\">\n        fDrawMarkers(\"");
#nullable restore
#line 167 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
                 Write(Model.DumplingRestaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 167 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
                                                   Write(coord_x);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 167 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
                                                               Write(coord_y);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 167 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
                                                                           Write(path);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 167 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
                                                                                    Write(grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\n    fInitCenterMap(\"");
#nullable restore
#line 168 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
               Write(coord_y);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 168 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
                           Write(coord_x);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", 14);\n</script>\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Anna\Desktop\PyzaFinder-ankelka (2)\PyzaFinder-ankelka\PyzaFinder\Pages\Details.cshtml"
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
