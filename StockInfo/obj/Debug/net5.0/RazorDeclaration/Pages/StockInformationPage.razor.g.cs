// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
