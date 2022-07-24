#pragma checksum "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "559042a06499f4ef6f12a2a6e9afb4e665b7897e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListCustomers), @"mvc.1.0.view", @"/Views/Home/ListCustomers.cshtml")]
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
#line 2 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
using Web_Library_Manage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"559042a06499f4ef6f12a2a6e9afb4e665b7897e", @"/Views/Home/ListCustomers.cshtml")]
    public class Views_Home_ListCustomers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-light-grey"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n");
            WriteLiteral("<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "559042a06499f4ef6f12a2a6e9afb4e665b7897e3311", async() => {
                WriteLiteral(@"
    <title>List Customers</title>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Raleway"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css""
          integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css""
          integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==""
          crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css""
          integrity=""sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z"" ");
                WriteLiteral(@"crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.3.0/font/bootstrap-icons.css"">
    <style>
        body,
        h1,
        h2,
        h3,
        h4,
        h5 {
            font-family: ""Raleway"", sans-serif
        }

        .w3-quarter h4 {
            position: absolute;
            top: 240px;
            font-weight: bold;
            font-size: 40px;
            color: white;
        }

        .w3-quarter img {
            margin-bottom: -6px;
            cursor: pointer
        }

            .w3-quarter img:hover {
                opacity: 0.6;
                transition: 0.3s
            }

        .activeCid {
            font-weight: bold;
            font-size: 20px;
            color: black;
        }
    </style>
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "559042a06499f4ef6f12a2a6e9afb4e665b7897e6221", async() => {
                WriteLiteral(@"

    <!-- Sidebar/menu -->
    <nav class=""w3-sidebar w3-bar-block w3-black w3-animate-right w3-top w3-text-light-grey w3-large""
         style=""z-index:3;width:250px;font-weight:bold;display:none;right:0;"" id=""mySidebar"">
        <h4 class=""w3-bar-item w3-center w3-padding-16"" style=""background-color: yellow; color:black"">Hello,  ");
#nullable restore
#line 60 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                                                                                                          Write(ViewBag.userLogin.Uname);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h4>
        <a href=""/Home/Logout"" class=""w3-bar-item w3-button w3-center w3-padding-16"">LOGOUT</a>
        <a href=""#about"" onclick=""w3_close()"" class=""w3-bar-item w3-button w3-center w3-padding-16"">ABOUT ME</a>
        <a href=""#contact"" onclick=""w3_close()"" class=""w3-bar-item w3-button w3-center w3-padding-16"">CONTACT</a>
        <a href=""javascript:void()"" onclick=""w3_close()"" class=""w3-bar-item w3-button w3-center w3-padding-32"">CLOSE</a>
    </nav>

    <!-- Top menu on small screens -->
    <header class=""w3-container w3-top w3-white w3-xlarge w3-padding-16"">
        <div onclick=""window.location.href='/Home/Home'"">
            <span class=""w3-left w3-padding"">Library Manage</span>
        </div>
        <div class=""w3-right d-flex align-items-center"">
            <h4 class=""text-uppercase mt-2"">");
#nullable restore
#line 73 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                                        Write(ViewBag.userLogin.Urole);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h4>
            <a href=""javascript:void(0)"" class=""w3-button w3-white"" style=""text-decoration: none;"" onclick=""w3_open()"">☰</a>
        </div>
    </header>

    <!-- Overlay effect when opening sidebar on small screens -->
    <div class=""w3-overlay w3-animate-opacity"" onclick=""w3_close()"" style=""cursor:pointer"" title=""close side menu""
         id=""myOverlay""></div>

    <!-- !PAGE CONTENT! -->
    <div class=""w3-main w3-content"" style=""max-width:1600px;margin-top:83px"">
        <div class=""d-flex justify-content-center"">
            <h1 class=""p-3""><b>List Customers&nbsp;<i class=""bi bi-people""></i></b></h1>
        </div>
        <div class=""d-flex"">
            <div style=""width:100%"">
                <div class=""d-flex justify-content-end mb-1"">
");
#nullable restore
#line 90 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                     if (ViewBag.error != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"d-flex align-items-center\">\r\n                            <p class=\"mr-1\"><b style=\"color:red\">");
#nullable restore
#line 93 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                                                            Write(ViewBag.error);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></p>\r\n                        </div>\r\n");
#nullable restore
#line 95 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                     if (ViewBag.successful != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"d-flex align-items-center\">\r\n                            <p class=\"mr-1 d-flex align-items-center\"><b style=\"color:green\">");
#nullable restore
#line 99 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                                                                                        Write(ViewBag.successful);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></p>\r\n                        </div>\r\n");
#nullable restore
#line 101 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"mr-1\">\r\n");
#nullable restore
#line 103 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                         if (ViewBag.userLogin.Urole == "admin")
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <button class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#ModalAddBook\">Add Customer</button>\r\n");
#nullable restore
#line 106 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>
                </div>
                <table class=""table"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">Customer Name</th>
");
#nullable restore
#line 115 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                             if (ViewBag.userLogin.Urole == "admin")
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <th scope=\"col\">Customer Password</th>\r\n");
#nullable restore
#line 118 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <th scope=\"col\">Customer Phone</th>\r\n                            <th scope=\"col\">Customer Address</th>\r\n");
#nullable restore
#line 122 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                             if (ViewBag.userLogin.Urole == "admin")
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <th scope=\"col\">Edit</th>\r\n                                <th scope=\"col\">Delete</th>\r\n");
#nullable restore
#line 126 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 131 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                         foreach (User u in ViewBag.listCustomers)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 134 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                                       Write(u.Uid);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 135 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                           Write(u.Uname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 136 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                             if (ViewBag.userLogin.Urole == "admin")
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>");
#nullable restore
#line 138 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                               Write(u.Upass);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 139 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"

                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                             if (@u.Uphone == null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td><b style=\"color:red\">Empty</b></td>\r\n");
#nullable restore
#line 144 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>");
#nullable restore
#line 147 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                               Write(u.Uphone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 148 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 149 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                             if(@u.Uaddress == null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td><b style=\"color:red\">Empty</b></td>\r\n");
#nullable restore
#line 152 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>");
#nullable restore
#line 155 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                               Write(u.Uaddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 156 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                             if (ViewBag.userLogin.Urole == "admin")
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td><a href=\"#\"><i style=\"font-size:25px\" class=\"bi bi-pencil-square\"></i></a></td>\r\n                                <td><a href=\"#\"><i style=\"font-size:25px\" class=\"bi bi-trash\"></i></a></td>\r\n");
#nullable restore
#line 161 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 163 "E:\FPTuniversity\PRN211\Web_Library_Manage\Views\Home\ListCustomers.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>

        <div class=""modal fade"" id=""ModalAddBook"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">New Customer&nbsp;<i class=""bi bi-person-plus""></i></h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                        <form action=""AddCustomer"" method=""post"" onsubmit=""return confirm('Are you sure to add this Customer?')"">
                            <div class=""modal-body"">
                                    <div class=""form-group"">
                                    ");
                WriteLiteral(@"    <label for=""cusname"" class=""col-form-label"">Customer Name:</label>
                                        <input type=""text"" class=""form-control"" required id=""cusname"" name=""cusname"" placeholder=""Enter..."">
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""cuspassword"" class=""col-form-label"">Customer Password:</label>
                                        <input type=""text"" class=""form-control"" required id=""cuspassword"" name=""cuspassword"" placeholder=""Enter..."">
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""cusphone"" class=""col-form-label"">Customer Phone:</label>
                                        <input type=""text"" class=""form-control"" required id=""cusphone"" name=""cusphone"" placeholder=""Enter..."">
                                    </div>
                                  ");
                WriteLiteral(@"  <div class=""form-group"">
                                        <label for=""cusaddress"" class=""col-form-label"">Customer Address:</label>
                                        <input type=""text"" class=""form-control"" required id=""cusaddress"" name=""cusaddress"" placeholder=""Enter..."">
                                    </div>
                            </div>
                            <div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                                <button type=""submit"" class=""btn btn-primary"">Add</button>
                            </div>
                        </form>
                </div>
            </div>
        </div>

        <!-- Footer -->
        <footer class=""w3-container w3-padding-32 w3-grey"">
            <div class=""w3-row-padding"">
                <div class=""w3-third"">
                    <h3>INFO</h3>
                    <p>
                        This ");
                WriteLiteral(@"is a small library management system. Library Management is used for book management,
                        librarian management, order management, and both borrowed and returned customers.
                    </p>
                </div>

                <div class=""w3-third"">
                    <h3>BLOG POSTS</h3>
                    <ul class=""w3-ul"">
                        <li class=""w3-padding-16 w3-hover-black""
                            onclick=""window.location.href='https://www.feedspot.com/infiniterss.php?_src=feed_title&followfeedid=4734800&q=site:http%3A%2F%2Fwww.noshelfrequired.com%2Ffeed%2F'"">
                            <img src=""https://i1.feedspot.com/200/4734800.jpg?t=1644308182""
                                 class=""w3-left w3-margin-right"" style=""width:50px"">
                            <span class=""w3-large"">No Shelf Required</span><br>
                            <span>
                                Portal on all aspects of ebooks and digital content and for all crea");
                WriteLiteral(@"ting, reading,
                                publishing...
                            </span>
                        </li>
                        <li class=""w3-padding-16 w3-hover-black""
                            onclick=""window.location.href='https://www.feedspot.com/infiniterss.php?_src=feed_title&followfeedid=35096&q=site:https%3A%2F%2Fwww.librarian.net%2Ffeed%2F'"">
                            <img src=""https://i1.feedspot.com/200/35096.jpg?t=1604395915"" class=""w3-left w3-margin-right"" style=""width:50px"">
                            <span class=""w3-large"">Librarian</span><br>
                            <span>
                                Hi, My name is Jessamyn West and I'm a library technologist living in
                                Vermont...
                            </span>
                        </li>
                    </ul>
                </div>

                <div class=""w3-third"">
                    <h3>POPULAR TAGS</h3>
                    <img src=""https:");
                WriteLiteral(@"//i.pinimg.com/564x/42/81/f1/4281f1ab348f8e71eefba010d277daeb.jpg"" style=""width:40px;border-radius: 90%;"">
                    <img src=""https://i.pinimg.com/564x/43/85/a5/4385a5479214954fa9fab6f1a778623f.jpg"" style=""width:40px;border-radius: 90%;"">
                    <img src=""https://i.pinimg.com/564x/88/aa/93/88aa93c7d7d0b4f3bb45a0c7ad8f9a4b.jpg"" style=""width:40px;border-radius: 90%;"">
                </div>
            </div>
        </footer>

        <div class=""w3-black w3-center w3-padding-24"">
            Powered by <a href=""#"" title=""W3.CSS"" target=""_blank""
                          class=""w3-hover-opacity"">Nhat Thanh</a>
        </div>

        <!-- End page content -->
    </div>

    <script>
        // Script to open and close sidebar
        function w3_open() {
            document.getElementById(""mySidebar"").style.display = ""block"";
            document.getElementById(""myOverlay"").style.display = ""block"";
        }

        function w3_close() {
            document.ge");
                WriteLiteral(@"tElementById(""mySidebar"").style.display = ""none"";
            document.getElementById(""myOverlay"").style.display = ""none"";
        }
    </script>
    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js""
            integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN""
            crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.12.9/dist/umd/popper.min.js""
            integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q""
            crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/js/bootstrap.min.js""
            integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl""
            crossorigin=""anonymous""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
