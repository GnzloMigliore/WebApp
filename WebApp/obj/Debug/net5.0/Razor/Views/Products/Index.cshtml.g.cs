#pragma checksum "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9b5443ca6ae1b5c8f68814da022c1fb341792d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9b5443ca6ae1b5c8f68814da022c1fb341792d9", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Models.Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<article class=""col-8 mx-auto mb-5 mt-4"">
    <h2 class=""titulo-admin pb-3 border-bottom text-center pt-5 mt-5 mx-auto text-uppercase"">PRODUCTOS</h2>
</article>

<section class=""container d-flex justify-content-end"">
    <div class=""row align-items-start col-3 mb-4"">
        <div class=""col"">
            <div class=""dropdown"">
            
                    <button class=""btn btn-outline-dark rounded-0 dropdown-toggle boton-orden-filtro"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                       Filtrar por género
                    </button>
                    <div class=""dropdown-menu dropdown-menu-right filtros-menu-drop"" aria-labelledby=""dropdownMenuButton"">
                        <div class=""contenedores-panel-filtros"">
                            <div class=""padre-box-talles"">
                                <a href=""/Products/FiltroMasculino""><div class=""box-talles"">Masculino</div></a>
                            ");
            WriteLiteral(@"    <a href=""/Products/FiltroFemenino""><div class=""box-talles"">Femenino</div></a>
                                <a href=""/Products/FiltroNiño""><div class=""box-talles"">Niño</div></a>
                                <a href=""/Products""><div class=""box-talles"">Ver todos</div></a>
                            </div>
                        </div>
                    </div>
                    
       
            </div>
        </div>
    </div>
   
</section>


   
            <div class=""container"">
                <div class=""row align-items-start"">
");
#nullable restore
#line 41 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Products\Index.cshtml"
                     foreach (var item in Model)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col  d-flex justify-content-center\">\r\n                            <div class=\"card\" style=\"width: 18rem;\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 2027, "\"", 2074, 1);
#nullable restore
#line 46 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Products\Index.cshtml"
WriteAttributeValue("", 2033, Html.DisplayFor(modelItem => item.image), 2033, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                                <div class=\"card-body\">\r\n                                    <div class=\"row\">\r\n                                        <h5 class=\"card-title ml-3\"> ");
#nullable restore
#line 49 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Products\Index.cshtml"
                                                                Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        <p class=\"card-text\">\r\n                                            <h5 class=\"card-title ml-3\">$ ");
#nullable restore
#line 51 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Products\Index.cshtml"
                                                                     Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        </p>\r\n                                    </div>\r\n\r\n                                    <p class=\"card-text\">\r\n                                        <h5 class=\"card-title\"> ");
#nullable restore
#line 56 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Products\Index.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    </p>\r\n                                    <div class=\"row\">\r\n                                        <p class=\"card-text\">\r\n                                            <h5 class=\"card-title  ml-3\"> ");
#nullable restore
#line 60 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Products\Index.cshtml"
                                                                     Write(Html.DisplayFor(modelItem => item.gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        </p>\r\n                                        <p class=\"card-text\">\r\n                                            <h5 class=\"card-title  ml-3\">Stock ");
#nullable restore
#line 63 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Products\Index.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item.stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        </p>\r\n                                    </div>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9b5443ca6ae1b5c8f68814da022c1fb341792d99008", async() => {
                WriteLiteral("Ver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Products\Index.cshtml"
                                                                                       WriteLiteral(item.id);

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
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                        </div>\r\n");
#nullable restore
#line 70 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Products\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
