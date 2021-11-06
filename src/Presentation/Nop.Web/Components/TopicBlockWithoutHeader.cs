using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;

namespace Nop.Web.Components
{
    public class TopicBlockWithoutHeaderViewComponent : NopViewComponent
    {
        private readonly ITopicModelFactory _topicModelFactory;

        public TopicBlockWithoutHeaderViewComponent(ITopicModelFactory topicModelFactory)
        {
            _topicModelFactory = topicModelFactory;
        }

        /// <returns>A task that represents the asynchronous operation</returns>
        public async Task<IViewComponentResult> InvokeAsync(string systemName)
        {
            var model = await _topicModelFactory.PrepareTopicModelBySystemNameAsync(systemName);
            if (model == null)
                return Content("");
            
            return View(model);
        }
    }
}
