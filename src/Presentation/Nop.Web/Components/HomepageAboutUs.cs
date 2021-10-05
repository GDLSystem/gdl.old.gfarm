using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Services.Topics;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;
using Nop.Web.Models.Topics;

namespace Nop.Web.Components
{
    public class HomepageAboutUs : NopViewComponent
    {
        private readonly ITopicModelFactory _topicModelFactory;

        public HomepageAboutUs(ITopicModelFactory topicModelFactory)
        {
            _topicModelFactory = topicModelFactory;
        }

        /// <returns>A task that represents the asynchronous operation</returns>
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var homeAboutTopic = await _topicModelFactory.PrepareTopicModelBySystemNameAsync("HomeAbout");
            var homeTestimonialsTopic = await _topicModelFactory.PrepareTopicModelBySystemNameAsync("HomeTestimonials");
            return View(new HomeAboutModel{AboutModel = homeAboutTopic,HomeTestimonialModel = homeTestimonialsTopic});
        }
    }
}