#pragma checksum "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\TripLog\TripLog\TripLog\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e15a17df47452e11b9f1932d838ea19667694bba"
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
#line 1 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\TripLog\TripLog\TripLog\Views\_ViewImports.cshtml"
using TripLog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\TripLog\TripLog\TripLog\Views\_ViewImports.cshtml"
using TripLog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e15a17df47452e11b9f1932d838ea19667694bba", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3df7861767a61fb2be61134ada4d1586af4acbc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Trip>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\TripLog\TripLog\TripLog\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Trip Logs";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Destination</th>
                <th scope=""col"">Start Date</th>
                <th scope=""col"">End Date</th>
                <th scope=""col"">Accomodations</th>
                <th scope=""col"">Things To Do</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 18 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\TripLog\TripLog\TripLog\Views\Home\Index.cshtml"
             foreach (Trip trip in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 21 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\TripLog\TripLog\TripLog\Views\Home\Index.cshtml"
                   Write(trip.Destination);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\TripLog\TripLog\TripLog\Views\Home\Index.cshtml"
                   Write(trip.StartDate.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\TripLog\TripLog\TripLog\Views\Home\Index.cshtml"
                   Write(trip.EndDate.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\TripLog\TripLog\TripLog\Views\Home\Index.cshtml"
                   Write(trip.Accomodation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 26 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\TripLog\TripLog\TripLog\Views\Home\Index.cshtml"
                   Write(trip.ThingsToDo1);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                        ");
#nullable restore
#line 27 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\TripLog\TripLog\TripLog\Views\Home\Index.cshtml"
                   Write(trip.ThingsToDo2);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                        ");
#nullable restore
#line 28 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\TripLog\TripLog\TripLog\Views\Home\Index.cshtml"
                   Write(trip.ThingsToDo3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "C:\OneDrive\OneDrive - George Brown College\Semester IV\Courses\Web Application Development\TripLog\TripLog\TripLog\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Trip>> Html { get; private set; }
    }
}
#pragma warning restore 1591