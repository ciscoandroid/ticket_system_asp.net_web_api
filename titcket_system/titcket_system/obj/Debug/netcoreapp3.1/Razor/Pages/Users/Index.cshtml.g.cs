#pragma checksum "I:\Softbooks\ASP.NET Core MVC with GitHub\Online Bug Tracker\2022_11_25_AM09_28\tickte_system_crud\ticket_CRUD_DB\titcket_system\titcket_system\Pages\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb83fbccdb4c47a8f7fc681e7a5f4d540a9165b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(titcket_system.Pages.Users.Pages_Users_Index), @"mvc.1.0.razor-page", @"/Pages/Users/Index.cshtml")]
namespace titcket_system.Pages.Users
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
#line 1 "I:\Softbooks\ASP.NET Core MVC with GitHub\Online Bug Tracker\2022_11_25_AM09_28\tickte_system_crud\ticket_CRUD_DB\titcket_system\titcket_system\Pages\_ViewImports.cshtml"
using titcket_system;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb83fbccdb4c47a8f7fc681e7a5f4d540a9165b1", @"/Pages/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c29ec46b408486cfbddd2471556747bf6c797d34", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Users_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<br />
<h2>List of User Information</h2>
<a class='btn btn-primary btn-sm' href=""/Users/Create"">New User</a>
<br />
<table  class=""table"" style=""border:solid"">
    <thead>
        <tr>
            <th style=""width: 10%;"">User ID</th>
            <th style=""width: 15%;"">Full Name</th>
            <th style=""width: 15%;"">Email</th>
            <th style=""width: 15%;"">Current Address</th>
            <th style=""width: 10%;"">Phone Number</th>
            <th style=""width: 15%;"">Create At</th>
            <th style=""width: 10%;"">Actions</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "I:\Softbooks\ASP.NET Core MVC with GitHub\Online Bug Tracker\2022_11_25_AM09_28\tickte_system_crud\ticket_CRUD_DB\titcket_system\titcket_system\Pages\Users\Index.cshtml"
         foreach (var item in Model.ListUsers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 26 "I:\Softbooks\ASP.NET Core MVC with GitHub\Online Bug Tracker\2022_11_25_AM09_28\tickte_system_crud\ticket_CRUD_DB\titcket_system\titcket_system\Pages\Users\Index.cshtml"
               Write(item.user_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "I:\Softbooks\ASP.NET Core MVC with GitHub\Online Bug Tracker\2022_11_25_AM09_28\tickte_system_crud\ticket_CRUD_DB\titcket_system\titcket_system\Pages\Users\Index.cshtml"
               Write(item.fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "I:\Softbooks\ASP.NET Core MVC with GitHub\Online Bug Tracker\2022_11_25_AM09_28\tickte_system_crud\ticket_CRUD_DB\titcket_system\titcket_system\Pages\Users\Index.cshtml"
               Write(item.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "I:\Softbooks\ASP.NET Core MVC with GitHub\Online Bug Tracker\2022_11_25_AM09_28\tickte_system_crud\ticket_CRUD_DB\titcket_system\titcket_system\Pages\Users\Index.cshtml"
               Write(item.address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "I:\Softbooks\ASP.NET Core MVC with GitHub\Online Bug Tracker\2022_11_25_AM09_28\tickte_system_crud\ticket_CRUD_DB\titcket_system\titcket_system\Pages\Users\Index.cshtml"
               Write(item.phones);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "I:\Softbooks\ASP.NET Core MVC with GitHub\Online Bug Tracker\2022_11_25_AM09_28\tickte_system_crud\ticket_CRUD_DB\titcket_system\titcket_system\Pages\Users\Index.cshtml"
               Write(item.create_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                    <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1057, "\"", 1097, 2);
            WriteAttributeValue("", 1064, "/Users/Edit?user_id=", 1064, 20, true);
#nullable restore
#line 34 "I:\Softbooks\ASP.NET Core MVC with GitHub\Online Bug Tracker\2022_11_25_AM09_28\tickte_system_crud\ticket_CRUD_DB\titcket_system\titcket_system\Pages\Users\Index.cshtml"
WriteAttributeValue("", 1084, item.user_id, 1084, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                    <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1162, "\"", 1204, 2);
            WriteAttributeValue("", 1169, "/Users/Delete?user_id=", 1169, 22, true);
#nullable restore
#line 35 "I:\Softbooks\ASP.NET Core MVC with GitHub\Online Bug Tracker\2022_11_25_AM09_28\tickte_system_crud\ticket_CRUD_DB\titcket_system\titcket_system\Pages\Users\Index.cshtml"
WriteAttributeValue("", 1191, item.user_id, 1191, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "I:\Softbooks\ASP.NET Core MVC with GitHub\Online Bug Tracker\2022_11_25_AM09_28\tickte_system_crud\ticket_CRUD_DB\titcket_system\titcket_system\Pages\Users\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<titcket_system.Pages.Clients.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<titcket_system.Pages.Clients.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<titcket_system.Pages.Clients.IndexModel>)PageContext?.ViewData;
        public titcket_system.Pages.Clients.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591