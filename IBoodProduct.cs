using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace IBoodHuntMonitor
{
    //<div id="prices">
    //<p><span class="old-price">€ 279,95</span></p>
    //<p class="our-price"><span class="hidden">iBOOD Prijs</span><span>Nu! </span>€ 79,95 <em><a href="/be/nl/how_place_order#delivery_costs">+&nbsp;(8,95)</a></em> </p>
    //</div>
    //<div id="issoldout" style="display:none">
    //Let op! De volgende aanbieding komt eraan!<p id="btnsoldout" class="big-gfx no-point"><span>Uitverkocht!</span></p>
    //</div>
    //<div id="notsoldout">
    //<a id="btnbuy" href="https://order.ibood.com/be/nl/order/?id=12895" title="Ik neem er een!">
    //    <img src="/imgdesign/buy_button_nl.gif" alt="Ik neem er een!" >
    //</a>
    //</div>
    public class IBoodProduct
    {
        public string Name { get; private set; }
        public decimal RegularPrice { get; private set; }
        public decimal OurPrice { get; private set; }
        public decimal ShippingCost { get; private set; }
        public ProductStatus Status { get; private set; }
        public Uri ImageUri { get; private set; }
        public Uri MoreInfoUri { get; private set; }
        public Uri BuyNowUri { get; private set; }
        public override string ToString()
        {
            return String.Format("Name: {0}\r\n\tRegularPrice: {1} EUR\r\n\tOurPrice: {2} EUR + ShippingCost: {5} EUR\r\n\tImageUrl: {3}\r\n\tStatus: {4}\r\n", Name, RegularPrice, OurPrice, ImageUri, Status, ShippingCost);
        }

        public static IBoodProduct Create(HtmlDocument doc)
        {
            try { 
                var all = doc.All.Cast<HtmlElement>();
                var imgs = doc.Images.Cast<HtmlElement>();
            
                var img = GetElement(all, "IMG", "className", "main-prod-img") ?? imgs.FirstOrDefault(i => i.OuterHtml.Contains("class=main-prod-img"));
            
                var prodName = string.Empty;
                var prodImage = string.Empty;
                if (img != null) { 
                    prodName = img.GetAttribute("alt");
                    prodImage = img.GetAttribute("src");
                }

                var spanOldPrice = GetElement(all, "SPAN", "className", "old-price");
                decimal oldPrice = 0;
                try {
                    oldPrice = decimal.Parse(spanOldPrice.InnerText, System.Globalization.NumberStyles.Currency);
                }
                catch { }
            
                var spanOurPrice = GetElement(all, "P", "className", "our-price");
                decimal ourPrice = 0;
                decimal shippingCost = 0;
                try {
                    // "iBOOD PrijsNu! € 149,95 + (8,95) "
                    var priceParts = spanOurPrice.InnerText.Split(new char[] {'€', ' ', '+', '(' ,')'}, StringSplitOptions.RemoveEmptyEntries );
                    shippingCost   = decimal.Parse(priceParts[2]);
                    ourPrice = decimal.Parse(priceParts[3]); //decimal.Parse(spanOurPrice.InnerText, System.Globalization.NumberStyles.Currency);
                }
                catch { }

                var divIsSoldOut = GetElement(all, "DIV", "id", "issoldout");
                var isSoldOut = divIsSoldOut != null && divIsSoldOut.Style.ToLower() == "display:none";

                var aMoreInfo = GetElement(all, "A", "id", "speclink");
                var moreInfoUri = aMoreInfo.GetAttribute("href");

                var aBuyNow = GetElement(all, "A", "id", "btnbuy");
                var buyNowUri = aBuyNow.GetAttribute("href");

                return new IBoodProduct { 
                    Name = prodName, 
                    ImageUri = new Uri(prodImage), 
                    Status = isSoldOut ? ProductStatus.IsSoldOut : ProductStatus.NotSoldOut, 
                    RegularPrice = oldPrice, 
                    OurPrice= ourPrice ,
                    ShippingCost = shippingCost,
                    MoreInfoUri = new Uri(moreInfoUri),
                    BuyNowUri = new Uri(buyNowUri)
                };
            }
            catch { }
            return null;
        }

        private static HtmlElement GetElement(IEnumerable<HtmlElement> all, string tagName, string attrName, string attrValue)
        {
            return all.FirstOrDefault(el => el.TagName == tagName && (string)el.DomElement.GetValue(attrName) == attrValue);
        }
    }

    public enum ProductStatus {
        NotSoldOut,
        IsSoldOut
    }
}
