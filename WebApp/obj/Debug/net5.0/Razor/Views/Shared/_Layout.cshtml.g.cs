#pragma checksum "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf5a0df586179cbcc5e4428010de5be255385591"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf5a0df586179cbcc5e4428010de5be255385591", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf5a0df586179cbcc5e4428010de5be2553855916299", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - WebApp</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf5a0df586179cbcc5e4428010de5be2553855916935", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf5a0df586179cbcc5e4428010de5be2553855918113", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Montserrat:wght@200&display=swap"" rel=""stylesheet"">
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Ceviche+One&display=swap"" rel=""stylesheet"">
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf5a0df586179cbcc5e4428010de5be25538559110508", async() => {
                WriteLiteral("\r\n    <header>\r\n");
#nullable restore
#line 18 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Shared\_Layout.cshtml"
         if(ViewBag.EstaLogueado=="false"){

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <nav id=""navbar"" class=""nav navbar navbar-expand-lg navbar-light"">
            <div class=""container-fluid mr-3"">
                <a href=""/"" class=""logo1""> <img class=""logo"" src=""/images/logo/logo.png""></a>
                <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse justify-content-center "" id=""navbarSupportedContent"">

                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf5a0df586179cbcc5e4428010de5be25538559111716", async() => {
                    WriteLiteral("\r\n                        <input class=\"form-control me-2\" type=\"search\" placeholder=\"Search\" aria-label=\"Search\">\r\n                        <button class=\"btn btn-outline-dark\" type=\"submit\">Search</button>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                </div>
                <ul class="" navbar-nav me-auto mb-2 mb-lg-0"">
                   
                    <li class="" nav-item"">
                        <a class=""nav-link"" href=""/Home/Contacto"" style=""color:white;font-size:1.2rem;"">Contacto</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link mr-4"" href=""/Home/Nosotros"" style=""color:white;font-size:1.2rem;"">Nosotros</a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/Products"" class=""nav-link mr-4"" href=""#"" style=""color:white;font-size:1.2rem;"">Productos</a>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class="" nav-link dropdown-toggle"" style=""color:white;font-size:1.2rem;"" href=""#"" id=""navbarDropdown"" role=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            Login
                        </a>
                       ");
                WriteLiteral(@" <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                            <li><a class=""dropdown-item"" href=""/User"">Crear cuenta</a></li>
                            <li><a class=""dropdown-item"" href=""/User/Login"">Iniciar sesión</a></li>

                        </ul>
                    </li>
                </ul>
            </div>
        </nav>
");
#nullable restore
#line 57 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Shared\_Layout.cshtml"
        }else{


#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <nav id=""navbar"" class=""nav navbar navbar-expand-lg navbar-light"">
            <div class=""container-fluid mr-3"">
                <a href=""/"" class=""logo1""> <img class=""logo"" src=""/images/logo/logo.png""></a>
                <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse justify-content-center "" id=""navbarSupportedContent"">

                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf5a0df586179cbcc5e4428010de5be25538559115735", async() => {
                    WriteLiteral("\r\n                        <input class=\"form-control me-2\" type=\"search\" placeholder=\"Search\" aria-label=\"Search\">\r\n                        <button class=\"btn btn-outline-dark\" type=\"submit\">Search</button>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                </div>\r\n                <ul class=\" navbar-nav me-auto mb-2 mb-lg-0\">\r\n");
#nullable restore
#line 74 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Shared\_Layout.cshtml"
                     if (ViewBag.role == 9)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\" nav-item\">\r\n                            <a href=\"/AdminProducts\" class=\"nav-link\" style=\"color:white;font-size:1.2rem;\">Administrar productos</a>\r\n                        </li>\r\n");
#nullable restore
#line 79 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Shared\_Layout.cshtml"
                     if (ViewBag.role != 9)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <li class="" nav-item"">
                            <a class=""nav-link"" href=""/Home/Contacto"" style=""color:white;font-size:1.2rem;"">Contacto</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link mr-4"" href=""/Home/Nosotros"" style=""color:white;font-size:1.2rem;"">Nosotros</a>
                        </li>
");
#nullable restore
#line 88 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <li class=""nav-item"">
                            <a href=""/Products"" class=""nav-link mr-4"" href=""#"" style=""color:white;font-size:1.2rem;"">Productos</a>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class="" nav-link dropdown-toggle"" style=""color:white;font-size:1.2rem;"" href=""#"" id=""navbarDropdown"" role=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                ");
#nullable restore
#line 94 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Shared\_Layout.cshtml"
                           Write(ViewBag.Usuario);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </a>
                            <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                                <li><a class=""dropdown-item"" href=""/User"">Perfil</a></li>
                                <li><a class=""dropdown-item"" href=""/User/Logout"">Cerrar sesión</a></li>

                            </ul>
                        </li>
                    </ul>
            </div>
        </nav>
");
#nullable restore
#line 105 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Shared\_Layout.cshtml"


        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </header>\r\n    <div class=\"w-100\">\r\n        <main role=\"main\">\r\n              \r\n            ");
#nullable restore
#line 112 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
    </div>

    <footer class=""footer"">
        <div class=""row align-items-start"">
            <div class=""col"">

                <img class=""logofooter  mt-3"" src=""/images/logo/logo.png"">
                <p class=""rutes footer-links"">
                    <a style=""color:black;font-size:1rem;"" href=""#"">Home</a>
                    |
                    <a style=""color:black;font-size:1rem;"" href=""#"">Nosotros</a>
                    |
                    <a style=""color:black;font-size:1rem;"" href=""#"">Productos</a>
                    |
                    <a style=""color:black;font-size:1rem;"" href=""#"">Contacto</a>
                </p>
                <p class=""firma footer-company-name"">©️ 2021 SNEAKEREST</p>
            </div>

            <div class=""col"">
                <ion-icon class=""mt-4"" name=""navigate-circle-outline""></ion-icon>
                <p>

                    <span>
                        Av. Libertador, Belgrano <br />

                    <");
                WriteLiteral(@"/span>
                    Belgrano, Buenos Aires - Argentina
                </p>
                <ion-icon name=""call-outline""></ion-icon>
                <p>112342321/12312412</p>
                <ion-icon name=""mail-outline""></ion-icon>
                <p>support@sneakerest.com</p>
            </div>
            <div class=""col"">
                <p class=""mt-5 footer-company-about"">
                    <span>Sobre nosotros</span><br />
                    Somos una Ecommerce que se dedica a comercializar zapatillas de tipo urbano. Tenemos desde los modelos clásicos, los nuevos modelos hasta las tendencias del momento.
                </p>
                <div class=""footer-icons"">
                    <a href=""#""><ion-icon style=""color:black;font-size:1rem;"" name=""logo-facebook""></ion-icon></a>
                    <a href=""#""><ion-icon style=""color:black;font-size:1rem;"" name=""logo-twitter""></ion-icon></a>
                    <a href=""#""><ion-icon style=""color:black;font-size:1rem;"" name=""l");
                WriteLiteral(@"ogo-instagram""></ion-icon></a>
                    <a href=""#""><ion-icon style=""color:black;font-size:1rem;"" name=""logo-linkedin""></ion-icon></a>
                    <a href=""#""><ion-icon style=""color:black;font-size:1rem;"" name=""logo-youtube""></ion-icon></a>
                </div>
            </div>
        </div>

    </footer>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf5a0df586179cbcc5e4428010de5be25538559123332", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf5a0df586179cbcc5e4428010de5be25538559124432", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf5a0df586179cbcc5e4428010de5be25538559125532", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 166 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <!-- Option 1: Bootstrap Bundle with Popper -->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM"" crossorigin=""anonymous""></script>
    <script type=""module"" src=""https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js""></script>
    <script nomodule src=""https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.js""></script>
    ");
#nullable restore
#line 171 "C:\Users\Gonzalo Migliore\Desktop\WebApp\WebApp\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
