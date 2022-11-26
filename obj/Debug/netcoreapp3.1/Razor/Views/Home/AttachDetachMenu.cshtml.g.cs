#pragma checksum "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34655eb010c4276087e31d5eea0778d7dac57b3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AttachDetachMenu), @"mvc.1.0.view", @"/Views/Home/AttachDetachMenu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34655eb010c4276087e31d5eea0778d7dac57b3e", @"/Views/Home/AttachDetachMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a42ac1b44667f54f22cd501a9034ba1a93f1eda", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AttachDetachMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BinAttachmentApp.Models.AttachedStringNamesModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("processName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("machineName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("minlength", new global::Microsoft.AspNetCore.Html.HtmlString("12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("maxlength", new global::Microsoft.AspNetCore.Html.HtmlString("12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("binNum"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BinAttachment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
  
    IEnumerable<BinAttachmentApp.Models.MachineModel> machines = ViewBag.Machines;
    IEnumerable<BinAttachmentApp.Models.ProcessModel> processes = ViewBag.Processes;
    IEnumerable<BinAttachmentModel> bins = ViewBag.Bins;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css"" integrity=""sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi"" crossorigin=""anonymous"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css"" />

<style>
    .ui-dialog-titlebar-close:after {
        content: 'X' !important;
        position: absolute;
        top: -2px;
        right: 3px;
    }
</style>
<div class=""container"" style=""padding:10px;width:100%"">
");
#nullable restore
#line 19 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
     foreach (var process in processes)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"modal-content\">\r\n            <h6 style=\"text-align: center; margin-top:20px;\">");
#nullable restore
#line 22 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
                                                        Write(process.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <div class=\"card-deck\" style=\"margin-top:20px; \">\r\n");
#nullable restore
#line 24 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
                 foreach (var machine in machines.Where(p => p.Process.Id == process.Id).Select(m => m).ToList())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
                     if (bins.Select(m => m.Machine).Contains(machine) == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card\" style=\"background-color: gainsboro;\">\r\n                            <div class=\"card-body\">\r\n                                <h6 class=\"card-title\" style=\"text-align:center\">");
#nullable restore
#line 30 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
                                                                            Write(machine.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <input class=\"form-control\" id=\"binNumber\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1615, "\"", 1644, 3);
            WriteAttributeValue("", 1625, "GetBin(", 1625, 7, true);
#nullable restore
#line 31 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
WriteAttributeValue("", 1632, machine.Id, 1632, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1643, ")", 1643, 1, true);
            EndWriteAttribute();
            WriteLiteral(" readonly style=\"text-align:center\"");
            BeginWriteAttribute("value", " value=\"", 1680, "\"", 1766, 1);
#nullable restore
#line 31 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
WriteAttributeValue("", 1688, bins.Where(m => m.Machine.Id == machine.Id).Select(b => b.BinNumber).Single(), 1688, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </div>\r\n\r\n                        </div>\r\n");
#nullable restore
#line 35 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card\" style=\"background-color: gainsboro;\">\r\n                            <div class=\"card-body\">\r\n                                <h6 class=\"card-title\" style=\"text-align:center\">");
#nullable restore
#line 40 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
                                                                            Write(machine.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <input class=\"form-control\" id=\"emptyInput\" style=\"text-align:center\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2250, "\"", 2295, 5);
            WriteAttributeValue("", 2260, "SetValues(", 2260, 10, true);
#nullable restore
#line 41 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
WriteAttributeValue("", 2270, machine.Id, 2270, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2281, ",", 2281, 1, true);
#nullable restore
#line 41 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
WriteAttributeValue(" ", 2282, process.Id, 2283, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2294, ")", 2294, 1, true);
            EndWriteAttribute();
            WriteLiteral("/>\r\n                                <div class=\"modal-content\" style=\"width:430px;height:180px;position:center\" hidden id=\"addBin\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34655eb010c4276087e31d5eea0778d7dac57b3e12332", async() => {
                WriteLiteral("\r\n\r\n                                        <div class=\"modal-body\">\r\n                                            <div class=\"form-group\">\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "34655eb010c4276087e31d5eea0778d7dac57b3e12787", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 47 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProcessName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "34655eb010c4276087e31d5eea0778d7dac57b3e14744", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 48 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MachineName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "34655eb010c4276087e31d5eea0778d7dac57b3e16701", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 49 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BinNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                <span id=""warning"" style=""color:red; font-size:small; font-style:normal""></span>
                                            </div>
                                        </div>
                                        <div class=""form-group"">
                                            <div class=""col text-center"">
                                                <input type=""submit"" value=""Submit""  class=""btn btn-primary"" disabled id=""submitButton"" />
                                                <input type=""reset"" value=""Reset"" class=""btn btn-secondary"" />
                                            </div>
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <div class=""card text-white bg-danger mb-3"" style=""max-width:100%;"" id=""attached"" hidden>
                                        <div class=""card-body"">
                                            <h5 class=""card-title"">This bin is currently using</h5>
                                            <br />
                                            <span>Process</span>
                                            <input class=""form-control"" id=""process"" disabled />
                                            <br />
                                            <span>Machine</span>
                                            <input class=""form-control"" id=""machine"" disabled />
                                        </div>
                                    </div>
                                    <div class=""card text-white bg-success mb-3"" style=""max-width: 100%;"" id=""freeToUse"" hidden>
                                        <div class=""card-body"">
          ");
            WriteLiteral(@"                                  <h5 class=""card-title"">Free to use</h5>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 79 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 84 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.6.1.min.js"" integrity=""sha256-o88AwQnZB+VDvE9tvIXrMQaPlFFSUTR+nldQm1LuPXQ="" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.min.js"" integrity=""sha384-IDwe1+LCz02ROU9k972gdyvl+AESN10+x7tBKgc9I5HFtuNz0wWnPclzo6p9vxnk"" crossorigin=""anonymous""></script>
    <script type=""text/javascript"" src=""//cdnjs.cloudflare.com/ajax/libs/jquery.bootstrapvalidator/0.5.2/js/bootstrapValidator.min.js""></script>
    <script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js""></script>


    <script>
        $(document).ready(function () {

            var attached = document.getElementById('attached');
            var free = document.getElementById('freeToUse');
            var process = document.getElementById('process');
            var machine = document.getElementById('machine');
            var button = d");
                WriteLiteral(@"ocument.getElementById('submitButton');
            var message = $('#warning');
            document.getElementById('binNum').addEventListener('keyup', function () {                
                var binNumber = this.value;
                if (binNumber.length == 12) {
                    $.ajax({
                        type: 'Get',
                        url: '");
#nullable restore
#line 112 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
                         Write(Url.Action("BinStatus", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        dataType: 'json',
                        data: { 'binNumber': binNumber },
                        success: function (data) {
                            if (data['status'] == ""Free to use"") {
                                if (binNumber.length == 12) {
                                    free.removeAttribute('hidden');
                                    button.removeAttribute('disabled');
                                    message.text("""");
                                }
                                else {
                                    attached.hidden = true;
                                    free.hidden = true;
                                    button.disabled = true;
                                    message.text(""Please, check bin's number!"");
                                }

                            }

                            else if (data['status'] == ""Filling"") {
                                if (binNumber.length == 12) {
");
                WriteLiteral(@"                                    attached.removeAttribute('hidden');
                                    process.value = data['process'];
                                    machine.value = data['machine'];
                                    message.text("""");
                                    free.hidden = true;
                                }

                            }
                            else if (data['status'] == null || binNumber.length != 12) {
                                message.text(""Please, check bin number!"");
                                attached.hidden = true;
                                free.hidden = true;
                                button.disabled = true;
                            }
                            else {
                                attached.hidden = true;
                                free.hidden = true;
                                button.disabled = true;
                                message.text(""Please, check bin ");
                WriteLiteral(@"number!"");
                            }

                        }
                    })
                }
                else {
                    attached.hidden = true;
                    free.hidden = true;
                    button.disabled = true;
                    message.text("""");
                }
                
            })
            
        });
        function SetValues(machineName, processName) {
            $.ajax({
                success: function () {
                    document.getElementById('processName').value = processName;
                    document.getElementById('machineName').value = machineName;
                    BinAdding();
                }
            })
        }
    
         function BinCheking(binNumber) {
            var attached = document.getElementById('attached');
            var free = document.getElementById('freeToUse');
            var process = document.getElementById('processName');
            var machine = docume");
                WriteLiteral("nt.getElementById(\'machineName\');\r\n            var button = document.getElementById(\'submitButton\');\r\n            $.ajax({\r\n                type: \'Get\',\r\n                url: \'");
#nullable restore
#line 185 "C:\Users\Igor\source\repos\BinAttachment\BinAttachment\Views\Home\AttachDetachMenu.cshtml"
                 Write(Url.Action("BinStatus", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                dataType: 'json',
                data: { 'binNumber': binNumber },
                success: function (data) {
                    if (data['status'] == ""Free to use"") {
                        if (binNumber.length == 12) {
                          
                            free.removeAttribute('hidden');
                            button.removeAttribute('disabled');
                            $('#warning').text("""");
                        }
                        else {
                            attached.hidden = true;
                            free.hidden = true;
                            button.disabled = true;
                            $('#warning').text("""");
                        }
                    }
                    else if (data['status'] == ""Filling""){
                        if (binNumber.length == 12) {
                            $('#addBin').dialog({
                                height: 600
                            })
        ");
                WriteLiteral(@"                    attached.removeAttribute('hidden');
                            process.value = data['process'];
                            machine.value = data['machine'];
                            $('#warning').text("""");
                            free.hidden = true;
                        }
                    }
                    else if (data['status'] == null || binNumber.length != 12) {
                        $('#warning').text(""Please, check bin number!"");
                        attached.hidden = true;
                        free.hidden = true;
                        button.disabled = true;
                    }
                    else {
                        attached.hidden = true;
                        free.hidden = true;
                        button.disabled = true;
                        $('#warning').text("""");
                    }
                }
            })
        }
        function GetBin(id) {
            $.ajax({
                type: ""Get""");
                WriteLiteral(@",
                url: '/Home/GetBin/' + id,
                success: function (data) {
                    Swal.fire({
                        title: 'Detach bin ' + data + ' ?',
                        text: """",
                        icon: 'question',
                        showCancelButton: true,
                        showConfirmButton: true,
                        cancelButtonText: 'Back',
                        confirmButtonColor: '#3085d6',
                        cancelButtonColor: '#d33',
                        confirmButtonText: 'Yes!'
                    }).then((result) => {
                        if (result.isConfirmed) {
                            $.ajax({
                                type: 'POST',
                                url: '/Home/Detach/' + data,
                                data: { 'binNumber': data },
                                success: function (response) {
                                    if (response.success) {
                        ");
                WriteLiteral(@"                setTimeout(function () { window.location.reload() }, 1000);
                                    }
                                }
                            })
                            Swal.fire(
                                'Done!',
                                '',
                                'success'
                            )
                        }
                    })
                }
            })
        }

        function BinAdding() {
            $('#addBin').removeAttr('hidden').dialog({
                        autoOpen: true,
                        modal: true,
                        draggable: true,
                        title: ""Enter bin number"",
                        position: { my: ""center"", at: ""top"", of: window },
                        resizable: false,
                        height: 'auto',
                        width: 400,
                        close: function () {
                            $(this).closest('");
                WriteLiteral(@".ui-dialog-content').dialog('destroy').remove();
                            setTimeout(function () {
                                window.location.reload();
                            }, 100);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BinAttachmentApp.Models.AttachedStringNamesModel> Html { get; private set; }
    }
}
#pragma warning restore 1591