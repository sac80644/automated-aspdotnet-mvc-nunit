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

namespace BankingSite.Views.LoanApplicationSearch
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/LoanApplicationSearch/ApplicationStatus.cshtml")]
    public partial class ApplicationStatus : System.Web.Mvc.WebViewPage<BankingSite.Models.LoanApplication>
    {
        public ApplicationStatus()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\LoanApplicationSearch\ApplicationStatus.cshtml"
  
    ViewBag.Title = "Loan Application Status";    

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>");

            
            #line 7 "..\..\Views\LoanApplicationSearch\ApplicationStatus.cshtml"
Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n\r\n<h3");

WriteLiteral(" id=\"firstName\"");

WriteLiteral(">");

            
            #line 9 "..\..\Views\LoanApplicationSearch\ApplicationStatus.cshtml"
              Write(Model.FirstName);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n<h3");

WriteLiteral(" id=\"status\"");

WriteLiteral(">\r\n");

            
            #line 12 "..\..\Views\LoanApplicationSearch\ApplicationStatus.cshtml"
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\LoanApplicationSearch\ApplicationStatus.cshtml"
     if (Model.IsAccepted){

            
            #line default
            #line hidden
WriteLiteral("        <span");

WriteLiteral(" id=\"acceptedMessage\"");

WriteLiteral(">Yippie! Accepted!</span>\r\n");

            
            #line 14 "..\..\Views\LoanApplicationSearch\ApplicationStatus.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <span");

WriteLiteral(" id=\"declinedMessage\"");

WriteLiteral(">Sorry. Declined.</span>\r\n");

            
            #line 18 "..\..\Views\LoanApplicationSearch\ApplicationStatus.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

        }
    }
}
#pragma warning restore 1591
