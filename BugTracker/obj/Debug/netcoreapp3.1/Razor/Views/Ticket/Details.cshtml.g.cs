#pragma checksum "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0da91998c87540aee8804060e1b603db839d00a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_Details), @"mvc.1.0.view", @"/Views/Ticket/Details.cshtml")]
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
#line 1 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\_ViewImports.cshtml"
using BugTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\_ViewImports.cshtml"
using BugTracker.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
using BugTracker.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0da91998c87540aee8804060e1b603db839d00a3", @"/Views/Ticket/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"415cd50ac37814e1a4fb76bf7d07627084cdfa27", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BugTracker.ViewModels.DisplayTicketViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ticket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Project", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details for ");
#nullable restore
#line 12 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
           Write(Html.DisplayFor(model => model.Ticket.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

<div class=""card"">
    <div class=""card-header"">
        <h4>Ticket</h4>
    </div>
    <div class=""card-body"">
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Ticket Title</th>
                    <th scope=""col"">Ticket Description</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>");
#nullable restore
#line 28 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Ticket.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Ticket.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
            </tbody>

            <thead>
                <tr>
                    <th scope=""col"">Assigned Developer</th>
                    <th scope=""col"">Submitter</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
");
#nullable restore
#line 42 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
                         if (Model.Ticket.Developer == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>None</p>\r\n");
#nullable restore
#line 45 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Ticket.Developer));

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
                                                                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>");
#nullable restore
#line 51 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Ticket.Submitter));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
            </tbody>

            <thead>
                <tr>
                    <th scope=""col"">Project</th>
                    <th scope=""col"">Ticket Priority</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>");
#nullable restore
#line 63 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Project.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 64 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Ticket.Priority));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
            </tbody>

            <thead>
                <tr>
                    <th scope=""col"">Ticket Status</th>
                    <th scope=""col"">Ticket Type</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>");
#nullable restore
#line 76 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Ticket.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 77 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Ticket.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
            </tbody>

            <thead>
                <tr>
                    <th scope=""col"">Created</th>
                    <th scope=""col"">Updated</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>");
#nullable restore
#line 89 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Ticket.Created));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 91 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
                         if (Model.Ticket.Updated != DateTime.MinValue)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Ticket.Updated));

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
                                                                           
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>----</p>\r\n");
#nullable restore
#line 98 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n    <div class=\"card-footer\">\r\n        <p>\r\n");
#nullable restore
#line 107 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
             if (Model.FromTickets == true)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
                 if ((SignInManager.IsSignedIn(User)) && ((User.IsInRole("Admin")) || (User.IsInRole("Project Manager")) || (User.IsInRole("Developer"))))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0da91998c87540aee8804060e1b603db839d00a312706", async() => {
                WriteLiteral("\r\n                        Edit\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
                                                                   WriteLiteral(Model.Ticket.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 115 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0da91998c87540aee8804060e1b603db839d00a315454", async() => {
                WriteLiteral("\r\n                    Back to List\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 120 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0da91998c87540aee8804060e1b603db839d00a317203", async() => {
                WriteLiteral("\r\n                    Back to List\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 127 "C:\Users\Gigabyte\Proiecte\BugTracker\BugTracker\Views\Ticket\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n\r\n        </p>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<BugTrackerUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BugTracker.ViewModels.DisplayTicketViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
