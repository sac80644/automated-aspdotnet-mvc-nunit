﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankingSite.Views.LoanApplication
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using BankingSite;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/LoanApplication/Accepted.cshtml")]
    public partial class Accepted : System.Web.Mvc.WebViewPage<BankingSite.Models.LoanApplication>
    {
        public Accepted()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\LoanApplication\Accepted.cshtml"
  
    ViewBag.Title = "Loan Application";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2");

WriteLiteral(" id=\"acceptMessage\"");

WriteLiteral(">Congratulations ");

            
            #line 7 "..\..\Views\LoanApplication\Accepted.cshtml"
                                  Write(Model.FirstName);

            
            #line default
            #line hidden
WriteLiteral(" - Your application was accepted!</h2>\r\n\r\n<h3>Your reference number is: ");

            
            #line 9 "..\..\Views\LoanApplication\Accepted.cshtml"
                         Write(Model.ID);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n<div>\r\n    <h4>Loan Application Details</h4>\r\n    <hr />\r\n    <dl");

WriteLiteral(" class=\"dl-horizontal\"");

WriteLiteral(">\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 15 "..\..\Views\LoanApplication\Accepted.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n    \r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 19 "..\..\Views\LoanApplication\Accepted.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n    \r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 23 "..\..\Views\LoanApplication\Accepted.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n    \r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 27 "..\..\Views\LoanApplication\Accepted.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n    \r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 31 "..\..\Views\LoanApplication\Accepted.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n    \r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 35 "..\..\Views\LoanApplication\Accepted.cshtml"
       Write(Html.DisplayFor(model => model.Age));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n    \r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 39 "..\..\Views\LoanApplication\Accepted.cshtml"
       Write(Html.DisplayNameFor(model => model.AnnualIncome));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n    \r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 43 "..\..\Views\LoanApplication\Accepted.cshtml"
       Write(Html.DisplayFor(model => model.AnnualIncome));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
