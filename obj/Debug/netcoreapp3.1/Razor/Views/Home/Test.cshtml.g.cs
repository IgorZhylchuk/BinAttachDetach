#pragma checksum "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "886aa4ea40e34fc67bb8cf5ad7731b440b49c498"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Test), @"mvc.1.0.view", @"/Views/Home/Test.cshtml")]
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
#line 1 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\_ViewImports.cshtml"
using BinAttachment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\_ViewImports.cshtml"
using BinAttachment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"886aa4ea40e34fc67bb8cf5ad7731b440b49c498", @"/Views/Home/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a42ac1b44667f54f22cd501a9034ba1a93f1eda", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css"" integrity=""sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi"" crossorigin=""anonymous"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css"" />
<div class=""container"">
    <button class=""btn btn-primary"" style="" margin-top:50px"" onclick=""AttachDetach()"">Click</button>
</div>
<div class=""modal-content"" hidden id=""addBin"">
        <div class=""modal-body"">
            <div class=""form-group"">

                <input class=""form-control"" type=""text"" required minlength=""12"" maxlength=""12"" id=""binNumber"" />
                <span id=""warning"" style=""color:red; font-size:small; font-style:normal""></span>
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col text-center"">
                <input type=""submit"" value=""Submit"" class=""btn btn-primary"" disabled id=""binSend"" />
                <in");
            WriteLiteral("put type=\"reset\" value=\"Reset\" class=\"btn btn-secondary\" />\r\n            </div>\r\n        </div>\r\n    \r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.6.1.min.js"" integrity=""sha256-o88AwQnZB+VDvE9tvIXrMQaPlFFSUTR+nldQm1LuPXQ="" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.min.js"" integrity=""sha384-IDwe1+LCz02ROU9k972gdyvl+AESN10+x7tBKgc9I5HFtuNz0wWnPclzo6p9vxnk"" crossorigin=""anonymous""></script>
    <script type=""text/javascript"" src=""//cdnjs.cloudflare.com/ajax/libs/jquery.bootstrapvalidator/0.5.2/js/bootstrapValidator.min.js""></script>

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js""></script>
    <script>
        function AttachDetach() {
            $('#addBin').removeAttr('hidden').dialog({
                autoOpen: true,
                modal: true,
                draggable: true,
                title: ""Enter bin number"",
                position: { my: ""center"", at: ""center"", of: window },
                resizable: false,
                height: 'auto',
                widt");
                WriteLiteral(@"h: 500,
                close: function () {
                    $(this).closest('.ui-dialog-content').dialog('close');
                   // setTimeout(function () {
                     //   window.location.reload();
                    //}, 100);
                }
            });
        }
    </script>
");
            }
            );
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
