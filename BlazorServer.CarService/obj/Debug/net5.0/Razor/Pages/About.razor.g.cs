#pragma checksum "C:\Users\laptopclub3007119711\source\repos\BlazorServer.CarService\BlazorServer.CarService\Pages\About.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d36473ebf48eb7b230797b8e50313663b6505d578dc66a7f2052facf4e45d780"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServer.CarService.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\laptopclub3007119711\source\repos\BlazorServer.CarService\BlazorServer.CarService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\laptopclub3007119711\source\repos\BlazorServer.CarService\BlazorServer.CarService\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\laptopclub3007119711\source\repos\BlazorServer.CarService\BlazorServer.CarService\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\laptopclub3007119711\source\repos\BlazorServer.CarService\BlazorServer.CarService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\laptopclub3007119711\source\repos\BlazorServer.CarService\BlazorServer.CarService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\laptopclub3007119711\source\repos\BlazorServer.CarService\BlazorServer.CarService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\laptopclub3007119711\source\repos\BlazorServer.CarService\BlazorServer.CarService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\laptopclub3007119711\source\repos\BlazorServer.CarService\BlazorServer.CarService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\laptopclub3007119711\source\repos\BlazorServer.CarService\BlazorServer.CarService\_Imports.razor"
using BlazorServer.CarService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\laptopclub3007119711\source\repos\BlazorServer.CarService\BlazorServer.CarService\_Imports.razor"
using BlazorServer.CarService.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/about")]
    public partial class About : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container-xxl py-5\"><div class=\"container\"><div class=\"row g-5\"><div class=\"col-lg-6 pt-4\" style=\"min-height: 400px;\"><div class=\"position-relative h-100 wow fadeIn\" data-wow-delay=\"0.1s\"><img class=\"position-absolute img-fluid w-100 h-100\" src=\"img/about.jpg\" style=\"object-fit: cover;\" alt>\r\n                    <div class=\"position-absolute top-0 end-0 mt-n4 me-n4 py-4 px-5\" style=\"background: rgba(0, 0, 0, .08);\"><h1 class=\"display-4 text-white mb-0\">15 <span class=\"fs-4\">Years</span></h1>\r\n                        <h4 class=\"text-white\">Experience</h4></div></div></div>\r\n            <div class=\"col-lg-6\"><h5 class=\"text-primary text-uppercase\">[ About Us ]</h5>\r\n                <h1 class=\"mb-4\"><span class=\"text-primary\">Service-Hub</span> Is The Best Place For Your Auto Care</h1>\r\n                <p class=\"mb-4\">Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit, sed stet lorem sit clita duo justo magna dolore erat amet</p>\r\n                <div class=\"row g-4 mb-3 pb-3\"><div class=\"col-12 wow fadeIn\" data-wow-delay=\"0.1s\"><div class=\"d-flex\"><div class=\"bg-light d-flex flex-shrink-0 align-items-center justify-content-center mt-1\" style=\"width: 45px; height: 45px;\"><span class=\"fw-bold text-secondary\">01</span></div>\r\n                            <div class=\"ps-3\"><h6>Professional & Expert</h6>\r\n                                <span>Diam dolor diam ipsum sit amet diam et eos</span></div></div></div>\r\n                    <div class=\"col-12 wow fadeIn\" data-wow-delay=\"0.3s\"><div class=\"d-flex\"><div class=\"bg-light d-flex flex-shrink-0 align-items-center justify-content-center mt-1\" style=\"width: 45px; height: 45px;\"><span class=\"fw-bold text-secondary\">02</span></div>\r\n                            <div class=\"ps-3\"><h6>Quality Servicing Center</h6>\r\n                                <span>Diam dolor diam ipsum sit amet diam et eos</span></div></div></div>\r\n                    <div class=\"col-12 wow fadeIn\" data-wow-delay=\"0.5s\"><div class=\"d-flex\"><div class=\"bg-light d-flex flex-shrink-0 align-items-center justify-content-center mt-1\" style=\"width: 45px; height: 45px;\"><span class=\"fw-bold text-secondary\">03</span></div>\r\n                            <div class=\"ps-3\"><h6>Awards Winning Workers</h6>\r\n                                <span>Diam dolor diam ipsum sit amet diam et eos</span></div></div></div></div>\r\n                <a href class=\"btn btn-primary py-3 px-5\">Read More<i class=\"fa fa-arrow-right ms-3\"></i></a></div></div></div></div>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, @"<div class=""container-fluid fact bg-dark my-5 py-5""><div class=""container""><div class=""row g-4""><div class=""col-md-6 col-lg-3 text-center wow fadeIn"" data-wow-delay=""0.1s""><i class=""fa fa-check fa-2x text-white mb-3""></i>
                <h2 class=""text-white mb-2"" data-toggle=""counter-up"">1234</h2>
                <p class=""text-white mb-0"">Years Experience</p></div>
            <div class=""col-md-6 col-lg-3 text-center wow fadeIn"" data-wow-delay=""0.3s""><i class=""fa fa-users-cog fa-2x text-white mb-3""></i>
                <h2 class=""text-white mb-2"" data-toggle=""counter-up"">1234</h2>
                <p class=""text-white mb-0"">Expert Technicians</p></div>
            <div class=""col-md-6 col-lg-3 text-center wow fadeIn"" data-wow-delay=""0.5s""><i class=""fa fa-users fa-2x text-white mb-3""></i>
                <h2 class=""text-white mb-2"" data-toggle=""counter-up"">1234</h2>
                <p class=""text-white mb-0"">Satisfied Clients</p></div>
            <div class=""col-md-6 col-lg-3 text-center wow fadeIn"" data-wow-delay=""0.7s""><i class=""fa fa-car fa-2x text-white mb-3""></i>
                <h2 class=""text-white mb-2"" data-toggle=""counter-up"">1234</h2>
                <p class=""text-white mb-0"">Compleate Projects</p></div></div></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
