#pragma checksum "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27057516c4c833206304ebda7fd1671fff8c0d43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/_ViewImports.cshtml"
using FranchiseCalculatorUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/_ViewImports.cshtml"
using FranchiseCalculatorUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27057516c4c833206304ebda7fd1671fff8c0d43", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c5fc67e250b839103c9eeace91d3428b5710d50", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ParserLibrary.Databases.ParserControl>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Home/Index.cshtml"
  
    ViewData["App"] = "Franchise Calculator";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- Header -->\n<div id=\"hero-wrapper\">\n    <div id=\"header\" class=\"container\">\n\n        <!-- Logo -->\n\n        <h1 id=\"logo\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27057516c4c833206304ebda7fd1671fff8c0d435559", async() => {
                WriteLiteral("Franchise Analytics");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h1>

        <!-- Nav -->
        <nav id=""nav"">
            <ul navbar-nav me-auto mb-2 mb-md-0>
                <li class=""nav-item""><a href=""#map"">Map</a></li>
                <li class=""nav-item""><a href=""#dashboard"">Dashboard</a></li>
                <li class=""break nav-item""><a href=""https://github.com/lfost42/Franchise"">Code</a></li>
                <li class=""nav-item""><a href=""https://lfost42-portfolio.netlify.app/"">About Me</a></li>
            </ul>
        </nav>
    </div>

    <!-- Hero -->
    <section id=""hero"" class=""container"">
        <header>
            <h2>
                Explore the Coverage
                <br>
                Health of a Franchise
            </h2>
        </header>
        <p>Mapping &bull; Geolocation &bull; Parsing &bull; Statistics</p>
        <ul class=""actions"">
            <li><a href=""#promo"" class=""button"">Get Started!</a></li>
        </ul>
    </section>
</div>

<!-- Map Section -->
<div class=""wrapper"">
    <div class=""container"" id=""map"">

        <!-");
            WriteLiteral("- Content -->\n        <article id=\"content\">\n            <header>\n                <h2>Live Map</h2>\n            </header>\n            <a href=\"#map\" class=\"image featured\"><img src=\"images/pic06.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1542, "\"", 1548, 0);
            EndWriteAttribute();
            WriteLiteral(@" onclick=""map()"" /></a>
        </article>
        <ul class=""actions major gx-3 gy-2"">
            <li><a href=""#map"" class=""button"" onclick=""allLocations()"">All Locations</a></li>
            <li><a href=""#map"" class=""button"" onclick=""distance()"">Distance Results</a></li>
        </ul>
    </div>
</div>


<!-- Promo Section -->
<div id=""promo-wrapper"">
    <section id=""promo"" class=""row gx-4"">
        <ul>
            <h3>
            <li>Upload a new csv file to analyze  data</li>
            <li>View or modify current locations</li>
            <li>Determine which locations are farthest apart</li>
            </h3>
        </ul>
    </section>

    <ul class=""actions col-12 mt-4"">
        <li>
            <div class=""col"" title=""Upload a new csv file"">
                <button type=""submit"" class=""button"" href=""#promo"" onclick=""csv()"">
                    Data File
                </button>
            </div>
        </li>
        <li>
            <div class=""col"" title=""View or modify the current list of ");
            WriteLiteral("locations\">\n                <button type=\"submit\" class=\"button\" href=\"#promo\"\n                        onclick=\"crudLocations()\">\n                    Locations\n                </button>\n            </div>\n        </li>\n\n");
            WriteLiteral("    <li>\n        <asp:HiddenField ID=\"hfScrollPosition\" runat=\"server\" Value=\"0\" />\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27057516c4c833206304ebda7fd1671fff8c0d4310088", async() => {
                WriteLiteral("\n            <div id=\"dvScroll\" title=\"Determine which locations in the list are farthest apart.\">\n                <button type=\"submit\" class=\"button\">\n                    Distance\n                </button>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </li>\n    </ul>\n    <table id=\"div_position\"");
            BeginWriteAttribute("class", " class=\"", 3291, "\"", 3363, 1);
#nullable restore
#line 101 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Home/Index.cshtml"
WriteAttributeValue("", 3299, Model.solution.isPosted ? Html.Raw("show") : Html.Raw("hide"), 3299, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        <tr>\n            <td>");
#nullable restore
#line 103 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Home/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.solution.FileName));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</td>\n            <td>\n                ");
#nullable restore
#line 105 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Home/Index.cshtml"
           Write(Html.DisplayFor(model => model.solution.FileName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n\n        <tr>\n            <td class=\"head\">Location 1: </td>\n            <td>");
#nullable restore
#line 111 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Home/Index.cshtml"
           Write(Html.DisplayFor(model => model.solution.Location1.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n                (");
#nullable restore
#line 113 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Home/Index.cshtml"
            Write(Html.DisplayFor(model => model.solution.Location1.GeoPoint.Latitude));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 113 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Home/Index.cshtml"
                                                                                   Write(Html.DisplayFor(model => model.solution.Location1.GeoPoint.Longitude));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\n            </td>\n        </tr>\n\n        <tr>\n            <td class=\"head\">Location 2: </td>\n            <td>");
#nullable restore
#line 119 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Home/Index.cshtml"
           Write(Html.DisplayFor(model => model.solution.Location2.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n                (");
#nullable restore
#line 121 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Home/Index.cshtml"
            Write(Html.DisplayFor(model => model.solution.Location2.GeoPoint.Latitude));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 121 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Home/Index.cshtml"
                                                                                   Write(Html.DisplayFor(model => model.solution.Location2.GeoPoint.Longitude));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\n            </td>\n        </tr>\n\n        <tr>\n            <td class=\"head\">");
#nullable restore
#line 126 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Home/Index.cshtml"
                        Write(Html.DisplayNameFor(model => model.solution.Distance));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</td>\n            <td>\n                ");
#nullable restore
#line 128 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Home/Index.cshtml"
           Write(Html.DisplayFor(model => model.solution.Distance));

#line default
#line hidden
#nullable disable
            WriteLiteral(" miles\n            </td>\n        </tr>\n    </table>\n");
            WriteLiteral(@"</div>


<!-- Dashboard Section -->
<div class=""wrapper"">
    <section class=""container"" id=""dashboard"">
        <header class=""major"">
            <h2>Statistics</h2>
        </header>

        <div class=""row"">
            <section class=""col-4 col-12-narrower feature"">
                <div class=""image-wrapper"">
                    <img src=""images/pic03.jpg"" alt=""whisker chart placeholder"" onclick=""dashboard()"" />
                </div>
                <p>Whisker Chart</p>
            </section>
            <section class=""col-4 col-12-narrower feature"">
                <div class=""image-wrapper"">
                    <img src=""images/pic04.jpg"" alt=""bubble graph placeholder"" onclick=""dashboard()"" />
                </div>
                <p>Bubble Graph</p>
            </section>
            <section class=""col-4 col-12-narrower feature"">
                <div class=""image-wrapper"">
                    <img src=""images/pic05.jpg"" alt=""heatmap placeholder"" onclick=""dashboard()"" />
                </div>
   ");
            WriteLiteral(@"             <p>Heatmap</p>
            </section>
        </div>
        <ul class=""actions major"">
            <li><a href=""#dashboard"" class=""button"" onclick=""exportDashboard()"">Export Dashboard</a></li>
        </ul>
    </section>
</div>


<script>function csv() {
        alert(""Allows the user to uplaod a csv file with geocoordinate data for analysis"");
    }
    function crudLocations() {
        dvScroll
        alert(""Allows the user to perform CRUD operations on locations in the current dataset"");
    }
    function map() {
        alert(""Consumes a mapping API to display geocoordinate locations"");
    }
    function allLocations() {
        alert(""Shows all locations in the working dataset on the map"");
    }
    function distance() {
        alert(""Shows the two locations that are farthest apart on the map"");
    }
    function dashboard() {
        alert(""Chart to display live statistics as the datastet is modified"");
    }
    function exportDashboard() {
        alert(""User may export the dashb");
            WriteLiteral(@"oard as a png."");
    }</script>


<script type=""text/javascript"">window.onload = function () {
        var h = document.getElementById(""<%=hfScrollPosition.ClientID%>"");
        document.getElementById(""<%=scrollArea.ClientID%>"").scrollTop = h.value;
    }
    function SetDivPosition() {
        var intY = document.getElementById(""<%=scrollArea.ClientID%>"").scrollTop;
        var h = document.getElementById(""<%=hfScrollPosition.ClientID%>"");
        h.value = intY;
    }

    function afterpostback() {

        var h = document.getElementById(""<%=hfScrollPosition.ClientID%>"");
        document.getElementById(""<%=scrollArea.ClientID%>"").scrollTop = h.value;

    }</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ParserLibrary.Databases.ParserControl> Html { get; private set; }
    }
}
#pragma warning restore 1591
