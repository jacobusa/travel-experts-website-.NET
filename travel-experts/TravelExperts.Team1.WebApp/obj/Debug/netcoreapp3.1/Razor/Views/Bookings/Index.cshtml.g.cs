#pragma checksum "C:\Users\853734\Desktop\TravelExpertsFinal\travel-experts\TravelExperts.Team1.WebApp\Views\Bookings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d10b803ddd879c51c08ae2c2ec12424fa1b31b7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_Index), @"mvc.1.0.view", @"/Views/Bookings/Index.cshtml")]
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
#line 1 "C:\Users\853734\Desktop\TravelExpertsFinal\travel-experts\TravelExperts.Team1.WebApp\Views\_ViewImports.cshtml"
using TravelExperts.Team1.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\853734\Desktop\TravelExpertsFinal\travel-experts\TravelExperts.Team1.WebApp\Views\_ViewImports.cshtml"
using TravelExperts.Team1.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d10b803ddd879c51c08ae2c2ec12424fa1b31b7c", @"/Views/Bookings/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f911707156a0e4cca98190738059f00d09efcdc", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TravelExperts.Team1.WebApp.Models.BookingsViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\853734\Desktop\TravelExpertsFinal\travel-experts\TravelExperts.Team1.WebApp\Views\Bookings\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<h1 class=""text-center text-sm-center text-md-center text-lg-center text-xl-center"">Booking Summary</h1>
<br />
<div class=""row justify-content-center"">
    <div class=""col-auto"">
        <table class=""table table-responsive"">
            <thead>
                <tr>
");
            WriteLiteral("                    <th>\r\n                        ");
#nullable restore
#line 23 "C:\Users\853734\Desktop\TravelExpertsFinal\travel-experts\TravelExperts.Team1.WebApp\Views\Bookings\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ItineraryNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 26 "C:\Users\853734\Desktop\TravelExpertsFinal\travel-experts\TravelExperts.Team1.WebApp\Views\Bookings\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TripStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 29 "C:\Users\853734\Desktop\TravelExpertsFinal\travel-experts\TravelExperts.Team1.WebApp\Views\Bookings\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TripEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"text-align: center\">\r\n                        ");
#nullable restore
#line 32 "C:\Users\853734\Desktop\TravelExpertsFinal\travel-experts\TravelExperts.Team1.WebApp\Views\Bookings\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"text-align: center\">\r\n                        ");
#nullable restore
#line 35 "C:\Users\853734\Desktop\TravelExpertsFinal\travel-experts\TravelExperts.Team1.WebApp\Views\Bookings\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"text-align: center\">\r\n                        ");
#nullable restore
#line 38 "C:\Users\853734\Desktop\TravelExpertsFinal\travel-experts\TravelExperts.Team1.WebApp\Views\Bookings\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 45 "C:\Users\853734\Desktop\TravelExpertsFinal\travel-experts\TravelExperts.Team1.WebApp\Views\Bookings\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 55 "C:\Users\853734\Desktop\TravelExpertsFinal\travel-experts\TravelExperts.Team1.WebApp\Views\Bookings\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ItineraryNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 58 "C:\Users\853734\Desktop\TravelExpertsFinal\travel-experts\TravelExperts.Team1.WebApp\Views\Bookings\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TripStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 61 "C:\Users\853734\Desktop\TravelExpertsFinal\travel-experts\TravelExperts.Team1.WebApp\Views\Bookings\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TripEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align: center\">\r\n                            ");
#nullable restore
#line 64 "C:\Users\853734\Desktop\TravelExpertsFinal\travel-experts\TravelExperts.Team1.WebApp\Views\Bookings\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td style=\"text-align: center\">\r\n                            ");
#nullable restore
#line 68 "C:\Users\853734\Desktop\TravelExpertsFinal\travel-experts\TravelExperts.Team1.WebApp\Views\Bookings\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align: right; padding-right:30px\">\r\n                            ");
#nullable restore
#line 71 "C:\Users\853734\Desktop\TravelExpertsFinal\travel-experts\TravelExperts.Team1.WebApp\Views\Bookings\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 75 "C:\Users\853734\Desktop\TravelExpertsFinal\travel-experts\TravelExperts.Team1.WebApp\Views\Bookings\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td colspan=\"5\"><h4>Bookings Total</h4></td>\r\n                    <td><h4>$");
#nullable restore
#line 81 "C:\Users\853734\Desktop\TravelExpertsFinal\travel-experts\TravelExperts.Team1.WebApp\Views\Bookings\Index.cshtml"
                        Write(ViewBag.bookingsTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n                </tr>\r\n\r\n            </tbody>\r\n        </table>\r\n\r\n\r\n    </div>\r\n    \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TravelExperts.Team1.WebApp.Models.BookingsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
