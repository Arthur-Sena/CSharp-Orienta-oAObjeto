#pragma checksum "D:\senai\codigos\C#_E_HTML\Hamburgueria_Tarde\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b01fb513af137f754f0b929cc89faa99d19eb623"
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
#line 1 "D:\senai\codigos\C#_E_HTML\Hamburgueria_Tarde\Views\_ViewImports.cshtml"
using Hamburgueria_Tarde;

#line default
#line hidden
#line 2 "D:\senai\codigos\C#_E_HTML\Hamburgueria_Tarde\Views\_ViewImports.cshtml"
using Hamburgueria_Tarde.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01fb513af137f754f0b929cc89faa99d19eb623", @"/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ac6d330bca7c38ed999777249472e97826d572d", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hamburgueria_Tarde.ViewModels.PedidoViewModel>
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
            BeginContext(54, 10, true);
            WriteLiteral("<header>\r\n");
            EndContext();
#line 3 "D:\senai\codigos\C#_E_HTML\Hamburgueria_Tarde\Views\Pedido\Index.cshtml"
      
        Html.RenderPartial("_HeaderNavBar");
    

#line default
#line hidden
            BeginContext(125, 38, true);
            WriteLiteral("</header>\r\n\r\n<main>\r\n    <h2>Pede aí, ");
            EndContext();
            BeginContext(164, 18, false);
#line 9 "D:\senai\codigos\C#_E_HTML\Hamburgueria_Tarde\Views\Pedido\Index.cshtml"
            Write(Model.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(182, 12, true);
            WriteLiteral("!</h2>\r\n    ");
            EndContext();
            BeginContext(194, 1861, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f390f5096be547db872e131b301f0794", async() => {
                BeginContext(246, 171, true);
                WriteLiteral("\r\n        <div>\r\n            <label for=\"nome\">Nome Completo</label>\r\n            <br />\r\n            <input id=\"nome\" type=\"text\" maxlength=\"20\" minlength=\"3\" name=\"nome\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 417, "\"", 444, 1);
#line 14 "D:\senai\codigos\C#_E_HTML\Hamburgueria_Tarde\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 425, Model.Cliente.Nome, 425, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(445, 198, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div>\r\n            <label for=\"endereco\">Endereço</label>\r\n            <br />\r\n            <input id=\"endereco\" type=\"text\" maxlength=\"20\" minlength=\"3\" name=\"endereco\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 643, "\"", 674, 1);
#line 20 "D:\senai\codigos\C#_E_HTML\Hamburgueria_Tarde\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 651, Model.Cliente.Endereco, 651, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(675, 182, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div>\r\n            <label for=\"telefone\">Telefone para contato</label>\r\n            <br />\r\n            <input id=\"telefone\" type=\"text\" name=\"telefone\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 857, "\"", 888, 1);
#line 26 "D:\senai\codigos\C#_E_HTML\Hamburgueria_Tarde\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 865, Model.Cliente.Telefone, 865, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(889, 159, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div>\r\n            <label for=\"email\">E-mail</label>\r\n            <br />\r\n            <input id=\"email\" type=\"email\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1048, "\"", 1076, 1);
#line 32 "D:\senai\codigos\C#_E_HTML\Hamburgueria_Tarde\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 1056, Model.Cliente.Email, 1056, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1077, 217, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div class=\"double-field\">\r\n            <div>\r\n                <label for=\"hamburguer\">Hamburguer</label>\r\n                <select id=\"hamburguer\" name=\"hamburguer\">\r\n                    ");
                EndContext();
                BeginContext(1294, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1e311f694c3412c88633b1a33dfc5aa", async() => {
                    BeginContext(1329, 9, true);
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
                BeginContext(1347, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 40 "D:\senai\codigos\C#_E_HTML\Hamburgueria_Tarde\Views\Pedido\Index.cshtml"
                     foreach(var h in Model.Hamburgueres)
                    {

#line default
#line hidden
                BeginContext(1431, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1455, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5af8cb9f347347638747c92c0fb3a4d0", async() => {
                    BeginContext(1478, 6, false);
#line 42 "D:\senai\codigos\C#_E_HTML\Hamburgueria_Tarde\Views\Pedido\Index.cshtml"
                                         Write(h.Nome);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 42 "D:\senai\codigos\C#_E_HTML\Hamburgueria_Tarde\Views\Pedido\Index.cshtml"
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
                BeginContext(1493, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 43 "D:\senai\codigos\C#_E_HTML\Hamburgueria_Tarde\Views\Pedido\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1518, 186, true);
                WriteLiteral("                </select>\r\n            </div>\r\n            <div>\r\n                <label for=\"shake\">Shake</label>\r\n                <select id=\"shake\" name=\"shake\">\r\n                    ");
                EndContext();
                BeginContext(1704, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca4c7caef4d5473b9f0487e042f31cb1", async() => {
                    BeginContext(1739, 9, true);
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
                BeginContext(1757, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 50 "D:\senai\codigos\C#_E_HTML\Hamburgueria_Tarde\Views\Pedido\Index.cshtml"
                     foreach(var s in Model.Shakes)
                    {

#line default
#line hidden
                BeginContext(1835, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1859, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f029ed51eab34e16b64a897f45fac158", async() => {
                    BeginContext(1882, 6, false);
#line 52 "D:\senai\codigos\C#_E_HTML\Hamburgueria_Tarde\Views\Pedido\Index.cshtml"
                                         Write(s.Nome);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 52 "D:\senai\codigos\C#_E_HTML\Hamburgueria_Tarde\Views\Pedido\Index.cshtml"
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
                BeginContext(1897, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 53 "D:\senai\codigos\C#_E_HTML\Hamburgueria_Tarde\Views\Pedido\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1922, 126, true);
                WriteLiteral("                </select>\r\n            </div>\r\n        </div>\r\n        <input type=\"submit\" value=\"Finalizar pedido!\" />\r\n    ");
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
            BeginContext(2055, 11, true);
            WriteLiteral("\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hamburgueria_Tarde.ViewModels.PedidoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
