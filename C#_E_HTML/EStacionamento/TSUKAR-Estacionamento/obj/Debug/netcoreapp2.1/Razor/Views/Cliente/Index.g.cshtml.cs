#pragma checksum "D:\senai\codigos\C#_E_HTML\TSUKAR-Estacionamento\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e626b540b8e7cf9fd00e35d11e844c51bbd2e6c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Index.cshtml", typeof(AspNetCore.Views_Cliente_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e626b540b8e7cf9fd00e35d11e844c51bbd2e6c2", @"/Views/Cliente/Index.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\senai\codigos\C#_E_HTML\TSUKAR-Estacionamento\Views\Cliente\Index.cshtml"
  
    Layout = "MasterPage";
    ViewBag.Title = "CADASTRAR";

#line default
#line hidden
            BeginContext(69, 784, true);
            WriteLiteral(@"<div class = ""container"">
    <form action=""/Cliente/Cadastrar"" method=""POST"">
    <h1>CARRO</h1>
        <div class=""form-group"">

            <label for=""nome"">Nome:</label>
            <input type=""text"" name=""nome"" class=""form-control"">
            
            <label for=""modelo"">Modelo:</label>
            <input type=""text"" name=""modelo"" class=""form-control"">
            
            <label for=""senha"">Marca:</label>
            <input type=""text"" name=""marca"" class=""form-control"">
            
            <label for=""placa"">Placa:</label>
            <input type=""text"" name=""placa"" class=""form-control"">
            <br>
            <input type=""submit"" value=""Cadastrar"" class=""btn btn-secondary btn-lg btn-block"">
        </div>
    </form>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
