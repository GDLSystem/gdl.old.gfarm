using System.Collections.Generic;
using Nop.Web.Framework.Models;
using Nop.Web.Models.Common;
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
        public IList<CheckoutPaymentMethodModel.PaymentMethodModel> PaymentMethods { get; set; }
    }

    public record OnePageCheckoutSubmitCustom : CheckoutBillingAddressModel
    {
        public string PaymentMethod { get; set; }
    }
}