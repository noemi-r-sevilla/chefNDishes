#pragma checksum "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/chefNDishes/chefNDishes/Views/Home/ShowAllDishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef0ca377ca91e765ea5eca168dd894539172296c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(chefNDishes.Home.Views_Home_ShowAllDishes), @"mvc.1.0.view", @"/Views/Home/ShowAllDishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowAllDishes.cshtml", typeof(chefNDishes.Home.Views_Home_ShowAllDishes))]
namespace chefNDishes.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/chefNDishes/chefNDishes/Views/Home/ShowAllDishes.cshtml"
using chefNDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef0ca377ca91e765ea5eca168dd894539172296c", @"/Views/Home/ShowAllDishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07f40f1fe4e606c53cb486291aaa3fbd70e97d44", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowAllDishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(30, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(52, 9, true);
            WriteLiteral("    \n    ");
            EndContext();
            BeginContext(61, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ef0ca377ca91e765ea5eca168dd894539172296c4164", async() => {
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
            EndContext();
            BeginContext(107, 217, true);
            WriteLiteral("\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\" integrity=\"sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T\" crossorigin=\"anonymous\">\n");
            EndContext();
            BeginContext(324, 1238, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef0ca377ca91e765ea5eca168dd894539172296c5624", async() => {
                BeginContext(330, 837, true);
                WriteLiteral(@"
<nav class=""navbar navbar-expand-lg navbar-light bg-dark"">
    <h1 class=""white mr-auto text col"">
        <a class=""btn btn-primary active"" href=""/"" role=""button"">Chefs</a>
        <a class=""btn btn-primary"" href=""/dishes"" role=""button"">Dishes</a>
    </h1>
</nav>

<div class=""container moveit"">
    <div class=""container box"">
        <div class=""row"">
            <p class=""col"">Check out some recent dishes!</p>
            <a href=""dish/new"" class=""btn btn-info"">Add a Dish</a>
        </div>
        <table class=""table table-dark""
            <thead>
                <tr>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Chef</th>
                    <th scope=""col"">Tastiness</th>
                    <th scope=""col"">Calories</th>
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 30 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/chefNDishes/chefNDishes/Views/Home/ShowAllDishes.cshtml"
                 foreach (var d in Model)
                {

#line default
#line hidden
                BeginContext(1227, 53, true);
                WriteLiteral("                    <tr>\n                        <td>");
                EndContext();
                BeginContext(1281, 6, false);
#line 33 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/chefNDishes/chefNDishes/Views/Home/ShowAllDishes.cshtml"
                       Write(d.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1287, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(1322, 21, false);
#line 34 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/chefNDishes/chefNDishes/Views/Home/ShowAllDishes.cshtml"
                       Write(d.CreatedBy.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1343, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1345, 20, false);
#line 34 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/chefNDishes/chefNDishes/Views/Home/ShowAllDishes.cshtml"
                                              Write(d.CreatedBy.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(1365, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(1400, 11, false);
#line 35 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/chefNDishes/chefNDishes/Views/Home/ShowAllDishes.cshtml"
                       Write(d.Tastiness);

#line default
#line hidden
                EndContext();
                BeginContext(1411, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(1446, 10, false);
#line 36 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/chefNDishes/chefNDishes/Views/Home/ShowAllDishes.cshtml"
                       Write(d.Calories);

#line default
#line hidden
                EndContext();
                BeginContext(1456, 32, true);
                WriteLiteral("</td>\n                    </tr>\n");
                EndContext();
#line 38 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/chefNDishes/chefNDishes/Views/Home/ShowAllDishes.cshtml"
                }

#line default
#line hidden
                BeginContext(1506, 49, true);
                WriteLiteral("            </tbody>\n        </table>\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1562, 9, true);
            WriteLiteral("\n</div>\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
