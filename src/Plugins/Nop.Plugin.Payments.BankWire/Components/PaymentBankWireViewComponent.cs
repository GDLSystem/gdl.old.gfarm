using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Plugin.Payments.BankWire.Models;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Payments.BankWire.Components
{
    [ViewComponent(Name = "PaymentBankWire")]
    public class PaymentBankWireViewComponent : NopViewComponent
    {
        private readonly BankWirePaymentSettings _bankWirePaymentSettings;
        private readonly IWorkContext _workContext;
        private readonly IStoreContext _storeContext;
        private readonly ILocalizationService _localizationService;

        public PaymentBankWireViewComponent(BankWirePaymentSettings bankWirePaymentSettings,
            IWorkContext workContext,
            IStoreContext storeContext, ILocalizationService localizationService)
        {
            this._workContext = workContext;
            this._storeContext = storeContext;
            _localizationService = localizationService;
            _bankWirePaymentSettings = bankWirePaymentSettings;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new PaymentInfoModel
            {
                DescriptionText = await _localizationService.GetLocalizedSettingAsync(_bankWirePaymentSettings,
                    x => x.DescriptionText, (await _workContext.GetWorkingLanguageAsync()).Id, (await _storeContext.GetCurrentStoreAsync()).Id)
            };

            return View("~/Plugins/Payments.BankWire/Views/PaymentInfo.cshtml", model);
        }
    }
}
