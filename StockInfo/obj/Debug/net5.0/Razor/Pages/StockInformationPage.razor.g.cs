#pragma checksum "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a13d192da603fc9d67f65e2698de8be1e8c965ec"
// <auto-generated/>
#pragma warning disable 1591
namespace StockInfo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\StockInfo\StockInfo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\StockInfo\StockInfo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\StockInfo\StockInfo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\source\repos\StockInfo\StockInfo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\source\repos\StockInfo\StockInfo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\source\repos\StockInfo\StockInfo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\source\repos\StockInfo\StockInfo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\source\repos\StockInfo\StockInfo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\source\repos\StockInfo\StockInfo\_Imports.razor"
using StockInfo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\source\repos\StockInfo\StockInfo\_Imports.razor"
using StockInfo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
using HtmlAgilityPack;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/stockInfo")]
    public partial class StockInformationPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>StockInformationPage</h3>\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
                    enteredTicket

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => enteredTicket = __value, enteredTicket));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "Entered Value: ");
            __builder.AddContent(7, 
#nullable restore
#line 6 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
                   enteredTicket

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
 if (enteredTicket == String.Empty)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<p>Provide ticket to input box</p>");
#nullable restore
#line 11 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, 
#nullable restore
#line 14 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
        GetPrice(enteredTicket)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
         
    string enteredTicket = "";
    string price = "";

    private string GetPrice(string ticket)
    {
        var html = @$"https://finance.yahoo.com/quote/{ticket}";
        HtmlWeb web = new HtmlWeb();
        var htmlDoc = web.Load(html);
        var PriceValue = htmlDoc.DocumentNode.SelectSingleNode("//span[@class='Trsdu(0.3s) Fw(b) Fz(36px) Mb(-4px) D(ib)']");
        return (PriceValue.InnerText);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
