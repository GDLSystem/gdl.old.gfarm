using System.Collections.Generic;
using Nop.Web.Framework.Models;
using Nop.Web.Models.ShoppingCart;

namespace Nop.Web.Models.Checkout
{
    public partial record OnePageCheckoutModel : BaseNopModel
    {
        public OnePageCheckoutModel()
        {
            BillingAddress = new CheckoutBillingAddressModel();
        }
        public bool ShippingRequired { get; set; }
        public bool DisableBillingAddressCheckoutStep { get; set; }

        public CheckoutBillingAddressModel BillingAddress { get; set; }
        public CheckoutPaymentInfoModel CheckoutPaymentInfo { get; set; }
        
        public ShoppingCartModel ShoppingCart { get; set; }
    }

}