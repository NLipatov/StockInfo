#pragma checksum "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15d9cdfc20d3814b3ce5a79dcce6c0c58d0dab26"
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
#line 11 "C:\Users\Admin\source\repos\StockInfo\StockInfo\_Imports.razor"
using HtmlAgilityPack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\source\repos\StockInfo\StockInfo\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Admin\source\repos\StockInfo\StockInfo\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/stockInfo")]
    public partial class StockInformationPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>StockInformation Page</h3>");
#nullable restore
#line 6 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
 if (enteredTicket != String.Empty)
{
    if (StocksStoredInDb.FirstOrDefault(s => s.Ticket == enteredTicket) != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
                           AddOrUpdate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Update ");
            __builder.AddContent(4, 
#nullable restore
#line 10 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
                                                enteredTicket.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " record in DB");
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
                           AddOrUpdate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Add ");
            __builder.AddContent(9, 
#nullable restore
#line 14 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
                                             enteredTicket.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, " To DB");
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
    }
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<button>Enter ticket →</button>");
#nullable restore
#line 20 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "placeholder", "Ticket");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
                                         enteredTicket

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => enteredTicket = __value, enteredTicket));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.OpenElement(17, "p");
            __builder.AddContent(18, "Answer from DB Service: ");
            __builder.AddContent(19, 
#nullable restore
#line 24 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
                            DbStoringStatus

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
 if (enteredTicket == String.Empty)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "<p>Provide ticket to input box</p>");
#nullable restore
#line 28 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, 
#nullable restore
#line 31 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
        GetPrice(enteredTicket)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, " ");
            __builder.AddContent(24, 
#nullable restore
#line 31 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
                                 currency

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
     if (enteredTicket != String.Empty)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "p");
            __builder.AddContent(26, "Entered Value: ");
            __builder.AddContent(27, 
#nullable restore
#line 34 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
                            (enteredTicket).ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, " — ");
            __builder.AddContent(29, 
#nullable restore
#line 34 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
                                                          companyname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Admin\source\repos\StockInfo\StockInfo\Pages\StockInformationPage.razor"
       
    List<Stock> StocksStoredInDb = new();
    protected override async void OnInitialized()
    {
        StocksStoredInDb = await stockService.GetAllStocksAsync();
    }

    string DbStoringStatus = "waiting for answer";


    private async Task<bool> AddOrUpdate()
    {
        Stock stockStoredInDb = StocksStoredInDb.FirstOrDefault(s => s.Ticket == enteredTicket);
        if (stockStoredInDb != null)
        {
            stockStoredInDb.Price = price;
            stockStoredInDb.LastUpdate = DateTime.Now;
            bool status = await stockService.UpdateStockAsync(stockStoredInDb);
            if (status == true)
            {
                DbStoringStatus = $"succescfully updated {companyname}!";
            }
            return status;
        }
        else
        {
            try
            {
                bool status = await stockService.InsertStockAsync(new Stock
                {
                    CompanyName = companyname,
                    Currency = currency,
                    Price = price,
                    Ticket = enteredTicket,
                    LastUpdate = DateTime.Now
                });

                if (status == true)
                {
                    DbStoringStatus = $"succescfully stored {companyname}!";
                }
                return status;
            }
            catch
            {
                DbStoringStatus = "Error";
                return false;
            }
        }
    }

    string enteredTicket = "";
    string companyname = "";
    string price = "";
    string currency = "";

    private string GetPrice(string ticket)
    {
        companyname = "";
        var html = @$"https://finance.yahoo.com/quote/{ticket}";
        HtmlWeb web = new HtmlWeb();
        var htmlDoc = web.Load(html);
        var PriceValue = htmlDoc.DocumentNode.SelectSingleNode("//span[@class='Trsdu(0.3s) Fw(b) Fz(36px) Mb(-4px) D(ib)']");
        var CompanyName = htmlDoc.DocumentNode.SelectSingleNode("//h1[@class='D(ib) Fz(18px)']");
        HtmlNode CurrencyString = htmlDoc.DocumentNode.SelectSingleNode("//span[@data-reactid='9']");
        while (CurrencyString == null)
        {
            htmlDoc = web.Load(html);
            CurrencyString = htmlDoc.DocumentNode.SelectSingleNode("//span[@data-reactid='9']");
        }
        Regex regex = new Regex(@"\w*$");
        currency = (regex.Match(CurrencyString.InnerText).Value);
        if (CompanyName != null)
        {
            companyname = HttpUtility.HtmlDecode(CompanyName.InnerText);
        }
        if (PriceValue != null)
        {
            price = PriceValue.InnerText;
            return (PriceValue.InnerText);
        }
        else
        {
            return "Not found";
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Models.StockService stockService { get; set; }
    }
}
#pragma warning restore 1591
