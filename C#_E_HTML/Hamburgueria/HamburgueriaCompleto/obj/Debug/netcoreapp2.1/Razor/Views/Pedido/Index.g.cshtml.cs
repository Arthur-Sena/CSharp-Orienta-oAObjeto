#pragma checksum "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1159301ab1e086955da8bec6698434bbaeec836"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Index), @"mvc.1.0.view", @"/Views/Pedido/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/Index.cshtml", typeof(AspNetCore.Views_Pedido_Index))]
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
#line 1 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\_ViewImports.cshtml"
using Hamburgueria;

#line default
#line hidden
#line 2 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\_ViewImports.cshtml"
using Hamburgueria.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1159301ab1e086955da8bec6698434bbaeec836", @"/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bfcae468d1cbc5c7f24a51f853f9b8db2281679", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hamburgueria.ViewModels.PedidoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Pedido/RegistrarPedido"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 9, true);
            WriteLiteral("<header>\n");
            EndContext();
#line 3 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Pedido\Index.cshtml"
      
        Html.RenderPartial("_HeaderNavBar");
    

#line default
#line hidden
            BeginContext(114, 38, true);
            WriteLiteral("</header>\n<main>\n        <h2>Pede aí, ");
            EndContext();
            BeginContext(153, 18, false);
#line 8 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Pedido\Index.cshtml"
                Write(Model.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(171, 15, true);
            WriteLiteral("!</h2>\n        ");
            EndContext();
            BeginContext(186, 1948, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3facadcd70bf4c5c96abe62c757fa659", async() => {
                BeginContext(238, 183, true);
                WriteLiteral("\n            <div>\n                <label for=\"nome\">Nome Completo</label>\n                <br />\n                <input id=\"nome\" type=\"text\" maxlength=\"20\" minlength=\"3\" name=\"nome\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 421, "\"", 448, 1);
#line 13 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 429, Model.Cliente.Nome, 429, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(449, 212, true);
                WriteLiteral("/>\n            </div>\n\n            <div>\n                <label for=\"endereco\">Endereço</label>\n                <br />\n                <input id=\"endereco\" type=\"text\" maxlength=\"20\" minlength=\"3\" name=\"endereco\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 661, "\"", 692, 1);
#line 19 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 669, Model.Cliente.Endereco, 669, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(693, 196, true);
                WriteLiteral("/>\n            </div>\n\n            <div>\n                <label for=\"telefone\">Telefone para contato</label>\n                <br />\n                <input id=\"telefone\" type=\"text\" name=\"telefone\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 889, "\"", 920, 1);
#line 25 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 897, Model.Cliente.Telefone, 897, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(921, 173, true);
                WriteLiteral("/>\n            </div>\n\n            <div>\n                <label for=\"email\">E-mail</label>\n                <br />\n                <input id=\"email\" type=\"email\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1094, "\"", 1122, 1);
#line 31 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 1102, Model.Cliente.Email, 1102, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1123, 243, true);
                WriteLiteral("/>\n            </div>\n\n            <div class=\"double-field\">\n                <div>\n                    <label for=\"hamburguer\">Hamburguer</label>\n                    <select id=\"hamburguer\" name=\"hamburguer\" required>\n                        ");
                EndContext();
                BeginContext(1366, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9878b313ab5542bfbde02735e0fc4375", async() => {
                    BeginContext(1401, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1419, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 39 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Pedido\Index.cshtml"
                         foreach(var h in Model.Hamburgueres){

#line default
#line hidden
                BeginContext(1483, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1511, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f0527ceac7a419db7c3d6542823ff3e", async() => {
                    BeginContext(1534, 6, false);
#line 40 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Pedido\Index.cshtml"
                                             Write(h.Nome);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 40 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Pedido\Index.cshtml"
                              WriteLiteral(h.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1549, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 41 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Pedido\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(1576, 205, true);
                WriteLiteral("                    </select>\n                </div>\n                <div>\n                    <label for=\"shake\">Shake</label>\n                    <select id=\"shake\" name=\"shake\">\n                        ");
                EndContext();
                BeginContext(1781, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16d3d44984374ec69a98d756cf64486e", async() => {
                    BeginContext(1816, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1834, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 48 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Pedido\Index.cshtml"
                         foreach(var s in Model.Shakes){

#line default
#line hidden
                BeginContext(1892, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1920, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f8305c937714de6b574e8081750eecc", async() => {
                    BeginContext(1943, 6, false);
#line 49 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Pedido\Index.cshtml"
                                             Write(s.Nome);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 49 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Pedido\Index.cshtml"
                              WriteLiteral(s.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1958, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 50 "D:\senai\codigos\C#_E_HTML\HamburgueriaCompleto\Views\Pedido\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(1985, 142, true);
                WriteLiteral("                    </select>\n                </div>\n            </div>\n            <input type=\"submit\" value=\"Finalizar pedido!\" />\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2134, 13, true);
            WriteLiteral("\n\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hamburgueria.ViewModels.PedidoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591