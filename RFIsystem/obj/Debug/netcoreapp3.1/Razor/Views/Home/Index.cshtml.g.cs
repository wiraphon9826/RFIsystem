#pragma checksum "C:\Users\wirap\Desktop\CostControl\WebRFIApproval\RFIsystem\RFIsystem\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58fd74aa1a22f2b01e71c4efeb2f88757e12354d"
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
#line 1 "C:\Users\wirap\Desktop\CostControl\WebRFIApproval\RFIsystem\RFIsystem\Views\_ViewImports.cshtml"
using RFIsystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wirap\Desktop\CostControl\WebRFIApproval\RFIsystem\RFIsystem\Views\_ViewImports.cshtml"
using RFIsystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58fd74aa1a22f2b01e71c4efeb2f88757e12354d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58e54e9afb5823c07882b15b09ffcc27358378c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\wirap\Desktop\CostControl\WebRFIApproval\RFIsystem\RFIsystem\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />

<h2 style=""text-align:center;"">
    เกร็ดความรู้เรื่องการเกษตร  
</h2>
<div class=""table-responsive"">
    <table id=""tbtest"" class=""table table-striped table-bordered"" style=""width:100%"">
        <thead class=""table-dark"">
            <tr>
                <th>Name</th>
                <th>Position</th>
                <th>Office</th>
                <th>Age</th>
                <th>Start date</th>
                <th>Status</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>Tiger Nixon</td>
                <td>System Architect</td>
                <td>Edinburgh</td>
                <td>61</td>
                <td>2011/04/25</td>
                <td>$320,800</td>
            </tr>
        </tbody>
        <tfoot>
            <tr>
                <th>Name</th>
                <th>Position</th>
                <th>Office</th>
                <th>Age</th>
                <th>Start date</th>
                <th>Salary</th>
       ");
            WriteLiteral("     </tr>\r\n        </tfoot>\r\n    </table>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n<input id=\"btn\" type=\"submit\" value=\"submit\" />\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.2.2/Chart.bundle.min.js""></script>
    <script>
        $(document).ready(function () {
            $('#tbtest').DataTable();
        });
        $(document).ready(function () {
            $(""#btn"").click(function () {
                Swal.fire(
                    'Good job!',
                    'You clicked the button!',
                    'success'
                )
            });
        });
        $(document).ready(function () {
            var url = '");
#nullable restore
#line 69 "C:\Users\wirap\Desktop\CostControl\WebRFIApproval\RFIsystem\RFIsystem\Views\Home\Index.cshtml"
                  Write(Url.Action("LoginIndex","Login"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
            $(""#btnt"").click(function () {
                Swal.fire({
                    title: 'Are you sure?',
                    text: ""You won't be able to revert this!"",
                    icon: 'warning',
                    showCancelButton: true,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#d33',
                    confirmButtonText: 'Yes, Approved it!'
                }).then((result) => {
                    if (result.value) {
                       
                        window.location.href = url
                    }

                })

            });
        });
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
